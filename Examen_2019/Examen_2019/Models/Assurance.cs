using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2019.Models
{
    public class Assurance
    {
        public int Id { get; set; }
        public string Agence { get; set; }
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }
        public int Prix { get; set; }
        public virtual Voiture voiture { get; set; }
        public int VoitureId { get; set; }
    }
}
