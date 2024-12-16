using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WhiteBit.Net.Objects.Models
{
    public class MarketPairInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stock")]
        public string Stock { get; set; }

        [JsonPropertyName("money")]
        public string Money { get; set; }

        [JsonPropertyName("stockPrec")]
        public string StockPrec { get; set; }

        [JsonPropertyName("moneyPrec")]
        public string MoneyPrec { get; set; }

        [JsonPropertyName("feePrec")]
        public string FeePrec { get; set; }

        [JsonPropertyName("makerFee")]
        public string MakerFee { get; set; }

        [JsonPropertyName("takerFee")]
        public string TakerFee { get; set; }

        [JsonPropertyName("minAmount")]
        public string MinAmount { get; set; }

        [JsonPropertyName("minTotal")]
        public string MinTotal { get; set; }

        [JsonPropertyName("tradesEnabled")]
        public bool TradesEnabled { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("isCollateral")]
        public bool IsCollateral { get; set; }

        [JsonPropertyName("maxTotal")]
        public string MaxTotal { get; set; }
    }
}
