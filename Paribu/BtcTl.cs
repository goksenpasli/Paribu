using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace Paribu
{
    public class BtcTl : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("avg24hr")]
        public double Avg24Hr { get; set; }

        [JsonProperty("change")]
        public long Change { get; set; }

        [JsonProperty("chartData")]
        public List<object> ChartData { get; set; }

        [JsonProperty("high24hr")]
        public double High24Hr { get; set; }

        [JsonProperty("highestBid")]
        public long HighestBid { get; set; }

        [JsonProperty("last")]
        public long Last { get; set; }

        [JsonProperty("low24hr")]
        public long Low24Hr { get; set; }

        [JsonProperty("lowestAsk")]
        public long LowestAsk { get; set; }

        [JsonProperty("percentChange")]
        public double PercentChange { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }
    }
}