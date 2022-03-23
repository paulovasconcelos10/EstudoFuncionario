using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFuncionario
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor (string nome, string cpf) : base( nome, cpf, 5000)
        {

        }
        public override double Bonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.5;
        }
    }
}
