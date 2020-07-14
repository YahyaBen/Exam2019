using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2019.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string CIN { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        [NotMapped]
        public string NomComplet
        {
            get { return Nom + "-" + Prenom; }
        }
}
}
