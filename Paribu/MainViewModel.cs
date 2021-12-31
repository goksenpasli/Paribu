using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace Paribu
{
    public static class Serialize
    {
        public static string ToJson(this MainViewModel self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }

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

    public class Data : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("AAVE_TL")]
        public AaveTl AaveTl { get; set; }

        [JsonProperty("ACM_TL")]
        public AaveTl AcmTl { get; set; }

        [JsonProperty("ADA_TL")]
        public AaveTl AdaTl { get; set; }

        [JsonProperty("ADA_USDT")]
        public AaveTl AdaUsdt { get; set; }

        [JsonProperty("AFC_TL")]
        public AaveTl AfcTl { get; set; }

        [JsonProperty("ALGO_TL")]
        public AaveTl AlgoTl { get; set; }

        [JsonProperty("ALICE_TL")]
        public AaveTl AliceTl { get; set; }

        [JsonProperty("ANKR_TL")]
        public AaveTl AnkrTl { get; set; }

        [JsonProperty("ASR_TL")]
        public AaveTl AsrTl { get; set; }

        [JsonProperty("ATM_TL")]
        public AaveTl AtmTl { get; set; }

        [JsonProperty("ATOM_TL")]
        public AaveTl AtomTl { get; set; }

        [JsonProperty("AUDIO_TL")]
        public AaveTl AudioTl { get; set; }

        [JsonProperty("AVAX_TL")]
        public AaveTl AvaxTl { get; set; }

        [JsonProperty("AVAX_USDT")]
        public AaveTl AvaxUsdt { get; set; }

        [JsonProperty("AXS_TL")]
        public AaveTl AxsTl { get; set; }

        [JsonProperty("BAL_TL")]
        public AaveTl BalTl { get; set; }

        [JsonProperty("BAND_TL")]
        public AaveTl BandTl { get; set; }

        [JsonProperty("BAR_TL")]
        public AaveTl BarTl { get; set; }

        [JsonProperty("BAT_TL")]
        public AaveTl BatTl { get; set; }

        [JsonProperty("BCH_TL")]
        public AaveTl BchTl { get; set; }

        [JsonProperty("BTC_TL")]
        public BtcTl BtcTl { get; set; }

        [JsonProperty("BTC_USDT")]
        public AaveTl BtcUsdt { get; set; }

        [JsonProperty("BTT_TL")]
        public AaveTl BttTl { get; set; }

        [JsonProperty("CEEK_TL")]
        public AaveTl CeekTl { get; set; }

        [JsonProperty("CHZ_TL")]
        public AaveTl ChzTl { get; set; }

        [JsonProperty("CITY_TL")]
        public AaveTl CityTl { get; set; }

        [JsonProperty("CLV_TL")]
        public AaveTl ClvTl { get; set; }

        [JsonProperty("CRV_TL")]
        public AaveTl CrvTl { get; set; }

        [JsonProperty("DOGE_TL")]
        public AaveTl DogeTl { get; set; }

        [JsonProperty("DOT_TL")]
        public AaveTl DotTl { get; set; }

        [JsonProperty("ENJ_TL")]
        public AaveTl EnjTl { get; set; }

        [JsonProperty("ENS_TL")]
        public AaveTl EnsTl { get; set; }

        [JsonProperty("EOS_TL")]
        public AaveTl EosTl { get; set; }

        [JsonProperty("ETH_TL")]
        public AaveTl EthTl { get; set; }

        [JsonProperty("ETH_USDT")]
        public AaveTl EthUsdt { get; set; }

        [JsonProperty("FB_TL")]
        public AaveTl FbTl { get; set; }

        [JsonProperty("FTM_TL")]
        public AaveTl FtmTl { get; set; }

        [JsonProperty("GALA_TL")]
        public AaveTl GalaTl { get; set; }

        [JsonProperty("GAL_CHZ")]
        public AaveTl GalChz { get; set; }

        [JsonProperty("GAL_TL")]
        public AaveTl GalTl { get; set; }

        [JsonProperty("GOZ_TL")]
        public AaveTl GozTl { get; set; }

        [JsonProperty("GRT_TL")]
        public AaveTl GrtTl { get; set; }

        [JsonProperty("HOT_TL")]
        public AaveTl HotTl { get; set; }

        [JsonProperty("ICP_TL")]
        public AaveTl IcpTl { get; set; }

        [JsonProperty("INJ_TL")]
        public AaveTl InjTl { get; set; }

        [JsonProperty("INTER_TL")]
        public AaveTl InterTl { get; set; }

        [JsonProperty("JUV_TL")]
        public AaveTl JuvTl { get; set; }

        [JsonProperty("KEEP_TL")]
        public AaveTl KeepTl { get; set; }

        [JsonProperty("LINK_TL")]
        public AaveTl LinkTl { get; set; }

        [JsonProperty("LINK_USDT")]
        public AaveTl LinkUsdt { get; set; }

        [JsonProperty("LPT_TL")]
        public AaveTl LptTl { get; set; }

        [JsonProperty("LRC_TL")]
        public AaveTl LrcTl { get; set; }

        [JsonProperty("LTC_TL")]
        public AaveTl LtcTl { get; set; }

        [JsonProperty("MANA_TL")]
        public AaveTl ManaTl { get; set; }

        [JsonProperty("MATIC_TL")]
        public AaveTl MaticTl { get; set; }

        [JsonProperty("MINA_TL")]
        public AaveTl MinaTl { get; set; }

        [JsonProperty("MIOTA_TL")]
        public AaveTl MiotaTl { get; set; }

        [JsonProperty("MKR_TL")]
        public AaveTl MkrTl { get; set; }

        [JsonProperty("MKR_USDT")]
        public AaveTl MkrUsdt { get; set; }

        [JsonProperty("NEO_TL")]
        public AaveTl NeoTl { get; set; }

        [JsonProperty("OGN_TL")]
        public AaveTl OgnTl { get; set; }

        [JsonProperty("OMG_TL")]
        public AaveTl OmgTl { get; set; }

        [JsonProperty("ONT_TL")]
        public AaveTl OntTl { get; set; }

        [JsonProperty("OXT_TL")]
        public AaveTl OxtTl { get; set; }

        [JsonProperty("PSG_TL")]
        public AaveTl PsgTl { get; set; }

        [JsonProperty("RACA_TL")]
        public AaveTl RacaTl { get; set; }

        [JsonProperty("REEF_TL")]
        public AaveTl ReefTl { get; set; }

        [JsonProperty("RVN_TL")]
        public AaveTl RvnTl { get; set; }

        [JsonProperty("SAND_TL")]
        public AaveTl SandTl { get; set; }

        [JsonProperty("SHIB_TL")]
        public AaveTl ShibTl { get; set; }

        [JsonProperty("SOL_TL")]
        public AaveTl SolTl { get; set; }

        [JsonProperty("THETA_TL")]
        public AaveTl ThetaTl { get; set; }

        [JsonProperty("TLM_TL")]
        public AaveTl TlmTl { get; set; }

        [JsonProperty("TRA_TL")]
        public AaveTl TraTl { get; set; }

        [JsonProperty("TRX_TL")]
        public AaveTl TrxTl { get; set; }

        [JsonProperty("TRYC_TL")]
        public AaveTl TrycTl { get; set; }

        [JsonProperty("TVK_TL")]
        public AaveTl TvkTl { get; set; }

        [JsonProperty("UNI_TL")]
        public AaveTl UniTl { get; set; }

        [JsonProperty("USDT_TL")]
        public AaveTl UsdtTl { get; set; }

        [JsonProperty("VCF_TL")]
        public AaveTl VcfTl { get; set; }

        [JsonProperty("VET_TL")]
        public AaveTl VetTl { get; set; }

        [JsonProperty("WAVES_TL")]
        public AaveTl WavesTl { get; set; }

        [JsonProperty("WAVES_USDT")]
        public AaveTl WavesUsdt { get; set; }

        [JsonProperty("XLM_TL")]
        public AaveTl XlmTl { get; set; }

        [JsonProperty("XLM_USDT")]
        public AaveTl XlmUsdt { get; set; }

        [JsonProperty("XRP_TL")]
        public AaveTl XrpTl { get; set; }

        [JsonProperty("XRP_USDT")]
        public AaveTl XrpUsdt { get; set; }

        [JsonProperty("XTZ_TL")]
        public AaveTl XtzTl { get; set; }

        [JsonProperty("ZIL_TL")]
        public AaveTl ZilTl { get; set; }
    }

    public class MainViewModel : INotifyPropertyChanged
    {
        static MainViewModel()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //TLS 1.2
            WebClient client = new WebClient();
            reply = client.DownloadString(new System.Uri("https://www.paribu.com/ticker"));
        }

        public MainViewModel()
        {
            MyProperty = FromJson(reply);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Data MyProperty { get; set; }

        public static Data FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Data>(json, Converter.Settings);
        }

        private static readonly string reply;
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}