namespace ADO.NET_EF_CodeFirst_HW1.Entities; 
public class Book :BaseEntity
{
   public string? Name { get; set; }
    public int PageCount { get; set; }  
    public Operation Operation { get; set; }    
    public Author Author { get; set; }  
    public BooksType BookType { get; set; }
    public ICollection<Student> Students { get; set; }

}
