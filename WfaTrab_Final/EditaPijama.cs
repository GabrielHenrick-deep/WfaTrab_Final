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
    public partial class EditaPijama : Form
    {
        int id = 0;
        public EditaPijama(int id)
        {
            InitializeComponent();
            this.id = id;

            if (this.id > 0)
            {
                GetPijama(id);
            }
        }
        private void GetPijama(int id)
        {
            StringConexao objStringCons = new StringConexao();
            string contemStringCons = objStringCons.Conectar();

            NpgsqlConnection objCons = new NpgsqlConnection(contemStringCons);
            objCons.Open();

            string stringSql = $"SELECT*FROM pijama WHERE id_pijama = {id}";
            using (NpgsqlCommand cmd = new NpgsqlCommand(stringSql, objCons))
            {
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        tb_desc.Text = dr["modelo"].ToString();
                        tb_precoPj.Text = dr["preco"].ToString();
                        tb_tamanho.Text = dr["tamanho"].ToString();
                        tb_material.Text = dr["material"].ToString();
                        tb_estoq.Text = dr["estoque"].ToString();
                    }
                }
            }
            objCons.Close();
        }

        private void bt_editar_pijama_Click(object sender, EventArgs e)
        {
            try
            {
                Pijama objPijama = new Pijama(tb_desc.Text, Convert.ToDecimal(tb_precoPj.Text), tb_tamanho.Text, tb_material.Text, Convert.ToInt32(tb_estoq.Text));

                if (objPijama.Desc == string.Empty || objPijama.Tamanho == string.Empty || objPijama.Material == string.Empty)
                {
                    MessageBox.Show("Preencha todos os campos corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    StringConexao objConsString = new StringConexao();
                    string contemConsString = objConsString.Conectar();

                    NpgsqlConnection objCons = new NpgsqlConnection(contemConsString);
                    objCons.Open();


                    string stringSql = $"UPDATE pijama SET modelo = '{tb_desc.Text}', preco = '{tb_precoPj.Text}', tamanho = '{tb_tamanho.Text}'," +
                        $" material = '{tb_material.Text}', estoque = '{tb_estoq.Text}' " +
                        $"WHERE id_pijama = {this.id}";
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objCons))
                    {
                        npgsqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Pijama Editado com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objCons.Close();
                   
                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Preencha corretamente todos os dados pedidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
