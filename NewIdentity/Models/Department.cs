using NewIdentity.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace NewIdentity.Models
{
    public class Department : BaseEntity
    {
        [StringLength(200)]
        public string Name { get; set; }

        public virtual IEnumerable<Department> Departments { get; set; }

        public virtual ICollection<Designation> Designations { get; set; }


    }
}
