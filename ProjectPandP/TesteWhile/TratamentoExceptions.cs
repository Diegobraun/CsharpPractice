using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWhile
{
    class TratamentoExceptions
    {
        public void ConvertInt(string obj)
        {
            try
            {
                Convert.ToInt32(obj.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void NullPointerExceptionPessoa (Pessoa obj)
        {
            try
            {
                Console.WriteLine(obj);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Valor de variável null");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Valor de argumento null");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void NullPointerExceptionProfissao (Profissao obj)
        {
            try
            {
                Console.WriteLine(obj);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Valor de variável null");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Valor de argumento null");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
