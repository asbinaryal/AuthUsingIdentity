using NewIdentity.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewIdentity.Models
{
    public class Designation : BaseEntity
    {
        //  public int Id { get; set; }
        [StringLength(200)]
        public string DesignationName { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]

        public virtual Department Department { get; set; }


    }
}
