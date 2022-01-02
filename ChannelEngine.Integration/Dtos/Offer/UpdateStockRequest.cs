using System;
using System.Collections.Generic;
using System.Text;
using ChannelEngine.Core.Abstraction.CQRS;

namespace ChannelEngine.Integration.Dtos.Offer
{
    public class UpdateStockRequest : CommandBase
    {
        public string MerchantProductNo { get; set; }
        public int Stock { get; set; }

        public UpdateStockRequest(Guid id) : base(id)
        {
        }

        public UpdateStockRequest() : base(Guid.NewGuid())
        {
            
        }
    }
}
