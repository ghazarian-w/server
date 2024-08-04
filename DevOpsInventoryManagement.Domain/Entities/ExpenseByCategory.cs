using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsInventoryManagement.Domain.Entities;

public class ExpenseByCategory
{
    public int Id { get; set; }
    public int ExpenseSummaryId { get; set; }
    public DateTime Date { get; set; }

    [Column(TypeName = "bigint")]
    public int Category { get; set; }

    [Column(TypeName = "bigint")]
    public int Amount { get; set; }
}
