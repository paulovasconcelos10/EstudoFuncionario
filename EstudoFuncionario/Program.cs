using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Desenvolvedor desenvolvedor = new Desenvolvedor("Paulo", "1234");  
            Console.WriteLine(desenvolvedor.Nome);
            Console.WriteLine(desenvolvedor.Cpf);
            Console.WriteLine(desenvolvedor.Salario);
            desenvolvedor.AumentarSalario();
            Console.WriteLine(desenvolvedor.Salario);
            Diretor diretor = new Diretor("Victor", "56789");
            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.Cpf);
            Console.WriteLine(diretor.Salario);
            diretor.AumentarSalario();
            Console.WriteLine(diretor.Salario);

            Console.ReadLine(); 
        }
    }
}
