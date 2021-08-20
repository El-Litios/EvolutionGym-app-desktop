using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EvolutionGym.Model
{
    public class Client
    {
        [Key]
        [MaxLength(4)]
        public int ClientID { get; set; }

        [MaxLength(15)]
        public string ClientRut { get; set; }

        [MaxLength(80)]
        public string ClientName { get; set; }

        [MaxLength(80)]
        public string  ClientFatherLastName { get; set; }

        [MaxLength(80)]
        public string ClientMotherLastName { get; set; }

        [MaxLength(100)]
        public string ClientEmail { get; set; }

        [MaxLength(12)]
        public string ClientPhone { get; set; }

        [NotMapped]
        public string ClientFullName { get { return ClientName + " " + ClientFatherLastName + " " + ClientMotherLastName; } }

    }
}
