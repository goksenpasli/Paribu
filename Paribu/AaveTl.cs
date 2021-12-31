using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace Paribu
{
    public class AaveTl : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("avg24hr")]
        public double Avg24Hr { get; set; }

        [JsonProperty("change")]
        public double Change { get; set; }

        [JsonProperty("chartData")]
        public List<object> ChartData { get; set; }

        [JsonProperty("high24hr")]
        public double High24Hr { get; set; }

        [JsonProperty("highestBid")]
        public double HighestBid { get; set; }

        [JsonProperty("last")]
        public double Last { get; set; }

        [JsonProperty("low24hr")]
        public double Low24Hr { get; set; }

        [JsonProperty("lowestAsk")]
        public double LowestAsk { get; set; }

        [JsonProperty("percentChange")]
        public double PercentChange { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }
    }
}