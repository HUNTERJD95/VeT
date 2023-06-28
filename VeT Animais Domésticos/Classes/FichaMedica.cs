using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeT_Animais_Domésticos.Forms.Produtos;


namespace VeT_Animais_Domésticos.Classes
{
    public class FichaMedica
    {
        public int Id { get; set; }
        public DateTime DataAtoMedico { get; set; }
        public string? TipoConsulta { get; set; }
        public string? NomeColaborador { get; set; }
        public string? Diagnostico { get; set; }
        public string? AtoMedico { get; set; }
        public double Peso { get; set; }
        public string? Observacoes { get; set; }
        public string? PrescricaoMedica { get; set; }
        public DateTime ProximaVisita { get; set; }

        public static void CriarFichaMedica(int idAnimal, DateTime dataAtoMedico, string tipoConsulta, int idColaborador,
            double peso, string observacoes, string prescricao, DateTime proximaVisita,
            ListBox.ObjectCollection listaProdutos, ListBox.ObjectCollection listaDiagnosticos,
            ListBox.ObjectCollection listaAtos)
        {
            try
            {
                // Crie a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(ConexaoBD.conexao))
                {
                    connection.Open();

                    // Inicie a transação
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Insira os dados na tabela Ficha_Medica
                            string queryFichaMedica = "INSERT INTO Ficha_Medica (id_animal, data_ato_medico, tipo_consulta, id_colaborador, " +
                                "peso, observacoes, prescricao_medica, proxima_visita) " +
                                "VALUES (@IdAnimal, @DataAtoMedico, @TipoConsulta, @IdColaborador, " +
                                "@Peso, @Observacoes, @Prescricao, @ProximaVisita); " +
                                "SELECT SCOPE_IDENTITY()";

                            using (SqlCommand cmdFichaMedica = new SqlCommand(queryFichaMedica, connection, transaction))
                            {
                                // Defina os parâmetros
                                cmdFichaMedica.Parameters.AddWithValue("@IdAnimal", idAnimal);
                                cmdFichaMedica.Parameters.AddWithValue("@DataAtoMedico", dataAtoMedico);
                                cmdFichaMedica.Parameters.AddWithValue("@TipoConsulta", tipoConsulta);
                                cmdFichaMedica.Parameters.AddWithValue("@IdColaborador", idColaborador);
                                //cmdFichaMedica.Parameters.AddWithValue("@Diagnostico", string.Join(",", listaDiagnosticos.Cast<string>()));
                                //cmdFichaMedica.Parameters.AddWithValue("@AtoMedico", string.Join(",", listaAtos.Cast<string>()));
                                cmdFichaMedica.Parameters.AddWithValue("@Peso", peso);
                                cmdFichaMedica.Parameters.AddWithValue("@Observacoes", observacoes);
                                cmdFichaMedica.Parameters.AddWithValue("@Prescricao", prescricao);
                                cmdFichaMedica.Parameters.AddWithValue("@ProximaVisita", proximaVisita);

                                // Execute o comando e obtenha o ID inserido
                                int fichaMedicaId = Convert.ToInt32(cmdFichaMedica.ExecuteScalar());

                                // Insira os dados na tabela pivot listaProdutos
                                string queryListaProdutos = "INSERT INTO Ficha_Medica_Produtos (Id_Ficha_Medica, Id_Produto) " +
                                    "VALUES (@FichaMedicaId, @ProdutoId)";

                                string updateQuantidadeArmazem = "UPDATE Produtos SET quantidade_armazem = quantidade_armazem - 1 WHERE cod_produto = @ProdutoId";

                                using (SqlCommand cmdListaProdutos = new SqlCommand(queryListaProdutos, connection, transaction))
                                using (SqlCommand cmdUpdateQuantidadeArmazem = new SqlCommand(updateQuantidadeArmazem, connection, transaction))
                                {
                                    // Insira cada produto da listaProdutos
                                    foreach (var produto in listaProdutos)
                                    {
                                        int produtoId = ((ProdutoItem)produto).codigoProduto;
                                        cmdListaProdutos.Parameters.Clear();
                                        cmdListaProdutos.Parameters.AddWithValue("@FichaMedicaId", fichaMedicaId);
                                        cmdListaProdutos.Parameters.AddWithValue("@ProdutoId", produtoId);
                                        cmdListaProdutos.ExecuteNonQuery();

                                        cmdUpdateQuantidadeArmazem.Parameters.Clear();
                                        cmdUpdateQuantidadeArmazem.Parameters.AddWithValue("@ProdutoId", produtoId);
                                        cmdUpdateQuantidadeArmazem.ExecuteNonQuery();
                                    }
                                }

                                // Insira os dados na tabela pivot listaAtos
                                string queryListaAtos = "INSERT INTO AtosMedicos_Ficha_Medica (Id_Ficha_Medica, Id_Atomedico) " +
                                    "VALUES (@FichaMedicaId, @AtoId)";

                                using (SqlCommand cmdListaAtos = new SqlCommand(queryListaAtos, connection, transaction))
                                {
                                    // Insira cada produto da listaProdutos
                                    foreach (var ato in listaAtos)
                                    {
                                        int atoId = ((AtoMedicoItem)ato).Id; // Aqui, substitua AtoItem por AtoMedicoItem
                                        cmdListaAtos.Parameters.Clear();
                                        cmdListaAtos.Parameters.AddWithValue("@FichaMedicaId", fichaMedicaId);
                                        cmdListaAtos.Parameters.AddWithValue("@AtoId", atoId);
                                        cmdListaAtos.ExecuteNonQuery();
                                    }
                                }

                                // Insira os dados na tabela pivot listaDiagnosticos
                                string queryDiagnosticos = "INSERT INTO Diagnosticos_Ficha_Medica (Id_Ficha_Medica, Id_Diagnostico) " +
                                            "VALUES (@FichaMedicaId, @DiagnosticoId)";

                                using (SqlCommand cmdListaDiagnosticos = new SqlCommand(queryDiagnosticos, connection, transaction))
                                {
                                    // Insira cada produto da listaDiagnosticos
                                    foreach (var diagnostico in listaDiagnosticos)
                                    {
                                        int diagnosticoId = ((DiagnosticoItem)diagnostico).Id;
                                        cmdListaDiagnosticos.Parameters.Clear();
                                        cmdListaDiagnosticos.Parameters.AddWithValue("@FichaMedicaId", fichaMedicaId);
                                        cmdListaDiagnosticos.Parameters.AddWithValue("@DiagnosticoId", diagnosticoId);
                                        cmdListaDiagnosticos.ExecuteNonQuery();
                                    }
                                }

                                // Commit a transação
                                transaction.Commit();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Ocorreu um erro, desfaça a transação
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao guardar a ficha médica: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AtualizarFichaMedica(int fichaMedicaId, DateTime dataAtoMedico, string tipoConsulta, int idColaborador, float peso, string observacoes, string prescricao, DateTime proximaVisita, ListBox.ObjectCollection listaProdutos, ListBox.ObjectCollection listaDiagnosticos, ListBox.ObjectCollection listaAtos)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Atualizar os dados da ficha médica na tabela Ficha_Medica
                    string queryAtualizarFichaMedica = "UPDATE Ficha_Medica SET data_ato_medico = @DataAtoMedico, tipo_consulta = @TipoConsulta, id_colaborador = @IdColaborador, peso = @Peso, observacoes = @Observacoes, prescricao_medica = @Prescricao, proxima_visita = @ProximaVisita WHERE id = @FichaMedicaId";

                    using (SqlCommand cmd = new SqlCommand(queryAtualizarFichaMedica, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@DataAtoMedico", dataAtoMedico);
                        cmd.Parameters.AddWithValue("@TipoConsulta", tipoConsulta);
                        cmd.Parameters.AddWithValue("@IdColaborador", idColaborador);
                        cmd.Parameters.AddWithValue("@Peso", peso);
                        cmd.Parameters.AddWithValue("@Observacoes", observacoes);
                        cmd.Parameters.AddWithValue("@Prescricao", prescricao);
                        cmd.Parameters.AddWithValue("@ProximaVisita", proximaVisita);
                        cmd.Parameters.AddWithValue("@FichaMedicaId", fichaMedicaId);

                        cmd.ExecuteNonQuery();
                    }

                    // Remover os registros existentes nas tabelas de pivot que não estão nas listas fornecidas
                    string queryRemoverAtosMedicos = "DELETE FROM AtosMedicos_Ficha_Medica WHERE id_ficha_medica = @FichaMedicaId AND id_atomedico NOT IN (@IdAtoMedico)";

                    using (SqlCommand cmd = new SqlCommand(queryRemoverAtosMedicos, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FichaMedicaId", fichaMedicaId);
                        cmd.Parameters.Add("@IdAtoMedico", SqlDbType.Int);

                        // Adicionar os IDs de atos médicos à lista de parâmetros
                        foreach (AtoMedicoItem atoMedico in listaAtos)
                        {
                            cmd.Parameters["@IdAtoMedico"].Value = atoMedico.Id;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Remover os registros existentes nas tabelas de pivot que não estão nas listas fornecidas
                    string queryRemoverDiagnosticos = "DELETE FROM Diagnosticos_Ficha_Medica WHERE Id_ficha_medica = @FichaMedicaId AND Id_diagnostico NOT IN (@IdDiagnostico)";

                    using (SqlCommand cmd = new SqlCommand(queryRemoverDiagnosticos, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FichaMedicaId", fichaMedicaId);
                        cmd.Parameters.Add("@IdDiagnostico", SqlDbType.Int);

                        // Adicionar os IDs de diagnósticos à lista de parâmetros
                        foreach (DiagnosticoItem diagnostico in listaDiagnosticos)
                        {
                            cmd.Parameters["@IdDiagnostico"].Value = diagnostico.Id;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Remover os registros existentes nas tabelas de pivot que não estão nas listas fornecidas
                    string queryRemoverProdutos = "DELETE FROM Ficha_Medica_Produtos WHERE id_ficha_medica = @FichaMedicaId AND id_produto NOT IN (@CodProduto)";

                    using (SqlCommand cmd = new SqlCommand(queryRemoverProdutos, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FichaMedicaId", fichaMedicaId);
                        cmd.Parameters.Add("@CodProduto", SqlDbType.Int);

                        // Adicionar os códigos de produtos à lista de parâmetros
                        foreach (ProdutoItem produto in listaProdutos)
                        {
                            cmd.Parameters["@CodProduto"].Value = produto.codigoProduto;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Inserir os novos registros nas tabelas de pivot, se não existirem
                    string queryInserirAtosMedicos = "INSERT INTO AtosMedicos_Ficha_Medica (id_ficha_medica, id_atomedico) SELECT @FichaMedicaId, @IdAtoMedico WHERE NOT EXISTS (SELECT 1 FROM AtosMedicos_Ficha_Medica WHERE id_ficha_medica = @FichaMedicaId AND id_atomedico = @IdAtoMedico)";
                    string queryInserirDiagnosticos = "INSERT INTO Diagnosticos_Ficha_Medica (Id_ficha_medica, Id_diagnostico) SELECT @FichaMedicaId, @IdDiagnostico WHERE NOT EXISTS (SELECT 1 FROM Diagnosticos_Ficha_Medica WHERE Id_ficha_medica = @FichaMedicaId AND Id_diagnostico = @IdDiagnostico)";
                    string queryInserirProdutos = "INSERT INTO Ficha_Medica_Produtos (id_ficha_medica, id_produto) SELECT @FichaMedicaId, @CodProduto WHERE NOT EXISTS (SELECT 1 FROM Ficha_Medica_Produtos WHERE id_ficha_medica = @FichaMedicaId AND id_produto = @CodProduto)";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.Transaction = transaction;

                        // Inserir os registros para os Atos Medicos
                        foreach (AtoMedicoItem atoMedico in listaAtos)
                        {
                            cmd.CommandText = queryInserirAtosMedicos;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@FichaMedicaId", fichaMedicaId);
                            cmd.Parameters.AddWithValue("@IdAtoMedico", atoMedico.Id);
                            cmd.ExecuteNonQuery();
                        }

                        // Inserir os registros para os Diagnosticos
                        foreach (DiagnosticoItem diagnostico in listaDiagnosticos)
                        {
                            cmd.CommandText = queryInserirDiagnosticos;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@FichaMedicaId", fichaMedicaId);
                            cmd.Parameters.AddWithValue("@IdDiagnostico", diagnostico.Id);
                            cmd.ExecuteNonQuery();
                        }

                        // Inserir os registros para os Produtos
                        foreach (ProdutoItem produto in listaProdutos)
                        {
                            cmd.CommandText = queryInserirProdutos;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@FichaMedicaId", fichaMedicaId);
                            cmd.Parameters.AddWithValue("@CodProduto", produto.codigoProduto);
                            cmd.ExecuteNonQuery();

                            // Controlar a quantidade_armazem
                            if (produto.quantidadeArmazem > 0)
                            {
                                // Atualizar a quantidade_armazem na tabela Produtos
                                string queryAtualizarQuantidadeArmazem = "UPDATE Produtos SET quantidade_armazem = quantidade_armazem - 1 WHERE cod_produto = @CodProduto";
                                using (SqlCommand cmdAtualizarQuantidadeArmazem = new SqlCommand(queryAtualizarQuantidadeArmazem, con, transaction))
                                {
                                    cmdAtualizarQuantidadeArmazem.Parameters.AddWithValue("@CodProduto", produto.codigoProduto);
                                    cmdAtualizarQuantidadeArmazem.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao atualizar a ficha médica: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
