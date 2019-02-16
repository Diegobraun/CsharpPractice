using System;
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
            var Pessoa = pessoa.Where(p => p.Nome.Equals(nome));
            return Pessoa.FirstOrDefault();
        }
        
        public int GetLast()
        {
            var index = pessoa.OrderByDescending(p => p.Id).FirstOrDefault();
            return Convert.ToInt32(index);
        }

        public void ExibirPessoas()
        {
            for (int i = 0; i > pessoa.Count; i++)
            {
                Pessoa pes = ReturnPessoa(i);
                Console.WriteLine($"Id: {pes.Id} \n Nome: {pes.Nome} \n {pes.Idade} \n {pes.Sexo}");

            }
        }
    }
}
