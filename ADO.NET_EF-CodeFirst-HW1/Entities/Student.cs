using ADO.NET_EF_CodeFirst_HW1.Enums;

namespace ADO.NET_EF_CodeFirst_HW1.Entities; 
public class Student:BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int SchoolNumber { get; set; }
    public Gender Gender { get; set; }
    public DateTime? BirthDay { get; set; }
    public int PhoneNumber { get; set; }
    public Operation Operation { get; set; }

    public ICollection<Book> Books { get; set; }
}
