using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealerASP.Models
{
    public class Carro
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public String Nombre{ get; set; }

        [Required]
        [MaxLength(60)]
        public String Color { get; set; }

        [Required]
        [MaxLength(60)]
        public String Marca { get; set; }

        [Required]
        [MaxLength(20)]
        public String Chasis { get; set; }

    }
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
