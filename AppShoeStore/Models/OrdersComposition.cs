namespace AppShoeStore.Models;

public partial class OrdersComposition
{
    public int Id { get; set; }

    public int IdOrder { get; set; }

    public int IdTovar { get; set; }

    public int Quantity { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Tovar Tovar { get; set; } = null!;
}
