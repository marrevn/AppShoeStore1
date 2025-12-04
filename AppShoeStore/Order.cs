using System;
using System.Collections.Generic;

namespace AppShoeStore;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly DateOrder { get; set; }

    public DateOnly DateDelivery { get; set; }

    public int IdPickupPoint { get; set; }

    public short IdUser { get; set; }

    public int Code { get; set; }

    public int IdStatus { get; set; }

    public virtual PickupPoint IdPickupPointNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<OrdersComposition> OrdersCompositions { get; set; } = new List<OrdersComposition>();
}
