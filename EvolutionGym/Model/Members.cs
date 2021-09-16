using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EvolutionGym.Model
{
    public class Members
    {
        [Key]
        [MaxLength(4)]
        public int MembershipID { get; set; }
        public DateTime MembershipDateBegin { get; set; }
        public DateTime MembershipDateEnd { get; set; }
        public int MembershipCost { get; set; }


        public int UserID { get; set; }
        public int TypeID { get; set; }
        public int ClientID { get; set; }
        public User User { get; set; }
        public Client Client { get; set; }

        public int PaymentMethodID { get; set; }
        public PaymentMethod Payment { get; set; }
        public TypeMembership Type { get; set; }
    }
}
