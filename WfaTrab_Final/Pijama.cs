using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaTrab_Final
{
    public class Pijama
    {
        //Atributos
        private string desc;
        private decimal  preco;
        private string tamanho;
        private string material;
        private int estoq;
        
        //Construtor

        public Pijama(string desc, decimal preco, string tamanho, string material, int estoq)
        {
            this.desc = desc;
            this.preco = preco;
            this.tamanho = tamanho;
            this.material = material;
            this.estoq = estoq;
        }

        //Getters and Setters
        public string Desc { get => desc; set => desc = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public string Tamanho { get => tamanho; set => tamanho = value; }
        public string Material { get => material; set => material = value; }
        public int Estoq { get => estoq; set => estoq = value; }
    }
}
