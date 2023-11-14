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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            mtb_cpf.Mask = "000.000.000-00";
            mtb_tell.Mask = "00.0000.0000";
            mtb_dataC.Mask = "00/00/0000";
            mtb_cep.Mask = "00000-000";
        }

        private void bt_cadC_Click(object sender, EventArgs e)
        {
            bool continuarLoop = true;
            do 
            {
                try 
                {
                    Cliente objCliente = new Cliente(mtb_cpf.Text,tb_nomeC.Text,mtb_rua.Text,mtb_tell.Text,tb_email.Text, mtb_dataC.Text, tb_bairro.Text,tb_cidade.Text,tb_uf.Text,Convert.ToInt32(tb_numero.Text),mtb_cep.Text);
                    if(objCliente.Cpf == string.Empty || objCliente.Nome == string.Empty || objCliente.Rua == string.Empty || objCliente.Telefone == string.Empty || objCliente.Email == string.Empty || objCliente.Data_nasc == string.Empty) 
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

                        string stringSql = $"INSERT INTO cliente (cpf_cliente, nome, rua, telefone, email, data_nas, bairro, cidade, uf, numero_casa, cep)" +
                            $"VALUES('{objCliente.Cpf}', '{objCliente.Nome}', '{objCliente.Rua}','{objCliente.Telefone}', '{objCliente.Email}', '{objCliente.Data_nasc}', " +
                            $"'{objCliente.Bairro}', '{objCliente.Cidade}', '{objCliente.Uf}','{objCliente.Numero_casa}', '{objCliente.Cep}')";
                        using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql,objCons)) 
                        {
                            npgsqlCommand.ExecuteNonQuery(); 
                        }
                        objCons.Close();
                        MessageBox.Show("Cliente Cadastrado com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpartextbox();
                        continuarLoop = false;
                    }
                }
                catch(FormatException formatException) 
                { 
                    continuarLoop = false;
                    MessageBox.Show("Preencha todos os campos corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }while(continuarLoop);
        }
        public void limpartextbox()
        {
            mtb_cpf.Text = string.Empty;
            tb_nomeC.Text = string.Empty;
            mtb_rua.Text = string.Empty;
            mtb_tell.Text = string.Empty;
            tb_email.Text = string.Empty;
            mtb_dataC.Text = string.Empty;
            tb_bairro.Text = string.Empty;
            tb_cidade.Text = string.Empty;
            tb_uf.Text = string.Empty;
            tb_numero.Text = string.Empty;
            mtb_cep.Text = string.Empty;
        }

        private void bt_limparC_Click(object sender, EventArgs e)
        {
            limpartextbox();
        }
    }
}
