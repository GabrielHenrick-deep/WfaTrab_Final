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
    public partial class FormPijama : Form
    {
        public FormPijama()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            bool continuarLoop = true;
            do
            {
                try
                {
                    Pijama objPijama = new Pijama(tb_desc.Text, Convert.ToDecimal(tb_precoPj.Text), tb_tamanho.Text,tb_material.Text, Convert.ToInt32(tb_estoq.Text));

                    if (objPijama.Desc == string.Empty|| objPijama.Tamanho == string.Empty|| objPijama.Material == string.Empty)
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

                        string stringSql = $"INSERT INTO pijama (modelo, preco, tamanho, material, estoque)" +
                            $"VALUES('{objPijama.Desc}', '{objPijama.Preco}', '{objPijama.Tamanho}','{objPijama.Material}', '{objPijama.Estoq}')";
                        using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objCons))
                        {
                            npgsqlCommand.ExecuteNonQuery();
                        }
                        objCons.Close();
                        MessageBox.Show("Pijama Cadastrado com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tb_desc.Text = string.Empty;
            tb_precoPj.Text = string.Empty;
            tb_tamanho.Text = string.Empty;
            tb_material.Text = string.Empty;
            tb_estoq.Text = string.Empty;
        }

    }
}
