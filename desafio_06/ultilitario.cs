using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_06
{
    public class CarroUtilitario : tipo
    {
        public override void CalcularSeguro(decimal valor)
        {
            Console.WriteLine($"O valor do seguro sobre o carro utiliário é de R$ {valor * 0.25m}");
        }
    }
}