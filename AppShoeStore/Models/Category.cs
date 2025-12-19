namespace AppShoeStore.Models;

public partial class Category
{
    public short Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}
