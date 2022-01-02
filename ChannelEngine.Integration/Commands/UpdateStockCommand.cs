using System;
using System.Collections.Generic;
using System.Text;
using ChannelEngine.Core.IMediatR;
using ChannelEngine.Core.IMediatR.Abstraction;
using ChannelEngine.Integration.Dtos.Offer;
using MediatR;

namespace ChannelEngine.Integration.Commands
{
    public class UpdateStockCommand : MediatRCommandBase<Dictionary<string, List<string>>>, IMediatRCommand
    {
        public string MerchantProductNo { get; set; }
        public int Stock { get; set; }

        public UpdateStockCommand(UpdateStockRequest updateStockRequest)
        {
            MerchantProductNo = updateStockRequest.MerchantProductNo;
            Stock = updateStockRequest.Stock;
        }
    }
}
