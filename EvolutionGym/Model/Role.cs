using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EvolutionGym.Model
{
    public class Role
    {
        [Key]
        [MaxLength(1)]
        public int RoleID { get; set; }
        [MaxLength(30)]
        public string RoleDesc { get; set; }
    }
}
