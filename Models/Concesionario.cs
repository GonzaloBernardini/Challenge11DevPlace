using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConcesionarioChallenge11.Models
{
    public class Concesionario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Logo { get; set; }
        
        public string Descripcion { get; set; }

        public string Email { get; set; }

        public int Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
