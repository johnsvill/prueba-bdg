using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDivisores
{
    class DivisorNumero
    {
        int Numero;
        int Resultado;

        public void p_Numero_set(int valor)
        {
            Numero = valor;                
        }
        public int p_Resultado_get()
        {
            return Resultado;
        }
        public void Divisores()
        {
            int i;
            for(i = 1; i <= Numero; i++)
            {
                if(Numero % i == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Estos son los números divisores: " + i);
                }
            }
        }
    }
}
