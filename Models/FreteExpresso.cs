using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFrete.Interfaces;

namespace SistemaFrete.Models
{
    public class FreteExpresso : IFrete
    {
        public double Calcular(double peso, double distancia)
        {
            return peso * distancia * 1.5;
        }
    }
}
