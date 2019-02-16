using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWhile
{
    public class Validacoes
    {
        public bool ValidarNull (Pessoa pessoa)
        {
            bool Checar = true;
            if ((pessoa.Nome.Trim() == "") || (pessoa.Nome.Trim() == null))
                Checar = false;
            else if ((pessoa.Idade.ToString().Trim() == "") || (pessoa.Idade.ToString().Trim() == null))
                Checar = false;
            else if ((pessoa.Sexo.ToString().Trim() == "") || (pessoa.Sexo.ToString().Trim() == null))
                Checar = false;
            else if ((pessoa.Profissao.NomeProfissao.Trim() == "") || (pessoa.Profissao.NomeProfissao.Trim() == null))
                Checar = false;
            else if ((pessoa.Profissao.QuantAnosParaAposentar.ToString().Trim() == "")
            || (pessoa.Profissao.QuantAnosParaAposentar.ToString().Trim() == null))
                Checar = false;
            else if ((pessoa.Profissao.Salario.ToString().Trim() == "")
            || (pessoa.Profissao.Salario.ToString().Trim() == null))
                Checar = false;
            else
                Checar = true;

            return Checar;
        }

        public bool ValidarLength (Pessoa pessoa)
        {
            bool Checar = true;

            if (pessoa.Nome.Length > 15)
                Checar = false;
            else if (pessoa.Idade > 113)
                Checar = false;
            else if (pessoa.Sexo.Length > 10)
                Checar = false;
            else if (pessoa.Profissao.NomeProfissao.Length > 20)
                Checar = false;
            else if (pessoa.Profissao.QuantAnosParaAposentar > 99)
                Checar = false;
            else if (pessoa.Profissao.Salario > 100000)
                Checar = false;
            else
                Checar = true;

            return Checar;
        }
    }
}
