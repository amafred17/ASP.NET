using Microsoft.EntityFrameworkCore;

namespace FarmFix.Models
{
    public class ExpensesFarmFixContext : DbContext
    {
        public DbSet<Expenses> Expense { get; set; }
        public ExpensesFarmFixContext(DbContextOptions<ExpensesFarmFixContext> options) : base(options)
        {
                
        }
    }
}
