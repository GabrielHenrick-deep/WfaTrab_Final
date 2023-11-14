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
    public partial class FormAtualizaPijama : Form
    {
        public FormAtualizaPijama()
        {
            InitializeComponent();
            AtualizarPijama();
        }
        private void AtualizarPijama()
        {
            StringConexao objStringCos = new StringConexao();
            string contemStringCons = objStringCos.Conectar();
            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringCons);
            objConnection.Open();

            string stringSql = $"SELECT*FROM pijama";

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    data_atua_pijama.DataSource = dt;
                }
            }
            objConnection.Close();
        }

        private void bt_atu_pijama_Click(object sender, EventArgs e)
        {
            var id_pijama = Convert.ToInt32(data_atua_pijama.Rows[data_atua_pijama.CurrentCell.RowIndex].Cells[0].Value);
            EditaPijama objEditaPijama = new EditaPijama(id_pijama);
            objEditaPijama.ShowDialog();
        }

        private void bt_con_pijama_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tabela atualizada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarPijama();
        }

        private void bt_exluir_pijama_Click(object sender, EventArgs e)
        {
            StringConexao objCosString = new StringConexao();
            string contemCons = objCosString.Conectar();

            NpgsqlConnection objCons = new NpgsqlConnection(contemCons);
            objCons.Open();

            var id_pijama = Convert.ToInt32(data_atua_pijama.Rows[data_atua_pijama.CurrentCell.RowIndex].Cells[0].Value);

            string stringSql = $"DELETE FROM pijama WHERE id_pijama = {id_pijama}";

            using (NpgsqlCommand cmd = new NpgsqlCommand(stringSql, objCons))
            {
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Dados Excluidos com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            objCons.Close();
            AtualizarPijama();
        }
    }
}
