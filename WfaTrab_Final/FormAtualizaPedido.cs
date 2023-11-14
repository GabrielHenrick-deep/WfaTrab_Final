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
    public partial class FormAtualizaPedido : Form
    {
        public FormAtualizaPedido()
        {
            InitializeComponent();
            AtualizarPedido();
        }

        private void AtualizarPedido()
        {
            StringConexao objStringCos = new StringConexao();
            string contemStringCons = objStringCos.Conectar();
            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringCons);
            objConnection.Open();

            string stringSql = $"SELECT*FROM pedido";

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    data_atua_pedido.DataSource = dt;
                }
            }
            objConnection.Close();
        }

        private void bt_atu_pedido_Click(object sender, EventArgs e)
        {

            var id_pedido = Convert.ToInt32(data_atua_pedido.Rows[data_atua_pedido.CurrentCell.RowIndex].Cells[0].Value);
            EditaPedido objEditaPedido = new EditaPedido(id_pedido);
            objEditaPedido.ShowDialog();
        }

        private void bt_con_pedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tabela atualizada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarPedido();
        }

        private void bt_exluir_pedido_Click(object sender, EventArgs e)
        {

            StringConexao objCosString = new StringConexao();
            string contemCons = objCosString.Conectar();

            NpgsqlConnection objCons = new NpgsqlConnection(contemCons);
            objCons.Open();

            var id_pedido = Convert.ToInt32(data_atua_pedido.Rows[data_atua_pedido.CurrentCell.RowIndex].Cells[0].Value);

            string stringSql = $"DELETE FROM pedido WHERE id_pedido = {id_pedido}";

            using (NpgsqlCommand cmd = new NpgsqlCommand(stringSql, objCons))
            {
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Dados Excluidos com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            objCons.Close();
            AtualizarPedido();
        }
    }    
}
