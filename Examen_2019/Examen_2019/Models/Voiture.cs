using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2019.Models
{
    public class Voiture
    {
        int Id { get; set; }
        string Matricule { get; set; }
        int Nbr_portes { get; set; }
        int Nbr_places { get; set; }
        string Photo_1 { get; set; }
        string Couleur { get; set; }
        public virtual Marque marque { get; set; }
        public int MarqueId { get; set; }
        public virtual ICollection<Assurance> assurances { get; set; }
        public virtual ICollection<Client> clients { get; set; }
    }
}
