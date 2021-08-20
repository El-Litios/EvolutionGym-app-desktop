using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EvolutionGym.Model
{
    public class PaymentMethod
    {
        [Key]
        [MaxLength(1)]
        public int PaymentMethodID { get; set; }

        [MaxLength(20)]
        public string MethodDesc { get; set; }
    }
}
