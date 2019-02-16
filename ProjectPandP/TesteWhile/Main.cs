using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWhile
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Salvar");
            Console.WriteLine("2 - Selecionar");
            Console.WriteLine("3 - Selecionar específico");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("5 - Sair");

            int Escolha = Convert.ToInt32(Console.ReadLine());
            RetornosEActions retornar;

            switch (Escolha)
            {
                case 1:
                    Console.WriteLine("Digite o nome da pessoa: ");
                    string Nome_Pessoa = Console.ReadLine();
                    Console.WriteLine("Digite a idade da pessoa: ");
                    int Idade_Pessoa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o sexo da pessoa: ");
                    string Sexo_Pessoa = Console.ReadLine();
                    Console.WriteLine("Digite a profissão que a pessoa exerce: ");
                    string Nome_Profissao = Console.ReadLine();
                    Console.WriteLine("Digite o salário dessa profissão: ");
                    double Salario_Profissao = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de anos restante até a aposentadoria: ");
                    int QuantAnosParaAposentadoria_Profissao = Convert.ToInt32(Console.ReadLine());

                    Profissao profissao = new Profissao(Nome_Profissao, Salario_Profissao, QuantAnosParaAposentadoria_Profissao);
                    Pessoa pessoa = new Pessoa(Nome_Pessoa, Idade_Pessoa, Sexo_Pessoa, profissao);

                    Validacoes validar = new Validacoes();
                    retornar = new RetornosEActions();

                    if (validar.ValidarAll(pessoa))
                        retornar.Adicionar(pessoa);

                    retornar.ExibirPessoas();
                    break;
                case 2:
                    retornar = new RetornosEActions();
                    retornar.ExibirPessoas();
                    break;
                case 3:
                    retornar = new RetornosEActions();
                    retornar.ExibirPessoas();
                    Console.WriteLine("Qual pessoa deseja ver detalhadamente? Você pode filtrar por identificador ou nome");
                    string value = Console.ReadLine();
                    if (retornar.ReturnPessoa(value) == null)
                    {
                        retornar.ReturnPessoa(Convert.ToInt32(value));
                    }
                    break;
                case 4:
                    retornar = new RetornosEActions();
                    retornar.ExibirPessoas();
                    Console.WriteLine("Qual pessoa deseja apagar? ");
                    int Index = Convert.ToInt32(Console.ReadLine());
                    if (retornar.ReturnPessoa(Index) == null)
                    {
                        Console.WriteLine("Pessoa não encontrada!");
                    }
                    else
                    {
                        retornar.Excluir(Index);
                    }
                    break;
                case 5:
                    Console.WriteLine("Saindo");
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }
            Console.ReadKey();


        }
    }
}
