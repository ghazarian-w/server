using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsInventoryManagement.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    [Column(TypeName = "decimal(2, 1)")]
    public decimal? Rating { get; set; }

    public int StockQuantity { get; set; }
    public string? Description { get; set; }
}
