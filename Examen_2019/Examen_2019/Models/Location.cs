using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2019.Models
{
    public class Location
    {
        int Id { get; set; }
        DateTime Date_Debut { get; set; }
        DateTime Date_fin { get; set; }
        Boolean Retour { get; set; }
        int IPrix_Jour { get; set; }
    }
}
