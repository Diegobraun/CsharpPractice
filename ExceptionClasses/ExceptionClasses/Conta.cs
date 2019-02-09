using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionClasses
{
    public class Conta
    {
        private double _saldo = 0;
        private const double LIMITE = 500;

        public void Depositar(double valor)
        {
            _saldo = _saldo + valor;
        }
        public void Sacar(double valor)
        {
            if (valor > LIMITE + _saldo)
                throw new SaldoInsuficienteException("Saldo insuficiente!");
                _saldo = _saldo - valor;
        }

        public double GetSaldo()
        {
            return _saldo;
        }
    }

    [Serializable]
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SaldoInsuficienteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
