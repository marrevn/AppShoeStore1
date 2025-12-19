namespace AppShoeStore.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string SupplierName { get; set; } = null!;

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}
