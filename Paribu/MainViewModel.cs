using Newtonsoft.Json;
using System.ComponentModel;
using System.Net;
using System.Windows.Input;

namespace Paribu
{

    public class MainViewModel : INotifyPropertyChanged
    {
        static MainViewModel()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //TLS 1.2
            client = new WebClient();
            reply = client.DownloadString(new System.Uri("https://www.paribu.com/ticker"));
        }

        public MainViewModel()
        {
            Veri = FromJson(reply);
            İndir = new RelayCommand(z => Download());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand İndir { get; set; }

        public Data Veri { get; set; }

        public static Data FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Data>(json, Converter.Settings);
        }

        private static readonly WebClient client;

        private static string reply;

        private void Download()
        {
            reply = client.DownloadString(new System.Uri("https://www.paribu.com/ticker"));
            Veri = FromJson(reply);
        }
    }
}