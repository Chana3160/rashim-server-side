using System;
using System.Collections.Generic;

namespace test_rashim.Models;

public partial class Store
{
    public string StorId { get; set; } = null!;

    public string? StorName { get; set; }

    public string? StorAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public virtual ICollection<Sale> Sales { get; } = new List<Sale>();
}
