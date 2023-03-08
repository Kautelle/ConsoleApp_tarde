using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_tarde
{
    public class Cliente
    {
        private int Id;
        private string Name;
        private string Telefone;

    public Cliente(int id, string name, string telefone)
        {
            Id = id;
            Name = name;
            Telefone = telefone;
        }

        public int getId()
        { return Id; }
        public string getName() 
        { return Name; }
        
        public string getTelefone() 
        {return Telefone;}

        public void setId(int id)
        {
            Id = id;
        }
        public void setName(string name)
        {
            Name = name;
        }

        public void setTelefone(string telefone) 
        {
            Telefone = telefone;
        }
    }
}
