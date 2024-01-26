using ADO.NET_EF_CodeFirst_HW1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ADO.NET_EF_CodeFirst_HW1.Contexts;

public class LibsDBContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string strcon = "Data Source=DESKTOP-QOMBEIP;Initial Catalog=LibsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        optionsBuilder.UseSqlServer(strcon);
        base.OnConfiguring(optionsBuilder);
    }


    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<BooksType> BookTypes { get; set; }
    public DbSet<Operation> operations { get; set; }
    public DbSet<Student> Students { get; set; }



}
