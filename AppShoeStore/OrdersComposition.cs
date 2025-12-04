using System;
using System.Collections.Generic;

namespace AppShoeStore;

public partial class OrdersComposition
{
    public int Id { get; set; }

    public int IdOrder { get; set; }

    public int IdTovar { get; set; }

    public int Quantity { get; set; }

    public virtual Order IdOrderNavigation { get; set; } = null!;

    public virtual Tovar IdTovarNavigation { get; set; } = null!;
}
