using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FolexHome.Model
{
    public class CoinListModel
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string CurrencyShortName { get; set; }
        public string Pair { get; set; }
        public string CoinName { get; set; }
        public decimal BtcRate { get; set; }
        public decimal DynamicRate { get; set; }
        public decimal DayChange { get; set; }
        public decimal Volume { get; set; }
        public bool IsRateDown { get; set; }
        public bool IsSecureCoin { get; set; }
        public bool IsHiddenInTrading { get; set; }
        public decimal PriceSellLimit { get; set; }
        public decimal LowPrice { get; set; }
        public decimal HighPrice { get; set; }
        public decimal UsdBtcRate { get; set; }
        public decimal BtcPrice { get; set; }
        public decimal UsdPrice { get; set; }
        public decimal Change { get; set; }

        public decimal DayChangeP => DayChange / 100;

        public decimal VolumeBtc => Change * BtcRate;


        //{
        //    "currencyId": 1,
        //    "shortName": "BHV",
        //    "currencyShortName": "BHV",
        //    "pair": "BTCBHV",
        //    "coinName": "BHV",
        //    "btcRate": 0.02,
        //    "dynamicRate": 0,
        //    "dayChange": 0,
        //    "volume": 0,
        //    "isRateDown": false,
        //    "isSecureCoin": true,
        //    "isHideInTrading": false,
        //    "priceSellLimit": 0,
        //    "lowPrice": 0.02,
        //    "highPrice": 0.02,
        //    "usdbtcRate": 8787.98,
        //    "btcPrice": 0,
        //    "usdPrice": 175.7596,
        //    "change": 0
        //}
    }
}
