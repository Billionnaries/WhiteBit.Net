using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using WhiteBit.Net.Enums;

namespace WhiteBit.Net.Objects.Models
{
    /// <summary>
    /// Position info
    /// </summary>
    public record WhiteBitPosition
    {
        /// <summary>
        /// Position id
        /// </summary>
        [JsonPropertyName("positionId")]
        public long PositionId { get; set; }
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("market")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Open timestamp
        /// </summary>
        [JsonPropertyName("openDate")]
        public DateTime OpenTime { get; set; }
        /// <summary>
        /// Update timestamp
        /// </summary>
        [JsonPropertyName("modifyDate")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Base price
        /// </summary>
        [JsonPropertyName("basePrice")]
        public decimal? BasePrice { get; set; }
        /// <summary>
        /// Liquidation price
        /// </summary>
        [JsonPropertyName("liquidationPrice")]
        public decimal? LiquidationPrice { get; set; }
        /// <summary>
        /// Liquidation status
        /// </summary>
        [JsonPropertyName("liquidationState")]
        public LiquidationStatus? LiquidationStatus { get; set; }
        /// <summary>
        /// Profit and loss
        /// </summary>
        [JsonPropertyName("pnl")]
        public decimal? Pnl { get; set; }
        /// <summary>
        /// Profit and loss percentage
        /// </summary>
        [JsonPropertyName("pnlPercent")]
        public decimal? PnlPercent { get; set; }
        /// <summary>
        /// Amount of funds in open position
        /// </summary>
        [JsonPropertyName("margin")]
        public decimal Margin { get; set; }
        /// <summary>
        /// Free funds
        /// </summary>
        [JsonPropertyName("freeMargin")]
        public decimal FreeMargin { get; set; }
        /// <summary>
        /// Funding
        /// </summary>
        [JsonPropertyName("funding")]
        public decimal Funding { get; set; }
        /// <summary>
        /// Unrealized funding
        /// </summary>
        [JsonPropertyName("unrealizedFunding")]
        public decimal UnrealizedFunding { get; set; }
    }


}
