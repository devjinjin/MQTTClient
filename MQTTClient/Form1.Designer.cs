namespace MQTTClient
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MqttAddressTextbox = new System.Windows.Forms.TextBox();
            this.mqttAddressLabel = new System.Windows.Forms.Label();
            this.MqttConnectButton = new System.Windows.Forms.Button();
            this.MqttDisConnectbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MqttIdTextbox = new System.Windows.Forms.TextBox();
            this.mqttPasswordLabel = new System.Windows.Forms.Label();
            this.MqttPasswordTextbox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MqttSubscribButton = new System.Windows.Forms.Button();
            this.mqttSubscribeStrTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearTextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MqttAddressTextbox
            // 
            this.MqttAddressTextbox.Location = new System.Drawing.Point(115, 13);
            this.MqttAddressTextbox.Name = "MqttAddressTextbox";
            this.MqttAddressTextbox.Size = new System.Drawing.Size(259, 25);
            this.MqttAddressTextbox.TabIndex = 0;
            // 
            // mqttAddressLabel
            // 
            this.mqttAddressLabel.AutoSize = true;
            this.mqttAddressLabel.Location = new System.Drawing.Point(21, 16);
            this.mqttAddressLabel.Name = "mqttAddressLabel";
            this.mqttAddressLabel.Size = new System.Drawing.Size(82, 15);
            this.mqttAddressLabel.TabIndex = 1;
            this.mqttAddressLabel.Text = "MQTT 주소";
            // 
            // MqttConnectButton
            // 
            this.MqttConnectButton.Location = new System.Drawing.Point(403, 16);
            this.MqttConnectButton.Name = "MqttConnectButton";
            this.MqttConnectButton.Size = new System.Drawing.Size(191, 103);
            this.MqttConnectButton.TabIndex = 3;
            this.MqttConnectButton.Text = "연결하기";
            this.MqttConnectButton.UseVisualStyleBackColor = true;
            this.MqttConnectButton.Click += new System.EventHandler(this.mqttConnectButton_Click);
            // 
            // MqttDisConnectbutton
            // 
            this.MqttDisConnectbutton.Location = new System.Drawing.Point(600, 16);
            this.MqttDisConnectbutton.Name = "MqttDisConnectbutton";
            this.MqttDisConnectbutton.Size = new System.Drawing.Size(188, 103);
            this.MqttDisConnectbutton.TabIndex = 6;
            this.MqttDisConnectbutton.Text = "연결종료";
            this.MqttDisConnectbutton.UseVisualStyleBackColor = true;
            this.MqttDisConnectbutton.Click += new System.EventHandler(this.mqttDisConnectbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "아이디";
            // 
            // MqttIdTextbox
            // 
            this.MqttIdTextbox.Location = new System.Drawing.Point(115, 53);
            this.MqttIdTextbox.Name = "MqttIdTextbox";
            this.MqttIdTextbox.Size = new System.Drawing.Size(259, 25);
            this.MqttIdTextbox.TabIndex = 8;
            // 
            // mqttPasswordLabel
            // 
            this.mqttPasswordLabel.AutoSize = true;
            this.mqttPasswordLabel.Location = new System.Drawing.Point(21, 94);
            this.mqttPasswordLabel.Name = "mqttPasswordLabel";
            this.mqttPasswordLabel.Size = new System.Drawing.Size(67, 15);
            this.mqttPasswordLabel.TabIndex = 9;
            this.mqttPasswordLabel.Text = "패스워드";
            // 
            // MqttPasswordTextbox
            // 
            this.MqttPasswordTextbox.Location = new System.Drawing.Point(115, 94);
            this.MqttPasswordTextbox.Name = "MqttPasswordTextbox";
            this.MqttPasswordTextbox.PasswordChar = '*';
            this.MqttPasswordTextbox.Size = new System.Drawing.Size(259, 25);
            this.MqttPasswordTextbox.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 224);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 214);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // MqttSubscribButton
            // 
            this.MqttSubscribButton.Location = new System.Drawing.Point(403, 136);
            this.MqttSubscribButton.Name = "MqttSubscribButton";
            this.MqttSubscribButton.Size = new System.Drawing.Size(385, 71);
            this.MqttSubscribButton.TabIndex = 12;
            this.MqttSubscribButton.Text = "구독하기";
            this.MqttSubscribButton.UseVisualStyleBackColor = true;
            this.MqttSubscribButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mqttSubscribeStrTextBox
            // 
            this.mqttSubscribeStrTextBox.Location = new System.Drawing.Point(115, 161);
            this.mqttSubscribeStrTextBox.Name = "mqttSubscribeStrTextBox";
            this.mqttSubscribeStrTextBox.Size = new System.Drawing.Size(259, 25);
            this.mqttSubscribeStrTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "구독 문자열";
            // 
            // ClearTextButton
            // 
            this.ClearTextButton.Location = new System.Drawing.Point(713, 453);
            this.ClearTextButton.Name = "ClearTextButton";
            this.ClearTextButton.Size = new System.Drawing.Size(75, 23);
            this.ClearTextButton.TabIndex = 15;
            this.ClearTextButton.Text = "지우기";
            this.ClearTextButton.UseVisualStyleBackColor = true;
            this.ClearTextButton.Click += new System.EventHandler(this.ClearTextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.ClearTextButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mqttSubscribeStrTextBox);
            this.Controls.Add(this.MqttSubscribButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MqttPasswordTextbox);
            this.Controls.Add(this.mqttPasswordLabel);
            this.Controls.Add(this.MqttIdTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MqttDisConnectbutton);
            this.Controls.Add(this.MqttConnectButton);
            this.Controls.Add(this.mqttAddressLabel);
            this.Controls.Add(this.MqttAddressTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MqttAddressTextbox;
        private System.Windows.Forms.Label mqttAddressLabel;
        private System.Windows.Forms.Button MqttConnectButton;
        private System.Windows.Forms.Button MqttDisConnectbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MqttIdTextbox;
        private System.Windows.Forms.Label mqttPasswordLabel;
        private System.Windows.Forms.TextBox MqttPasswordTextbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button MqttSubscribButton;
        private System.Windows.Forms.TextBox mqttSubscribeStrTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearTextButton;
    }
}

