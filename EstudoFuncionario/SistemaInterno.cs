using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFuncionario
{
    class SistemaInterno
    {
        public bool Logar (Diretor funcionario, string senha)
        {
            bool usuarioFuncionario = funcionario.Autenticar(senha);
            if (usuarioFuncionario)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
