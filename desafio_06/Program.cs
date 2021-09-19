using System;
using System.Threading;

namespace desafio_06
{
    class Program
    {
        static void Main(string[] args)
        {
           tipo carroPopular = new CarroPopular();
            carroPopular.CalcularSeguro(100);
            Console.WriteLine("---------------------------------------------------------------------------");

           tipo carroDeLuxo = new CarroDeLuxo();
            carroDeLuxo.CalcularSeguro(300);
            Console.WriteLine("---------------------------------------------------------------------------");
            
            tipo carroUtilitario = new CarroUtilitario();
            carroUtilitario.CalcularSeguro(400);
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}

