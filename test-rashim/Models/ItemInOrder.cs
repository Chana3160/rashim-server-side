using System;
using System.Collections.Generic;

namespace test_rashim.Models;

public partial class ItemInOrder
{
    public int ItemId { get; set; }

    public int OrderId { get; set; }

    public string TitleId { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual Title Title { get; set; } = null!;
}
