using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverCoinTrading.ClevercoinTradingApi
{
    public class ClevercoinApi
    {
        private string _apiKey = "";
        private string _secret = "";
        public ClevercoinApi(string apiKey, string secret)
        {
            _apiKey = apiKey;
            _secret = secret;
        }
    }
}
