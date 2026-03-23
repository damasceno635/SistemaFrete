using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFrete.Interfaces
{
    public interface IFrete
    {
        double Calcular(double peso, double distancia);
    }
}
