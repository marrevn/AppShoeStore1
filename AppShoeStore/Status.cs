using System;
using System.Collections.Generic;

namespace AppShoeStore;

public partial class Status
{
    public short Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
