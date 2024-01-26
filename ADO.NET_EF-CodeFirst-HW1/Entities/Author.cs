namespace ADO.NET_EF_CodeFirst_HW1.Entities; 
public class Author : BaseEntity
{
  
    public string? FirstName { get; set; }   
    public string? LastName { get; set;}

    public ICollection<Book> Books { get; set; }
}
