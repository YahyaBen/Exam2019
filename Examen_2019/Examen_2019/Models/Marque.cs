using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2019.Models
{
    public class Marque
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Voiture> voitures { get; set; }
    }
}
