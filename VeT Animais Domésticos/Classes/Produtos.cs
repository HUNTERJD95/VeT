using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeT_Animais_Domésticos.Classes
{
    public class Produtos
    {
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEmArmazem { get; set; }
        public decimal PrecoUnitario { get; set; }
        public bool Estado { get; set; }
    }
}
