using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWhile
{
    public class Principal
    {
        public static void Main(string[] args)
        {

            RetornosEActions retornar = new RetornosEActions();
            bool loop = true;

            while (loop == true)
            {
                Menu();
                string Escolha = Console.ReadLine();


                switch (Escolha)
                {
                    case "1":
                        Console.Clear();
                        Adicionar(retornar);
                        break;
                    case "2":
                        Console.Clear();
                        SelectAll(retornar);
                        break;
                    case "3":
                        Console.Clear();
                        SelectSpecific(retornar);
                        break;
                    case "4":
                        Console.Clear();
                        Delete(retornar);
                        break;
                    case "5":
                        loop = Close();
                        break;
                    default:
                        InvalidValue();
                        break;

                }
            }

        }

        private static void InvalidValue()
        {
            Console.WriteLine("Valor inválido!");
        }

        public static bool Close()
        {
            Console.WriteLine("Saindo");
            return false;
        }

        private static void Delete(RetornosEActions retornar)
        {
            retornar.ExibirPessoas();

            Console.WriteLine("Qual pessoa deseja apagar? ");
            string Index = Console.ReadLine();
            
            if (retornar.ReturnPessoa(Index) == null)
            {
                Console.WriteLine("Pessoa não encontrada!");
            }
            else
            {
                retornar.Excluir(Index);
            }


        }

        private static void SelectSpecific(RetornosEActions retornar)
        {
            retornar.ExibirPessoas();

            Console.WriteLine("Qual pessoa deseja ver detalhadamente? (Pesquise pelo Identificador)");
            string value = Console.ReadLine();

            Pessoa Retorno;

            
            if (retornar.ReturnPessoa((value)) != null)
            {
                Retorno = retornar.ReturnPessoa((value));
                retornar.ExibirPessoaSingular(Retorno);
            }

            else
            {
                Console.WriteLine("Pessoa não encontrada!");
            }


        }

        private static void SelectAll(RetornosEActions retornar)
        {
            retornar.ExibirPessoas();
        }

        private static void Adicionar(RetornosEActions retornar)
        {
            Console.WriteLine("Digite o nome da pessoa: ");
            string Nome_Pessoa = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa: ");
            string Idade_String = Console.ReadLine();
            int Idade_Aux,Idade_Pessoa;

            if (int.TryParse(Idade_String, out Idade_Aux))
                Idade_Pessoa = Idade_Aux;
            else
                Idade_Pessoa = 18;

            Console.WriteLine("Digite o sexo da pessoa: ");
            string Sexo_Pessoa = Console.ReadLine();

            Console.WriteLine("Digite a profissão que a pessoa exerce: ");
            string Nome_Profissao = Console.ReadLine();


            Console.WriteLine("Digite o salário dessa profissão: ");
            string Salario_String = Console.ReadLine();
            double Salario_Profissao,Salario_Aux;

            if (double.TryParse(Salario_String, out Salario_Aux))
                Salario_Profissao = Salario_Aux;
            else
            {
                Salario_Profissao = 994;
            }

            Console.WriteLine("Digite a quantidade de anos restante até a aposentadoria: ");
            string QuantAnosParaAposentadoria_Profissao_String = Console.ReadLine();
            int QuantAnosParaAposentadoria_Profissao,QuantAnosParaAposentadoria_Profissao_Aux;

            if (int.TryParse(QuantAnosParaAposentadoria_Profissao_String, out QuantAnosParaAposentadoria_Profissao_Aux))
                QuantAnosParaAposentadoria_Profissao = QuantAnosParaAposentadoria_Profissao_Aux;
            else
            {
                QuantAnosParaAposentadoria_Profissao = 30;
            }


            int Identifier = 0;

            if (retornar.CheckIfListIsNull())
            {
                Identifier = 1;
            }
            else
            {
                Identifier = retornar.GetLast() + 1;
            }
            Profissao profissao = new Profissao(Nome_Profissao, Salario_Profissao, QuantAnosParaAposentadoria_Profissao);
            Pessoa pessoa = new Pessoa(Identifier, Nome_Pessoa, Idade_Pessoa, Sexo_Pessoa, profissao);
        
            Validacoes validar = new Validacoes();


            if (validar.ValidarAll(pessoa))
            {
                retornar.Adicionar(pessoa);
                Console.Clear();
            }
            else
                Console.WriteLine("Algum erro aconteceu! Contate o administrador!");
        }

        private static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Salvar");
            Console.WriteLine("2 - Selecionar");
            Console.WriteLine("3 - Selecionar específico");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Digite a opção desejada: ");
        }
    }
}
    

