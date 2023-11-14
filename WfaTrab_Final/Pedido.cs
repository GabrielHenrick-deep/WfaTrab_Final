using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaTrab_Final
{
    public class Pedido
    {
        private string clienteId;
        private string dataPedido;
        private string status;
        private string pijama;
        private string nome_cliente;
        private string modelo;
        //Construtor
        public Pedido(string clienteId, string dataPedido, string status, string pijama, string nome_cliente, string modelo)
        {
            this.clienteId = clienteId;
            this.dataPedido = dataPedido;
            this.status = status;
            this.pijama = pijama;
            this.nome_cliente = nome_cliente;
            this.modelo = modelo;
        }

        public string ClienteId { get => clienteId; set => clienteId = value; }
        public string DataPedido { get => dataPedido; set => dataPedido = value; }
        public string Status { get => status; set => status = value; }
        public string _pijama { get => pijama; set => pijama = value; }
        public string nome_Cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
