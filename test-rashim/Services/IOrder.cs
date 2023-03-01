using test_rashim.Models;
using test_rashim.Models.Shared;

namespace test_rashim.Services
{
    public interface IOrder
    {
        Task<List<Order>> CreateTask(TitleShared[] order);
    }
}
