using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Input;
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
            İndir = new RelayCommand(_ => Download());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand İndir { get; set; }

        public Data Veri { get; set; }

        private static readonly WebClient client;

        private static string reply;

        private static Data FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Data>(json, Converter.Settings);
        }

        private void Download()
        {
            DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.SystemIdle) { Interval = TimeSpan.FromSeconds(15) };
            timer.Start();
            timer.Tick += (s, e) =>
            {
                reply = client.DownloadString(new Uri("https://www.paribu.com/ticker"));
                Veri = FromJson(reply);
            };
        }
    }
}