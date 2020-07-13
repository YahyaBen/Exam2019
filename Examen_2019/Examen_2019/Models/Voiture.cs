using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2019.Models
{
    public class Voiture
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        public int Nbr_portes { get; set; }
        public int Nbr_places { get; set; }
        public string Photo_1 { get; set; }
        public string Couleur { get; set; }
        public virtual Marque marque { get; set; }
        [ForeignKey("Marque")]
        public int MarqueId { get; set; }
        public virtual ICollection<Assurance> assurances { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
