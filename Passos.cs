using System;
using System.Collections.Generic;
using System.Text;

namespace Corrida_animais.Objetos
{
    class Passos
    {
        public void andar(int n_passos)
        {
            for (int i = 0; i < n_passos; i++)
            {
                Console.WriteLine("passos n" + i.ToString());
            }
        }
    }
}
