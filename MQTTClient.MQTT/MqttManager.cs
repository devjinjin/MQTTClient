using MQTTnet;
using MQTTnet.Client;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MQTTClient.MQTT
{
    public sealed class MqttManager
    {
        private static readonly Lazy<MqttManager> _instance = new Lazy<MqttManager>(() => new MqttManager());
        public static MqttManager Instance { get { return _instance.Value; } }

        private readonly IMqttClient mqttClient;
        private readonly MqttFactory mqttFactory;
        public MqttManager()
        {
            mqttFactory = new MqttFactory();
            mqttClient = mqttFactory.CreateMqttClient();



        }

        public delegate void CallbackResponseEventHandler(string something);
        public event CallbackResponseEventHandler ReceiveResponseCallback;

        public async Task<bool> Clean_Disconnect()
        {

            if (mqttClient != null)
            {
                if (!mqttClient.IsConnected)
                {
                    return false;
                }

                await mqttClient.DisconnectAsync(new MqttClientDisconnectOptionsBuilder().WithReason(MqttClientDisconnectOptionsReason.NormalDisconnection).Build());

                return true;
            }
            return false;
        }


        public async Task<bool> Subscribe(string topic)
        {

            if (mqttClient != null)
            {
                if (!mqttClient.IsConnected)
                {
                    return false;
                }

                mqttClient.ApplicationMessageReceivedAsync += e =>
                {
                    if (ReceiveResponseCallback != null)
                    {
                        var payload = e.ApplicationMessage?.Payload;
                        if (payload != null && payload.Length > 0) {
                            var convertBodyString = Encoding.Default.GetString(payload);

                            ReceiveResponseCallback(convertBodyString);
                        }
                    }
                    return Task.CompletedTask;
                };

                var mqttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                    .WithTopicFilter(
                        f =>
                        {
                            f.WithTopic(topic);
                        })
                    .Build();


                await mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);

                return true;
            }

            return false;
        }
        public async Task<(bool, string)> Connect_Client(string address, string id, string password)
        {

            if (mqttClient != null)
            {

                if (mqttClient.IsConnected)
                {
                    return (false, "이미 연결중입니다");
                }


                var _password = Encoding.UTF8.GetBytes(password);

                var mqttClientOptions = new MqttClientOptionsBuilder().WithTcpServer(address).WithCredentials(id, _password).Build();
                try
                {
                    _ = await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

                    return (true, "연결됨");
                }
                catch (Exception ex)
                {

                    return (false, ex.Message);
                }


            }

            return (false, "재시작요함");
        }

        public bool IsConnected()
        {
            if (mqttClient == null)
            {
                return false;
            }

            if (mqttClient.IsConnected)
            {
                return true;
            }
            
            return false;

        }
    }
}
