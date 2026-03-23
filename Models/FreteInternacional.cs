using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFrete.Interfaces;

namespace SistemaFrete.Models
{
    public class FreteInternacional : IFrete
    {
        public double Calcular(double peso, double distancia)
        {
            return (peso * distancia * 2.5) + 50;
        }
    }
}
