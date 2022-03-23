using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFuncionario
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }    
        public double Salario { get; protected set; }    

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;  
            Salario = salario;
        }

        public abstract double Bonificacao();

        public abstract void AumentarSalario();
    }
}
