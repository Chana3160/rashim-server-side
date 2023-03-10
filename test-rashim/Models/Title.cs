using System;
using System.Collections.Generic;

namespace test_rashim.Models;

public partial class Title
{
    public string TitleId { get; set; } = null!;

    public string Title1 { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? PubId { get; set; }

    public decimal? Price { get; set; }

    public decimal? Advance { get; set; }

    public int? Royalty { get; set; }

    public int? YtdSales { get; set; }

    public string? Notes { get; set; }

    public DateTime Pubdate { get; set; }

    public virtual ICollection<ItemOrder> ItemOrders { get; } = new List<ItemOrder>();

    public virtual Publisher? Pub { get; set; }

    public virtual ICollection<Sale> Sales { get; } = new List<Sale>();

    public virtual ICollection<Titleauthor> Titleauthors { get; } = new List<Titleauthor>();
}
