using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsInventoryManagement.Domain.Entities;

public class PurchaseSummary
{
    public int Id { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal TotalPurchased { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal ChangePercentage { get; set; }
    public DateTime Date { get; set; }
}
