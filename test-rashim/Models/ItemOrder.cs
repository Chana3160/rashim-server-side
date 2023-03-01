using System;
using System.Collections.Generic;

namespace test_rashim.Models;

public partial class ItemOrder
{
    public int ItemId { get; set; }

    public int? OrderId { get; set; }

    public string? TitleId { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Title? Title { get; set; }
}
