using Azure.Core;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using test_rashim.Models;
using test_rashim.Models.Shared;

namespace test_rashim.Services
{
    public class OrderService : IOrder
    {
        private readonly PubsContext _context;
        public OrderService(PubsContext context) { _context = context; }
        public async Task<List<Order>> CreateTask(TitleShared[] titles)
        {
           
            var order = new Order
            {
                Date= DateTime.Now

            };

           await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            var items = new List<ItemOrder>();
            foreach (var title in titles)
            {

                 items.Add(new ItemOrder
                {
                    TitleId = title.TitleId,
                    OrderId = order.OrderId,
                });
            }
           await _context.AddRangeAsync(items);
            await _context.SaveChangesAsync();
            //var title = titles.Select(or => new ItemOrder
            // {
            //     TitleId= or.TitleId,
            //     OrderId = order.OrderId,
            // }
            //).ToArray();

            //titles.Select(async t => {
            //    await _context.ItemOrders.AddAsync(t);
            //    await _context.SaveChangesAsync(); }
            //) ;
            return await _context.Orders.ToListAsync();
        }

    }
}
