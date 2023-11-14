using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Globalization;

namespace WfaTrab_Final
{
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
            
            mtb_data_pedido.Mask = "00/00/0000";
        }

        private void bt_cadPd_Click(object sender, EventArgs e)
        {
            bool continuarLoop = true;
            do
            {
                try
                {
                    Pedido objPedido = new Pedido(cb_cliente.Text, mtb_data_pedido.Text, tb_situaPed.Text, tb_preco.Text, tb_nome_cliente.Text,cb_modelo.Text);
                    if (objPedido.ClienteId == string.Empty || objPedido.DataPedido == string.Empty || objPedido.Status == string.Empty || objPedido.nome_Cliente == string.Empty)
                    {
                        MessageBox.Show("Preencha todos os campos corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        continuarLoop = false;
                    }
                    else
                    {
                        StringConexao objConsString = new StringConexao();
                        string contemConsString = objConsString.Conectar();

                        NpgsqlConnection objCons = new NpgsqlConnection(contemConsString);
                        objCons.Open();

                        string stringSql = $"INSERT INTO pedido(cpf_cliente, nome_cliente, data_pedido, situacao, modelo, preco)" +
                            $"VALUES('{objPedido.ClienteId}','{objPedido.nome_Cliente}', '{objPedido.DataPedido}', '{objPedido.Status}', '{objPedido.Modelo}', '{objPedido._pijama}')";
                        using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objCons))
                        {
                            npgsqlCommand.ExecuteNonQuery();
                        }
                        objCons.Close();
                        MessageBox.Show("Pedido Cadastrado com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpartextbox();
                        continuarLoop = false;
                    }
                }
                catch (FormatException formatException)
                {
                    continuarLoop = false;
                    MessageBox.Show("Preencha todos os campos corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } while (continuarLoop);
        }
        public void limpartextbox()
        {
            cb_cliente.Text = string.Empty;
            tb_nome_cliente.Text = string.Empty;
            mtb_data_pedido.Text = string.Empty;
            tb_situaPed.Text = string.Empty;
            tb_preco.Text = string.Empty;
            
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            StringConexao objcons = new StringConexao();
            string contemStringCons = objcons.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringCons);
            objConnection.Open();

            try
            {
                string stringSql = "SELECT id_cliente, cpf_cliente FROM cliente";
                NpgsqlCommand saveCliente = new NpgsqlCommand(stringSql, objConnection);
                DataSet dt = new DataSet();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(saveCliente);
                da.Fill(dt);
                cb_cliente.DisplayMember = "cpf_cliente";
                cb_cliente.ValueMember = "id_cliente";
                cb_cliente.DataSource = dt.Tables[0];
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Occorreu um erro!");
            }
            try
            {
                string stringSql = "SELECT id_pijama, modelo FROM pijama";
                NpgsqlCommand savePijama = new NpgsqlCommand(stringSql, objConnection);
                DataSet dt3 = new DataSet();
                NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(savePijama);
                da3.Fill(dt3);
                cb_modelo.DisplayMember = "modelo";
                cb_modelo.ValueMember = "id_pijama";
                cb_modelo.DataSource = dt3.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!");
            }
            finally
            {
                objConnection.Close();
            }
        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringConexao objcons = new StringConexao();
            string contemStringCons = objcons.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringCons);
            objConnection.Open();

            try
            {
                string selectedCpf = cb_cliente.Text;

                string nomeSql = "SELECT nome FROM cliente WHERE cpf_cliente = @cpf";
                NpgsqlCommand getNomeCliente = new NpgsqlCommand(nomeSql, objConnection);
                getNomeCliente.Parameters.AddWithValue("@cpf", selectedCpf);

                string nomeCliente = getNomeCliente.ExecuteScalar() as String;

                tb_nome_cliente.Text = nomeCliente;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                objConnection.Close();
            }
        }

        private void cb_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringConexao objcons = new StringConexao();
            string contemStringCons = objcons.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringCons);
            objConnection.Open();

            try
            {
                string selectedModelo = cb_modelo.Text;

                
                string precoSql = "SELECT preco FROM pijama WHERE modelo = @modelo";
                NpgsqlCommand getPrecoPijama = new NpgsqlCommand(precoSql, objConnection);
                getPrecoPijama.Parameters.AddWithValue("@modelo", selectedModelo);

                
                decimal preco = Convert.ToDecimal(getPrecoPijama.ExecuteScalar());

                
                CultureInfo cultureInfo = new CultureInfo("pt-BR"); 
                tb_preco.Text = preco.ToString("C", cultureInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                objConnection.Close();
            }
        }
    }
}
