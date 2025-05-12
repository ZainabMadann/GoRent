using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ClassLibrary.Model;

public partial class Category
{
    public Category()
    {
        Equipment = new HashSet<Equipment>();
    }

    [Key]
    [Column("Category_ID")]
    public int CategoryId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [InverseProperty("Category")]
    public virtual ICollection<Equipment> Equipment { get; set; }
}
