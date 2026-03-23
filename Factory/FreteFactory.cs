using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFrete.Interfaces;
using SistemaFrete.Models;

namespace SistemaFrete.Factory
{
    public class FreteFactory
    {
        public static IFrete CriarFrete(string tipo)
        {
            switch (tipo)
            {
                case "Normal":
                    return new FreteNormal();

                case "Expresso":
                    return new FreteExpresso();

                case "Internacional":
                    return new FreteInternacional();

                default:
                    throw new System.Exception("Tipo inválido");
            }
        }
    }
}
