using System;
using System.Collections.Generic;

namespace test_rashim.Models;

public partial class Job
{
    public short JobId { get; set; }

    public string JobDesc { get; set; } = null!;

    public byte MinLvl { get; set; }

    public byte MaxLvl { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
