using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerASP.Models
{
    public class DatosCarro
    {

        private static List<Carro> carro;
        //public IList<Carro> carros = new List<Carro>();

        public List<Carro> Carros
        {
            get
            {
                if (carro == null)
                {
                    carro = new List<Carro>();
                }
                return carro;
            }
        }
    }
}
