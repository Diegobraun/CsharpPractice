using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEntity
{
    class Program
    {
        public static DbFusionContext db = new DbFusionContext();

        static void Main(string[] args)
        {
            

            Loja loja = new Loja
            {
                Nome = "Lojaaa"
            };

            Produto produto = new Produto
            {
                Descricao = "Amaciante",
                Loja = loja
            };

            db.Lojas.Add(loja);
            db.Produtos.Add(produto);

            db.SaveChanges();
            SelectLoja();
            Console.ReadKey();
        }
        public static void SelectLoja()
        {
            var sql = (from lo in db.Lojas join pr in db.Produtos on lo.LojaId equals pr.LojaId select new {
                NomeLoja = lo.Nome,
                NomeProduto = pr.Descricao
            }); 

            foreach (object l in sql)
            {
                Console.WriteLine(l);
            }
        }
    }
}
