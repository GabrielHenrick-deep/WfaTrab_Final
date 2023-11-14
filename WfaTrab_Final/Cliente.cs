using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaTrab_Final
{
    public class Cliente
    {
        //Atributos
        private string cpf;
        private string nome;
        private string rua;
        private string telefone;
        private string email;
        private string data_nasc;
        private string bairro;
        private string cidade;
        private string uf;
        private int numero_casa;
        private string cep;

        //Constrores
        public Cliente(string cpf, string nome, string rua, string telefone, string email, string data_nasc, string bairro, string cidade, string uf, int numero_casa, string cep)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.rua = rua;
            this.telefone = telefone;
            this.email = email;
            this.data_nasc = data_nasc;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.numero_casa = numero_casa;
            this.cep = cep;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Data_nasc { get => data_nasc; set => data_nasc = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public int Numero_casa { get => numero_casa; set => numero_casa = value; }
        public string Cep { get => cep; set => cep = value; }
    }
}
