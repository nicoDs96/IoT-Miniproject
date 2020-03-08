using System;
using System.IO;
using Xamarin.Forms;
using Note;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public partial class MainPage : ContentPage {
        private static DeviceClient s_deviceClient;

        // The device connection string to authenticate the device with your IoT hub.
        // Using the Azure CLI:
        // az iot hub device-identity show-connection-string --hub-name {YourIoTHubName} --device-id MyDotnetDevice --output table
        private readonly static string s_connectionString = "HostName=iot-miniproject.azure-devices.net;DeviceId=MyAndroidDevice;SharedAccessKey=eF3DWgxqqsjIVkJl36pab1ep+mJM5EfWoYvG/jtKS6U=";


        public MainPage() {
            InitializeComponent();
            // Connect to the IoT hub using the MQTT protocol
            s_deviceClient = DeviceClient.CreateFromConnectionString(s_connectionString, TransportType.Mqtt);

        }
        async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs args) { 
            bool confirm = await DisplayAlert("Data to send", "Do you want to send: "+ us_input.Text, "Yes", "No");

           

            // Create JSON message
            var telemetryDataPoint = new
            {
                user_text = us_input.Text 
            };
            var messageString = JsonConvert.SerializeObject(telemetryDataPoint);
            var message = new Message(Encoding.ASCII.GetBytes(messageString));

            // Add a custom application property to the message.
            // An IoT hub can filter on these properties without access to the message body.
            //message.Properties.Add("temperatureAlert", (currentTemperature > 30) ? "true" : "false");

            // Send the telemetry message
            await s_deviceClient.SendEventAsync(message);
            Console.WriteLine("{0} > Sending message: {1}", DateTime.Now, messageString);

            Console.WriteLine("IoT Hub Quickstarts #1 - Simulated device. Ctrl-C to exit.\n");
            
        }

    }
}



