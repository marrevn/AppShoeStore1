using System;
using System.Collections.Generic;

namespace AppShoeStore.Models;

public partial class Tovar
{
    public string Article { get; set; } = null!;

    public int IdTovar { get; set; }

    public string Unit { get; set; } = null!;

    public decimal Price { get; set; }

    public int IdSupplier { get; set; }

    public int IdManufacturer { get; set; }

    public short IdCategory { get; set; }

    public int Discount { get; set; }

    public int CountTovars { get; set; }

    public string Descreption { get; set; } = null!;

    public string Picture { get; set; } = null!;

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual Good IdTovarNavigation { get; set; } = null!;
}
