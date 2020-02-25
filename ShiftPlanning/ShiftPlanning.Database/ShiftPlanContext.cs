using Microsoft.EntityFrameworkCore;
using ShiftPlanning.Models;

namespace ShiftPlanning.Database
{
    public class ShiftPlanContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public ShiftPlanContext(DbContextOptions options) : base(options)
        {
        }
    }
}
