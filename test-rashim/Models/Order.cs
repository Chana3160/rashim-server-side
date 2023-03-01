using System;
using System.Collections.Generic;

namespace test_rashim.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime? Date { get; set; }

    public virtual ICollection<ItemOrder> ItemOrders { get; } = new List<ItemOrder>();
}
