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


            // Obtem a referência para a coluna "hora_consulta" do DataGridView
            DataGridViewColumn horaConsultaColumn = dataGridViewListarConsulta.Columns["HoraConsulta"];

            // Define o formato desejado para exibir apenas a hora e o minuto
            horaConsultaColumn.DefaultCellStyle.Format = "H:mm";

            // Obtem a referência para a coluna "DataConsulta" do DataGridView
            DataGridViewColumn dataConsultaColumn = dataGridViewListarConsulta.Columns["DataConsulta"];

            // Define o formato desejado para exibir apenas o ano, mês e dia
            dataConsultaColumn.DefaultCellStyle.Format = "yyyy-MM-dd";

            dataGridViewListarConsulta.Refresh();
        }

        private void buttonVoltarListarConsultas_Click(object sender, EventArgs e)
        {
            AgendarConsulta agendarConsulta = new AgendarConsulta();
            agendarConsulta.Show();
            this.Hide();
        }
    }
}
