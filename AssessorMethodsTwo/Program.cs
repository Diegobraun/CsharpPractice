using System;

namespace AssessorMethodsTwo
{
    public class MensalidadeNegativaException : Exception{
        public MensalidadeNegativaException (string message) : base (message){

        }
    }
    public enum TipoAluno{
        Regular,Especial
    }
    public class  Aluno
    {

        private int _matricula;
        public int Matricula{
            get{ return _matricula; }
            set { _matricula = value; }
        }

        public string Nome { get => _nome; set => _nome = value; }
        public double Mensalidade { get {
            return _mensalidade;
        } set {
            if (value < 0){
                throw new MensalidadeNegativaException("Valor inválido! ");
            }else{
                _mensalidade = value;
            }
        }   
        }
        public TipoAluno Tipo { get => _tipo; set => _tipo = value; }

        private string _nome;
        private double _mensalidade;
        private TipoAluno _tipo;
    }
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Aluno a = new Aluno();
                a.Matricula = 123;
                a.Nome = "Diego";
                a.Mensalidade = 500;
                a.Tipo = TipoAluno.Regular;
            }catch(MensalidadeNegativaException e){
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
