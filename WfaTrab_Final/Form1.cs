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

namespace WfaTrab_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pijamasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPijama pijama_cadastro = new FormPijama();
            pijama_cadastro.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente cliente_cadastro = new FormCliente();
            cliente_cadastro.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedido pedido_cadastro = new FormPedido();
            pedido_cadastro.Show();
        }

        private void pijamasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAtualizaPijama pijama_update = new FormAtualizaPijama();
            pijama_update.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAtualizaCliente clinte_update = new FormAtualizaCliente();
            clinte_update.Show();

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtualizaPedido pedidos_update = new FormAtualizaPedido();
            pedidos_update.Show();
        }

        private void bt_consultar_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                StringConexao objConsString = new StringConexao();
                string cotemConexaoString = objConsString.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(cotemConexaoString);
                objConnection.Open();

                string stringSql = $"SELECT*FROM cliente WHERE cpf_cliente = '{cb_forms1.Text}'";
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvconsulta.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Cliente não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                objConnection.Close();
            }
            if (radioButton2.Checked == true)
            {
                StringConexao objConsString = new StringConexao();
                string cotemConexaoString = objConsString.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(cotemConexaoString);
                objConnection.Open();

                string stringSql = $"SELECT*FROM pedido WHERE cpf_cliente = '{cb_forms1.Text}'";
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvconsulta.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("pedido não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                objConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
                cb_forms1.DisplayMember = "cpf_cliente";
                cb_forms1.ValueMember = "id_cliente";
                cb_forms1.DataSource = dt.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Occorreu um erro!");
            }
            finally
            {
                objConnection.Close();
            }
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
           if(radioButton1.Checked == true)
            {
                StringConexao objcons = new StringConexao();
                string contemStringCons = objcons.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemStringCons);
                objConnection.Open();

                string stringSql = "SELECT*FROM cliente";
                NpgsqlCommand saveCliente = new NpgsqlCommand(stringSql, objConnection);
                DataSet dt = new DataSet();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(saveCliente);
                da.Fill(dt);
                cb_forms1.DisplayMember = "cpf_cliente";
                cb_forms1.ValueMember = "id_cliente";
                cb_forms1.DataSource = dt.Tables[0];

                MessageBox.Show("Sistema Atualizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                objConnection.Close();
            }
        }
    }
}
