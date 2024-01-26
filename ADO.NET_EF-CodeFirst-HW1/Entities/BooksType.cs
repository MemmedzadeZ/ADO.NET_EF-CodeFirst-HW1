using System.ComponentModel.DataAnnotations;

namespace ADO.NET_EF_CodeFirst_HW1.Entities;

public class BooksType:BaseEntity
{

    public string? Name { get; set; }   
    public ICollection<Book> Books { get; set;}
}
