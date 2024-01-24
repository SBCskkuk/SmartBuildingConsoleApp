using SmartBuildingConsoleApp.DigitalTwins;
using System;

namespace SmartBuildingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalTwinsManager dtHelper = new DigitalTwinsManager();
            // TODO

            string path = "Models/Chapter4/room.json";
            dtHelper.CreateModel(path);
        }
    }
}
