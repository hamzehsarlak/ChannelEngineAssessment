using System;

namespace ChannelEngine.Application
{
    public class ChannelEngineRestOptions
    {
        public string BaseUrl { get; set; }
        public  string OrderPathGet { get; set; }
        public string ProductPathGet { get; set; }
        public string SetStockPath { get; set; }
        public string ApiKey { get; set; }

        public Tuple<string, string> GetApiKeyQueryString()
        {
            return new Tuple<string, string>("apiKey", ApiKey);
        }
    }
}
