using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWhile
{
    public class Validacoes
    {
        public bool CheckValuesIsNull (string content)
        {
            if (string.IsNullOrEmpty(content.Trim()))
                return true;
            else
                return false;
        }

        public bool ValidarNull (Pessoa pessoa)
        {
            bool Checar = true;
            if (CheckValuesIsNull(pessoa.Nome))
                Checar = false;
            else if (CheckValuesIsNull(pessoa.Idade.ToString()))
                Checar = false;
            else if (CheckValuesIsNull(pessoa.Sexo))
                Checar = false;
            else if (CheckValuesIsNull(pessoa.Profissao.NomeProfissao))
                Checar = false;
            else if (CheckValuesIsNull(pessoa.Profissao.QuantAnosParaAposentar.ToString()))
                Checar = false;
            else if (CheckValuesIsNull(pessoa.Profissao.Salario.ToString()))
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

        public bool ValidarAll (Pessoa pessoa)
        {
            if ((ValidarLength(pessoa)) && (ValidarNull(pessoa)))
                return true;
            else
                return false;
        }
    }
}
