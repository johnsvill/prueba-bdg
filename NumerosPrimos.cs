using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDivisores
{
    public class NumerosPrimos
    {
        int Cont = 0;
        int Suma = 0;
        int Numero = 0;
        private object txt_introducir;

        public void SumaPrimos()
        {
            Numero = int.Parse(txt_introducir.Text);
            for (int i = 2; i <= Numero; i++)
            {
                for(int j=1; j<1; j++)
                {
                    if(i % j == 0)
                    {
                        Cont++;
                    }
                }
                if(Cont<= 2)
                {
                    Suma = Suma + i;                    
                }
                Cont = 0;
                System.Windows.Forms.MessageBox.Show("Esta es la sumatoria de números primos: " + Suma);
            }
        }
     
           
            

          
        
    }
}
