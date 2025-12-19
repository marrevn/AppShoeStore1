namespace AppShoeStore.Models;

public partial class Products
{
    public int Id { get; set; }

    public string? Article { get; set; }

    public int IdGood { get; set; }

    public string Unit { get; set; } = null!;

    public decimal Price { get; set; }

    public int IdSupplier { get; set; }

    public int IdManufacturer { get; set; }

    public short IdCategory { get; set; }

    public int Discount { get; set; }

    public int CountTovars { get; set; }

    public string Descreption { get; set; } = null!;

    public string Picture { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ProductsType ProductsType { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ICollection<OrdersComposition> OrdersCompositions { get; set; } = new List<OrdersComposition>();
}
