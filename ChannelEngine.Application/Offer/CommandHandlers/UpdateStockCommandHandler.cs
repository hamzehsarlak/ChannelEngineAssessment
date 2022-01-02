using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChannelEngine.Application.Offer.Abstraction;
using ChannelEngine.Core.IMediatR.Abstraction;
using ChannelEngine.Integration.Commands;
using MediatR;

namespace ChannelEngine.Application.Offer.CommandHandlers
{
    public class UpdateStockCommandHandler : IMediatRCommandHandler<UpdateStockCommand, Dictionary<string, List<string>>>
    {
        private readonly IOfferService _offerService;

        public UpdateStockCommandHandler(IOfferService offerService)
        {
            _offerService = offerService;
        }
        public async Task<Dictionary<string, List<string>>> Handle(UpdateStockCommand command, CancellationToken cancellationToken)
        {
            return await _offerService.UpdateStockAsync(command.MerchantProductNo, command.Stock, cancellationToken);
        }
    }
}
