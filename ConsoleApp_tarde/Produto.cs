using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_tarde
{
    public class Produto
    {
        private int id;
        private decimal Valor;
        private string descricao;

        public Produto(int id, decimal valor, string descricao)
        {
            id = id;
            Valor = valor;
            descricao = descricao;
        }

        public int getid() { return id; }
        public decimal GetValor() {  return Valor; }
        public string GetDescricao() {  return descricao; }
    }

}
