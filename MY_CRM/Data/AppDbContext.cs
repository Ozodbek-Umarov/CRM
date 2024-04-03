using Microsoft.EntityFrameworkCore;
using MY_CRM.Data.Entities;
using System.Text.RegularExpressions;

namespace MY_CRM.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
    public DbSet<Groups> Groups { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<PaymentTable> PaymentTables { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}
