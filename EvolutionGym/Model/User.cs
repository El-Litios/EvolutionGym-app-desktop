using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EvolutionGym.Model
{
    public class User
    {
        [Key]
        [MaxLength(2)]
        public int UserID { get; set; }

        [MaxLength(15)]
        public string UserRut { get; set; }

        [MaxLength(50)]
        public string UserUser { get; set; }

        [MaxLength(30)]
        public string UserPass { get; set; }

        [MaxLength(80)]
        public string UserName { get; set; }

        [MaxLength(80)]
        public string UserFatherLastName { get; set; }

        [MaxLength(80)]
        public string UserMotherLastName { get; set; }

        [NotMapped]
        public string UserFullName { get {
                return UserName + " " + UserFatherLastName + " " + UserMotherLastName;
            } 
        }

        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}
