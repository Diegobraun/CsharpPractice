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
            if (CheckValuesIsNull(pessoa.Nome))
                return false;
            else if (CheckValuesIsNull(pessoa.Idade.ToString()))
                return false;
            else if (CheckValuesIsNull(pessoa.Sexo))
                return false;
            else if (CheckValuesIsNull(pessoa.Profissao.NomeProfissao))
                return false;
            else if (CheckValuesIsNull(pessoa.Profissao.QuantAnosParaAposentar.ToString()))
                return false;
            else if (CheckValuesIsNull(pessoa.Profissao.Salario.ToString()))
                return false;
            else
                return true;
        }

        public bool ValidarLength (Pessoa pessoa)
        { 
            if (pessoa.Nome.Length > 15)
                return false;
            else if (pessoa.Idade > 113)
                return false;
            else if (pessoa.Sexo.Length > 10)
                return false;
            else if (pessoa.Profissao.NomeProfissao.Length > 20)
                return false;
            else if (pessoa.Profissao.QuantAnosParaAposentar > 99)
                return false;
            else if (pessoa.Profissao.Salario > 100000)
                return false;
            else
                return true;
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
