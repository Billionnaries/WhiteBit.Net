using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WhiteBit.Net.Objects.Models
{
    public class KlineResponse
    {
        [JsonPropertyName("error")]
        public object? Error { get; set; } 

        [JsonPropertyName("result")]
        public List<List<object>> Result { get; set; } = new(); 

        [JsonPropertyName("id")]
        public int Id { get; set; } 
    }

    public class Kline
    {
        public long Timestamp { get; set; }
        public string Open { get; set; }
        public string Close { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Volume { get; set; }
        public string QuoteVolume { get; set; }
        public string Symbol { get; set; }
    }
}
