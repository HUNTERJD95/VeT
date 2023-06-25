using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeT_Animais_Domésticos.Classes;

namespace VeT_Animais_Domésticos.Forms.Colaboradores
{
    public partial class ModificarColaborador : Form
    {
        private int id;
        public ModificarColaborador(int colaboradorId)
        {
            InitializeComponent();
            id = colaboradorId;
        }


        public string novoNome { get; set; }
        public DateTime novoDataNascimento { get; set; }
        public string novoNIF { get; set; }
        public string novoTipo { get; set; }
        public string novoFuncao { get; set; }
        public string novoTelemovel { get; set; }
        public string novoDisponibilidade { get; set; }
        public string novoEstado { get; set; }
    }
}
