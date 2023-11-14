using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Npgsql;
namespace WfaTrab_Final
{
    public partial class FormAtualizaCliente : Form
    {
        public FormAtualizaCliente()
        {
            InitializeComponent();
            AtualizarCliente();
        }

        private void AtualizarCliente()
        {
            StringConexao objStringCos = new StringConexao(); 
            string contemStringCons = objStringCos.Conectar();
            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringCons);
            objConnection.Open();

            string stringSql = $"SELECT*FROM cliente";

            using(NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                using(DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    data_atua_cliente.DataSource = dt;
                }
            }
            objConnection.Close();
        }

        private void bt_atu_cliente_Click(object sender, EventArgs e)
        {
            var id_cliente = Convert.ToInt32(data_atua_cliente.Rows[data_atua_cliente.CurrentCell.RowIndex].Cells[0].Value);
            EditaCliente objEditaCliente = new EditaCliente(id_cliente);
            objEditaCliente.ShowDialog();
        }

        private void bt_conClinete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tabela atualizada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarCliente();
        }

        private void bt_exluir_cliente_Click(object sender, EventArgs e)
        {
            StringConexao objCosString = new StringConexao();
            string contemCons = objCosString.Conectar();

            NpgsqlConnection objCons = new NpgsqlConnection(contemCons);
            objCons.Open();

            var id_cliente = Convert.ToInt32(data_atua_cliente.Rows[data_atua_cliente.CurrentCell.RowIndex].Cells[0].Value);

            string stringSql = $"DELETE FROM cliente WHERE id_cliente = {id_cliente}";

            using (NpgsqlCommand cmd = new NpgsqlCommand(stringSql, objCons))
            {
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Dados Excluidos com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            objCons.Close();
            AtualizarCliente();
        }
    }
}
