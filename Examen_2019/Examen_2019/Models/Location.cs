using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2019.Models
{
    public class Location
    {
        public int Id { get; set; }
        public DateTime Date_Debut { get; set; }
        public DateTime Date_fin { get; set; }
        public Boolean Retour { get; set; }
        public int Prix_Jour { get; set; }
        public virtual Voiture voiture { get; set; }
        public int voitureId { get; set; }
        public virtual Client client { get; set; }
        public int clientId { get; set; }
    }
}
