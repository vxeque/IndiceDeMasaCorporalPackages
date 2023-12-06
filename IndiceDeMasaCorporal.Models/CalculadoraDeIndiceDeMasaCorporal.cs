using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiceDeMasaCorporal.Models
{
    public class CalculadoraDeIndiceDeMasaCorporal
    {
        public enum EstadoNutricional
        {
            PesoBajo,
            PesoNormal,
            SobrePeso,
            Obesidad,
            ObesidadExtrema
        }
        public static decimal IndiceDeMasaCorporal(
        decimal peso, decimal estatura) => peso / (estatura * estatura);
        public static EstadoNutricional SituacionNutricional(decimal imc)
        {
            if (imc < 18.5M)
            {
                return EstadoNutricional.PesoBajo;
            }
            else if (imc < 25.0M)
            {
                return EstadoNutricional.PesoNormal;
            }
            else if (imc < 30.0M)
            {
                return EstadoNutricional.SobrePeso;
            }
            else if (imc < 40.0M)
            {
                return EstadoNutricional.Obesidad;
            }
            else
            {
                return EstadoNutricional.ObesidadExtrema;
            }
        }
    }
}
