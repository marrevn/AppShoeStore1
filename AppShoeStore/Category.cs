using System;
using System.Collections.Generic;

namespace AppShoeStore;

public partial class Category
{
    public short Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Tovar> Tovars { get; set; } = new List<Tovar>();
}
