using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2019.Models
{
    public class Assurance
    {
        int Id { get; set; }
        string Agence { get; set; }
        DateTime Date_debut { get; set; }
        DateTime Date_fin { get; set; }
        int Prix { get; set; }
    }
}
