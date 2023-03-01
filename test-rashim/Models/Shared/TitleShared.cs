using Microsoft.Extensions.Hosting;

namespace test_rashim.Models.Shared
{
    public class TitleShared
    {
        public string TitleId { get; set; } = null!;
        public string AuthorId { get; set; } = null!;

        public string Title1 { get; set; } = null!;

        public decimal? Price { get; set; }

        public DateTime Pubdate { get; set; }


    }
}
