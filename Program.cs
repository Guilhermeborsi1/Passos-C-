using System;
using Corrida_animais.Objetos;

namespace Corrida_animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Passos oPasso = new Passos();
            
            Rotulo_animal:
            Console.WriteLine("Digite o animal gato, cachorro ou cavalo: ");
            string animal = Console.ReadLine();

            if(animal.ToUpper() == "GATO" || animal.ToUpper() == "CACHORRO" || animal.ToUpper() == "CAVALO" )
                {}
            else 
            {
                Console.WriteLine("Digite corretamente");
                Console.WriteLine("Cachorro, Gato ou Cavalo");
                goto Rotulo_animal;
            }

            Rotulo_passos:
            Console.WriteLine("Digite os passos necessarios: ");
            string passos = Console.ReadLine();

            if (passos == "1" || 
                passos == "2" || 
                passos == "3" || 
                passos == "4" || 
                passos == "5" || 
                passos == "6")
            {
                oPasso.andar(int.Parse(passos));
            }
            else
            {
                Console.WriteLine("Digite corretamente");
                Console.WriteLine("De 1 a 6");
                goto Rotulo_passos;

                

            }
        }
    }
}
