using E_Commerce.Domain.Common;

namespace E_Commerce.Domain.Entities;

public class CartItem : BaseEntity
{

    public int CartId { get; set; }

    public Cart Cart { get; set; }

    public int ProductId { get; set; }

    public Product Product { get; set; }

    public int Quantity { get; set; }
}