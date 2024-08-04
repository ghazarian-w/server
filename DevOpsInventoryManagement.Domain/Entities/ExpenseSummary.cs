using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsInventoryManagement.Domain.Entities;

public class ExpenseSummary
{
    public int Id { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal TotalExpenses { get; set; }
    public DateTime Date { get; set; }
}
