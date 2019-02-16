namespace TesteWhile
{
    public class Profissao
    {
        public string NomeProfissao { get; private set; }
        public double Salario { get; private set; }
        public int QuantAnosParaAposentar { get; private set; }

        public Profissao(string nomeProfissao, double salario,int quantAnosParaAposentar)
        {
            NomeProfissao = nomeProfissao;
            Salario = salario;
            QuantAnosParaAposentar = quantAnosParaAposentar;
        }

        public void setNomeProfissao (string nomeProfissao)
        {
            NomeProfissao = nomeProfissao;
        }

        public void setSalario (double salario)
        {
            Salario = salario;
        }

        public void setQuantAnosParaAposentar (int quantAnosParaAposentar)
        {
            QuantAnosParaAposentar = quantAnosParaAposentar;
        }
    }
}