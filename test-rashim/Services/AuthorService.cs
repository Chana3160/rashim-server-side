using System;
using test_rashim.Models.Shared;
using test_rashim.Models;
using Microsoft.Extensions.Hosting;


namespace test_rashim.Services
{
    public class AuthorService : IAuthor
    {
        private readonly PubsContext _context;
        public AuthorService(PubsContext context) { _context = context; }
        public async Task<List<AuthorShared>> GetAuthors()
        {
            var authors=await _context.Authors.ToListAsync();
            var result = authors.Select(a => new AuthorShared
            {
                AuId = a.AuId,
                AuFname= a.AuFname,
                AuLname= a.AuLname,
                Address= a.Address,
                City= a.City,
                State= a.State,
                Phone= a.Phone,
                Zip = a.Zip,
                Contract= a.Contract,
                NumOfBooks = GetAuthorTitles(a.AuId)
            }
            ).ToList() ;
            
            return result;
        }

        public async Task<AuthorShared?> GetAuthorById(string id)
        {
            var result = await _context.Authors.FindAsync(id);
            if (result == null)
            {
                return null;
            }
            var author = new AuthorShared
            {
                AuId = result.AuId,
                AuFname = result.AuFname,
                AuLname = result.AuLname,
                Address = result.Address,
                City = result.City,
                State = result.State,
                Phone = result.Phone,
                Zip = result.Zip,
                Contract = result.Contract,
                NumOfBooks = GetAuthorTitles(result.AuId)
            };
          
            return author;
        }


       

        public int GetAuthorTitles(string id)
        {
            //var result = _context.Titleauthors.Where(a => a.AuId == id).Select(b => b.AuOrd);
            var result =  _context.Titleauthors.Where(a=> a.AuId==id).Count();
            return result;
        }
    }
}
