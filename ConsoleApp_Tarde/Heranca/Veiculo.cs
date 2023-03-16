using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde.Heranca
{
    public class Veiculo
    {
        public string cor;
        public int q_Rodas;
        public int q_Assentos;
        public bool TemMotor;

        public string ExibirDados()
        {
            if (TemMotor)
            {
                return "Tem motor "+ cor + " " + q_Assentos + " " + q_Rodas;
            }
            else
            {
                return cor + " " + q_Assentos + " " + q_Rodas;
            }
            
        }

    }
}
