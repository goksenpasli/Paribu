using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Threading;

namespace Paribu
{
    public class MainViewModel : INotifyPropertyChanged
    {
        static MainViewModel()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            client = new WebClient();
            reply = client.DownloadString(new Uri("https://www.paribu.com/ticker"));
        }

        public MainViewModel()
        {
            Veri = FromJson(reply);
            DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Normal) { Interval = TimeSpan.FromSeconds(10) };
            timer.Tick += (s, e) =>
            {
                reply = client.DownloadString(new Uri("https://www.paribu.com/ticker"));
                Veri = FromJson(reply);
            };
            timer.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Data Veri { get; set; }

        private static readonly WebClient client;

        private static string reply;

        private static Data FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Data>(json, Converter.Settings);
        }
    }
}