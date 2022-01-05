using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChannelEngine.Console.Abstraction;
using ChannelEngine.Integration.Dtos.Offer;
using ChannelEngine.Integration.Dtos.Order;
using ConsoleTables;
using Microsoft.Extensions.Hosting;
using Console=System.Console;

namespace ChannelEngine.Console
{
    public class ConsoleHostedService : IHostedService
    {
        private readonly IConsoleService _consoleService;
        private readonly IHostApplicationLifetime _hostAppLifetime;

        public ConsoleHostedService(IConsoleService consoleService, IHostApplicationLifetime hostAppLifetime)
        {
            _consoleService = consoleService;
            _hostAppLifetime = hostAppLifetime;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                var topProducts = (await _consoleService.GetTopFiveMerchantProducts()).ToArray();
                PrintProducts(topProducts);
                string productNo;
                while (true)
                {
                    System.Console.WriteLine("Enter a product number to update its stock to 25:");
                    productNo = System.Console.ReadLine();
                    if (topProducts.Any(c => c.MerchantProductNo == productNo)) break;
                    System.Console.WriteLine("Product not exists!");
                }
                await _consoleService.UpdateStock(new UpdateStockRequest()
                {
                    MerchantProductNo = productNo,
                    Stock = 25
                });
                System.Console.WriteLine($"Stock of {productNo} has been updated.");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                _hostAppLifetime.StopApplication();
            }
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
        private static void PrintProducts(OrderLineGroupDto[] topProducts)
        {
            var table = new ConsoleTable(new ConsoleTableOptions()
            {
                Columns = OrderLineGroupDto.GetProperties(),
                EnableCount = true,
                NumberAlignment = Alignment.Left
            });
            foreach (var p in topProducts)
            {
                table.AddRow(p.MerchantProductNo, p.Gtin, p.Quantity, p.Description);
            }

            table.Write();
        }
    }
}
