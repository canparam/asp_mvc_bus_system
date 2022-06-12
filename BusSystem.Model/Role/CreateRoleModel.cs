using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusSystem.Model.Role
{
    public class CreateRoleModel : BaseModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}
