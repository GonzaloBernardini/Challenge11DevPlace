using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConcesionarioChallenge11.Models
{
    public class Unidades
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string ImagenAuto { get; set; }
        public DateTime Año { get; set; }
        public int Kilometros { get; set; }
        public int Precio { get; set; }
    }
}
