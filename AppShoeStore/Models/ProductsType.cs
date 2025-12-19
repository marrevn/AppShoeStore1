namespace AppShoeStore.Models;

public partial class ProductsType
{
    public int Id { get; set; }

    public string ProductType { get; set; } = null!;

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}
