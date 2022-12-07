using PetApp.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp.Core.Entities
{
    public class Especie
    {
        public int EspecieId { get; set; } 
        public string Nome { get; set; }
        public PorteEnum Porte { get; set; }

    }
}
