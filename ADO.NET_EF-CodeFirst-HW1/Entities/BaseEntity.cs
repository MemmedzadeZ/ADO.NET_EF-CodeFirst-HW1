using System.Security.Cryptography.X509Certificates;

namespace ADO.NET_EF_CodeFirst_HW1.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public string? Status { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    public BaseEntity()
    {
        CreatedDate = DateTime.Now;

    }
}
