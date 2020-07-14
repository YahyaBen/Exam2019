using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2019.Models
{
    public class Location
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date_Debut { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date_fin { get; set; }
        public Boolean Retour { get; set; }
        [Range(0,1000,ErrorMessage ="Vous avez depassez les limites")]
        public int Prix_Jour { get; set; }
        public virtual Voiture voiture { get; set; }
        [ForeignKey("Voiture")]
        public int VoitureId { get; set; }
        public virtual Client client { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
    }
}
