using System.ComponentModel.DataAnnotations;

namespace Backend.Core.DTOs.Auth
{
    public class UpdateRoles
    {
        [Required(ErrorMessage ="userName is required")]
        public string UserName { get; set; }

        public RoleType NewRole { get; set; }


    }

    public enum RoleType
    {
        ADMIN,
        MANAGER,
        USER
    }
}
