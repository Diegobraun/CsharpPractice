using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWhile
{
    class RetornosEActions
    {
        List<Pessoa> pessoa = new List<Pessoa>();

        public void Adicionar (Pessoa pes)
        {
            pessoa.Add(pes);
        }

        public void Excluir (string index)
        {
            var Pessoa = pessoa.Where(p => p.Id.ToString() == index);
            pessoa.Remove(Pessoa.FirstOrDefault());
        }

        public Pessoa ReturnPessoa (string index)
        {
            var Pessoa = pessoa.Where(p => p.Id.ToString() == index);
            return Pessoa.FirstOrDefault();
        }

        
        public int GetLast()
        {
            if (CheckIfListIsNull())
            {
                return 1;
            }
            else
            {
                Pessoa index = pessoa.LastOrDefault();
                int indice = index.Id;
                return indice;
            }

        }

        public bool CheckIfListIsNull()
        {
            if (pessoa.Count < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ExibirPessoaSingular(Pessoa pessoa)
        {
            Console.WriteLine($"Id: {pessoa.Id} \n Nome: {pessoa.Nome} \n Idade: {pessoa.Idade} \n Sexo: {pessoa.Sexo} \n" +
            $"Profissão: {pessoa.Profissao.NomeProfissao}\n");
        }

        public void ExibirPessoas()
        {
            for (int i = 0; i < pessoa.Count; i++)
            {
                ExibirPessoaSingular(pessoa[i]);

            }
        }
    }
}
