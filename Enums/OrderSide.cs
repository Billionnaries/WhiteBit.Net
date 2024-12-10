using CryptoExchange.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteBit.Net.Enums
{
    /// <summary>
    /// Order side
    /// </summary>
    public enum OrderSide
    {
        /// <summary>
        /// Buy
        /// </summary>
        [Map("buy", "2")]
        Buy,
        /// <summary>
        /// Sell
        /// </summary>
        [Map("sell", "1")]
        Sell
    }
}
