using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EvolutionGym.Model
{
    public class TypeMembership
    {
        [Key]
        [MaxLength(1)]
        public int TypeID { get; set; }

        [MaxLength(20)]
        public string TypeDesc { get; set; }
    }
}
