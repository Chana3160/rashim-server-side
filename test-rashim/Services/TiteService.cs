using Microsoft.EntityFrameworkCore;
using test_rashim.Models;
using test_rashim.Models.Shared;

namespace test_rashim.Services
{
    public class TiteService: ITitle
    {
        private readonly PubsContext _context;
        public TiteService(PubsContext context) { _context = context; }
        public async Task<List<TitleShared>> GetTitles(string id)
        {
            var titles = await _context.Titleauthors.Join(
             _context.Titles,
             post => post.TitleId,
             meta => meta.TitleId,
             (post, meta) => new TitleShared
             {
                 TitleId = post.TitleId,
                 Title1 = meta.Title1,
                 Price= meta.Price,
                 Pubdate= meta.Pubdate,
                 AuthorId = post.AuId
             }
         ).Where(a => a.AuthorId == id).ToListAsync();
            return titles;
        }
    }
}
