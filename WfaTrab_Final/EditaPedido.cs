using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WfaTrab_Final
{
    public partial class EditaPedido : Form
    {
        int id = 0;
        public EditaPedido(int id)
        {
            InitializeComponent();
            this.id = id;

            if (this.id > 0)
            {
                GetPedido(id);
            }
        }
        private void GetPedido(int id)
        {
            StringConexao objStringCons = new StringConexao();
            string contemStringCons = objStringCons.Conectar();

            NpgsqlConnection objCons = new NpgsqlConnection(contemStringCons);
            objCons.Open();

            string stringSql = $"SELECT*FROM pedido WHERE id_pedido = {id}";
            using (NpgsqlCommand cmd = new NpgsqlCommand(stringSql, objCons))
            {
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cb_cliente.Text = dr["cpf_cliente"].ToString();
                        tb_nome_cliente2.Text = dr["nome_cliente"].ToString();
                        mtb_data_pedido.Text = dr["data_pedido"].ToString();
                        tb_situaPed.Text = dr["situacao"].ToString();
                        cb_modelo.Text = dr["modelo"].ToString();
                        tb_preco2.Text = dr["preco"].ToString();
                    }
                }
            }
            objCons.Close();
        }

        private void bt_cadPd_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido objPedido = new Pedido(cb_cliente.Text, mtb_data_pedido.Text, tb_situaPed.Text, tb_preco2.Text, tb_nome_cliente2.Text, cb_modelo.Text);
                if (objPedido.ClienteId == string.Empty || objPedido.DataPedido == string.Empty || objPedido.Status == string.Empty || objPedido.nome_Cliente == string.Empty)
                {
                    MessageBox.Show("Preencha todos os campos corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    StringConexao objConsString = new StringConexao();
                    string contemConsString = objConsString.Conectar();

                    NpgsqlConnection objCons = new NpgsqlConnection(contemConsString);
                    objCons.Open();

                    string stringSql = $"UPDATE pedido SET cpf_cliente = '{cb_cliente.Text}', nome_cliente = '{tb_nome_cliente2.Text}', data_pedido = '{mtb_data_pedido.Text}'," +
                        $" situacao = '{tb_situaPed.Text}', modelo = '{cb_modelo.Text}', preco = '{tb_preco2.Text}' " +
                        $"WHERE id_pedido = {this.id}";
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objCons))
                    {
                        npgsqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Pedido Editado com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objCons.Close();
                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Preencha corretamente todos os dados pedidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EditaPedido_Load(object sender, EventArgs e)
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
                MessageBox.Show("Occorreu um erro!" + ex.Message);
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
                MessageBox.Show("Ocorreu um erro!" + ex.Message);
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

                tb_nome_cliente2.Text = nomeCliente;
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
                tb_preco2.Text = preco.ToString("C", cultureInfo);
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
