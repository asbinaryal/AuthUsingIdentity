using System.ComponentModel.DataAnnotations;

namespace NewIdentity.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
