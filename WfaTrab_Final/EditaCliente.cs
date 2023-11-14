using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace WfaTrab_Final
{
    public partial class EditaCliente : Form
    {
        int id = 0;
        public EditaCliente(int id)
        {
            InitializeComponent();
            this.id = id;

            if(this.id > 0)
            {
                GetCliente(id);
            }
            mtb_cpf.Mask = "000.000.000-00";
            mtb_tell.Mask = "00.0000.0000";
            mtb_dataC.Mask = "00/00/0000";
            mtb_cep.Mask = "00000-000";
        }
        private void GetCliente(int id)
        {
            StringConexao objStringCons = new StringConexao();
            string contemStringCons = objStringCons.Conectar();

            NpgsqlConnection objCons = new NpgsqlConnection(contemStringCons);
            objCons.Open();

            string stringSql = $"SELECT*FROM cliente WHERE id_cliente = {id}";
            using (NpgsqlCommand cmd = new NpgsqlCommand(stringSql, objCons))
            {
                using(NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    if(dr.Read())
                    {
                        mtb_cpf.Text = dr["cpf_cliente"].ToString(); 
                        tb_nomeC.Text = dr["nome"].ToString() ;
                        mtb_rua.Text = dr["rua"].ToString();
                        mtb_tell.Text = dr["telefone"].ToString(); 
                        tb_email.Text = dr["email"].ToString();
                        mtb_dataC.Text = dr["data_nas"].ToString();
                        tb_bairro.Text = dr["bairro"].ToString();
                        tb_cidade.Text = dr["cidade"].ToString();
                        tb_uf.Text = dr["uf"].ToString();
                        tb_numero.Text = dr["numero_casa"].ToString();
                        mtb_cep.Text = dr["cep"].ToString();
                    }
                }
            }
            objCons.Close();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente objCliente = new Cliente(mtb_cpf.Text, tb_nomeC.Text, mtb_rua.Text, mtb_tell.Text, tb_email.Text, mtb_dataC.Text, tb_bairro.Text, tb_cidade.Text, tb_uf.Text, Convert.ToInt32(tb_numero.Text), mtb_cep.Text);
                if (objCliente.Cpf == string.Empty || objCliente.Nome == string.Empty || objCliente.Rua == string.Empty || objCliente.Telefone == string.Empty || objCliente.Email == string.Empty || objCliente.Data_nasc == string.Empty)
                {
                    MessageBox.Show("Preencha todos os campos corretamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    StringConexao objConsString = new StringConexao();
                    string contemConsString = objConsString.Conectar();

                    NpgsqlConnection objCons = new NpgsqlConnection(contemConsString);
                    objCons.Open();

                    string stringSql = $"UPDATE cliente SET cpf_cliente = '{mtb_cpf.Text}', nome = '{tb_nomeC.Text}', rua = '{mtb_rua.Text}'," +
                        $" telefone = '{mtb_tell.Text}', email = '{tb_email.Text}', data_nas = '{mtb_dataC.Text}', bairro = '{tb_bairro.Text}'," +
                        $" cidade = '{tb_cidade.Text}', uf = '{tb_uf.Text}', numero_casa = '{tb_numero.Text}', cep = '{mtb_cep.Text}'" +
                        $"WHERE id_cliente = {this.id}";
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objCons))
                    {
                        npgsqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cliente Editado com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objCons.Close();
                }
            }
            catch(FormatException formatException)
            {
                MessageBox.Show("Preencha corretamente todos os dados pedidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
