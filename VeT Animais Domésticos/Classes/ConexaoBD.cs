using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeT_Animais_Domésticos.Classes
{
    public static class ConexaoBD
    {
        public static string conexao { get; private set; } = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\cs_ba\\source\\repos\\testeIP\\VeT Animais Domésticos\\VeT Animais Domésticos\\BaseDados\\BaseDados.mdf\";Integrated Security=True";
        
    }
}
