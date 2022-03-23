﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFuncionario
{
    public abstract class FuncionarioAutenficavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenficavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
