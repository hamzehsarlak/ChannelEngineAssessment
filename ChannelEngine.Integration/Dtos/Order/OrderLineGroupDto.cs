using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngine.Integration.Dtos.Order
{
    public class OrderLineGroupDto
    {
        public string MerchantProductNo { get; set; }
        public string Gtin { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public static IEnumerable<string> GetProperties()
        {
            return new[] {"Product No", "Gtin", "Quantity", "Description"};
        }
    }
}
