using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiceDeMasaCorporal.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public decimal Peso { get; set; }
        public decimal Estatura { get; set; }
        public Persona(string? nombre, decimal peso, decimal estatura)
        {
            Nombre = nombre;
            Peso = peso;
            Estatura = estatura;
        }
    }
}
