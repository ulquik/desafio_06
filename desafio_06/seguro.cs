using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_06
{
    public class tipo
    {
        public virtual void CalcularSeguro(decimal valorDiaria)
        {
            Console.WriteLine($"O valor do seguro sobre o carro popular é de R$ {valorDiaria * 0.10m}");
        }
    }
}
