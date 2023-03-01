using test_rashim.Models.Shared;

namespace test_rashim.Services
{
    public interface ITitle
    {
        Task<List<TitleShared>> GetTitles(string id);
    }
}
