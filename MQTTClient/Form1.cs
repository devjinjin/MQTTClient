using MQTTClient.MQTT;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTTClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(closing);
            MqttManager.Instance.ReceiveResponseCallback += CallbackResponseEvent;
            this.MqttDisConnectbutton.Enabled = false;
            this.MqttSubscribButton.Enabled = false;
            this.mqttSubscribeStrTextBox.Enabled = false;
        }

        private void mqttConnectButton_Click(object sender, EventArgs e)
        {
            if (this.MqttAddressTextbox.Text.Length == 0)
            {
                MessageBox.Show("연결주소입력하세요", "Message");
                return;
            }
            if (this.MqttIdTextbox.Text.Length == 0)
            {
                MessageBox.Show("아이디 입력하세요", "Message");
                return;
            }

            if (this.MqttPasswordTextbox.Text.Length == 0)
            {
                MessageBox.Show("비밀번호입력하세요", "Message");
                return;
            }
     
            _ = Task.Run(async () =>
            {
                var result = await MqttManager.Instance.Connect_Client(MqttAddressTextbox.Text, MqttIdTextbox.Text, MqttPasswordTextbox.Text);

                MqttConnectButton.Invoke((MethodInvoker)(() =>
                {
                    if (result.Item1)
                    {
                        this.MqttConnectButton.Enabled = false;
                        this.MqttDisConnectbutton.Enabled = true;
                        this.mqttSubscribeStrTextBox.Enabled = true;
                        this.MqttSubscribButton.Enabled = true;
                        this.MqttAddressTextbox.Enabled = false;
                        this.MqttIdTextbox.Enabled = false;
                        this.MqttPasswordTextbox.Enabled = false;
                        MessageBox.Show(result.Item2, "Message");
                    }
                    else
                    {
                        this.MqttConnectButton.Enabled = true;
                        this.MqttDisConnectbutton.Enabled = false;
                        this.mqttSubscribeStrTextBox.Enabled = false;
                        this.MqttAddressTextbox.Enabled = true;
                        this.MqttIdTextbox.Enabled = true;
                        this.MqttPasswordTextbox.Enabled = true;
                        this.MqttSubscribButton.Enabled = false;
                        MessageBox.Show(result.Item2, "Message");
                    }
                }));

            });

        }
        private void CallbackResponseEvent(string arg)
        {
            richTextBox1.Invoke((MethodInvoker)(async () =>
            {
                if (arg.Length > 0)
                {
                    //if (arg.Split(',').Length > 0)
                    //{
                    //    var splitedArray = arg.Split(',');
                    //    if (splitedArray.Length == 4)
                    //    {
                    //        var logData = splitedArray[1] + "," + splitedArray[2];

                    //        richTextBox1.Text = richTextBox1.Text + $"{logData}\n";
                    //    }
                    //    else {
                    //        richTextBox1.Text = richTextBox1.Text + $"{arg}\n";
                    //    }
                    //}
                    //else {
                    richTextBox1.AppendText($"{arg}\n");
                    richTextBox1.ScrollToCaret();
                    //}
                }

            }));
        }

        private void mqttDisConnectbutton_Click(object sender, EventArgs e)
        {

            _ = Task.Run(async () =>
            {
                var result = await MqttManager.Instance.Clean_Disconnect();

                MqttConnectButton.Invoke((MethodInvoker)(() =>
                {
                    this.MqttConnectButton.Enabled = true;
                    this.MqttDisConnectbutton.Enabled = false;
                    this.mqttSubscribeStrTextBox.Enabled = false;
                    this.MqttSubscribButton.Enabled = true;
                    this.MqttSubscribButton.Enabled = false;
                    this.MqttIdTextbox.Enabled = true;
                    this.MqttPasswordTextbox.Enabled = true;
                    this.mqttSubscribeStrTextBox.Text = "";
                    MessageBox.Show("연결종료", "Message");
                }));

            });

        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            _ = MqttManager.Instance.Clean_Disconnect().Result;

            MqttManager.Instance.ReceiveResponseCallback -= CallbackResponseEvent;

            Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!MqttManager.Instance.IsConnected())
            {
                MessageBox.Show("Mqtt연결부터 해주세요", "Message");
                return;
            }

            if (mqttSubscribeStrTextBox.Text.Length == 0) {
                MessageBox.Show("구독 문자열이 비어 있습니다", "Message");
                return;
            }

            _ = Task.Run(async () =>
            {
                var result = await MqttManager.Instance.Subscribe(mqttSubscribeStrTextBox.Text);

                MqttSubscribButton.Invoke((MethodInvoker)(() =>
                {
                    this.MqttSubscribButton.Enabled = false;
                    this.mqttSubscribeStrTextBox.Enabled=false;

                    MessageBox.Show("구독처리완료", "Message");
                }));

            });
        }

        private void ClearTextButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }
    }
}
