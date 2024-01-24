using Azure.DigitalTwins.Core;
using Azure.Identity;
using System;
using System.IO;
namespace SmartBuildingConsoleApp.DigitalTwins
{
    public class DigitalTwinsManager
    {
        private static readonly string adtInstanceUrl = "<https://SBC.api.krc.digitaltwins.azure.net>";
        private DigitalTwinsClient client;
        public DigitalTwinsManager()
        {
            Connect();
        }
        public void Connect()
        {
            var cred = new DefaultAzureCredential();
            client = new DigitalTwinsClient(new Uri(adtInstanceUrl), cred);
        }

        public void CreateModel(string path)
        {
            using var modelStreamReader = new StreamReader(path);
            string dtdl = modelStreamReader.ReadToEnd();
            string[] dtdls = new string[] { dtdl };
            client.CreateModels(dtdls);
        }

    }
}
