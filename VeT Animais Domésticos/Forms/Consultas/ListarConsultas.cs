using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeT_Animais_Domésticos.Classes;

namespace VeT_Animais_Domésticos.Forms.Consultas
{
    public partial class ListarConsultas : Form
    {
        public ListarConsultas()
        {
            InitializeComponent();
        }

        private void ListarConsultas_Load(object sender, EventArgs e)
        {
            List<Consulta> consultas = Consulta.ListarConsultasDeHoje();

            dataGridViewListarConsulta.DataSource = consultas;


            // Obtenha a referência para a coluna "hora_consulta" do DataGridView
            DataGridViewColumn horaConsultaColumn = dataGridViewListarConsulta.Columns["HoraConsulta"];

            // Defina o formato desejado para exibir apenas a hora e o minuto
            horaConsultaColumn.DefaultCellStyle.Format = "H:mm";

            // Obtenha a referência para a coluna "DataConsulta" do DataGridView
            DataGridViewColumn dataConsultaColumn = dataGridViewListarConsulta.Columns["DataConsulta"];

            // Defina o formato desejado para exibir apenas o ano, mês e dia
            dataConsultaColumn.DefaultCellStyle.Format = "yyyy-MM-dd";

            dataGridViewListarConsulta.Refresh();
        }
    }
}
