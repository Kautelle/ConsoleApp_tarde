﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_tarde
{
    public class Produto
    {
        private int Id;
        private string Descricao;
        private decimal Valor;
        
        
        public Produto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            
        }

        public int getid() 

        { return Id; }

        public string getDescricao()

        { return Descricao; }

        public decimal getValor()

        {  return Valor; }

        

        public void setId(int id)
        {
            
                Id = id;
        }
        public void setDescricao(string descricao)
        {

            Descricao = descricao;
        }
        public void setValor(decimal valor)
        {

            Valor = valor;
        }


    }

}
