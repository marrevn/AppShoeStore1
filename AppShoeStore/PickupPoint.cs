using System;
using System.Collections.Generic;

namespace AppShoeStore;

public partial class PickupPoint
{
    public int Id { get; set; }

    public int IndexPoints { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int NumberHouse { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
