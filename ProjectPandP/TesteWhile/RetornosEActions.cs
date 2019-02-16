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

        public void Excluir (int index)
        {
            var Pessoa = pessoa.Where(p => p.Id == index);
            pessoa.Remove(Pessoa.FirstOrDefault());
        }

        public Pessoa ReturnPessoa (int index)
        {
            var Pessoa = pessoa.Where(p => p.Id == index);
            return Pessoa.FirstOrDefault();
        }


        public Pessoa ReturnPessoa (string nome)
        {
            var Pessoa = pessoa.Where(p => p.Nome.Contains(nome));
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

        public void ExibirPessoas()
        {
            Pessoa pes;
            for (int i = 0; i < pessoa.Count; i++)
            {
                pes = pessoa[i];
                Console.WriteLine($"Id: {pes.Id} \n Nome: {pes.Nome} \n {pes.Idade} \n {pes.Sexo}");

            }
        }
    }
}
