using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFuncionario
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf) : base(nome, cpf, 8000)
        {

        }

        public override double Bonificacao()
        {
            return Salario * 1.5;
        }

        public override void AumentarSalario()
        {
            Salario += Salario * 1.5;
        }
    }
}
