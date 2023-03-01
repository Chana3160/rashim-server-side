using test_rashim.Models.Shared;

namespace test_rashim.Services
{
    public interface IAuthor
    {
        Task<List<AuthorShared>> GetAuthors();
        Task<AuthorShared?> GetAuthorById(string id);
        

        int GetAuthorTitles(string id);

    }
}
