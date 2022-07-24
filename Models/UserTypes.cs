using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallahProject.Models
{
    public class UserTypes
    {
        [Key]
        public int UserTypeId { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]

        public List<UserModel> Users { get; set; }
    }
}
