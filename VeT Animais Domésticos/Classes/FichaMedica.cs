using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeT_Animais_Domésticos.Classes
{
    public class FichaMedica
    {
        public int Id { get; set; }
        public string NomeAnimal { get; set; }
        public DateTime DataAtoMedico { get; set; }
        public string TipoConsulta { get; set; }
        public string NomeColaborador { get; set; }
        public string Diagnostico { get; set; }
        public string AtoMedico { get; set; }
        public double Peso { get; set; }
        public string Observacoes { get; set; }
        public string PrescricaoMedica { get; set; }
        public DateTime ProximaVisita { get; set; }
    }
}
