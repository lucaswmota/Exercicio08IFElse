using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08IFElse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Informe o valor da compra: ");
                double compra = double.Parse(Console.ReadLine());

                if (compra > 0)
                {
                    Console.WriteLine("Informe a forma de pagamento usando umas das opções abaixo: " +
                                  "\n(1) Dinheiro" +
                                  "\n(2) Cartão" +
                                  "\n(3) Cheque");
                    int formaPagamento = int.Parse(Console.ReadLine());

                    if (formaPagamento==1)
                    {
                        compra -= compra * 0.10;
                        Console.WriteLine("O Valor da compra com 10% de desconto por pagamento em dinheiro é de: " + compra.ToString("C"));
                    }
                    else if (formaPagamento==2)
                    {
                        compra -= compra * 0.075;
                        Console.WriteLine("O Valor da compra com 7,5% de desconto por pagamento em Cartão é de: " + compra.ToString("C"));
                    }
                    else if (formaPagamento==3)
                    {
                        compra -= compra * 0.05;
                        Console.WriteLine("O Valor da compra com 5% de desconto por pagamento em Cheque é de: " + compra.ToString("C"));
                    }
                    else
                    {
                        Console.WriteLine("Informe a forma de pagamento usando umas das opções abaixo: " +
                                   "\n(1) Dinheiro" +
                                   "\n(2) Cartão" +
                                   "\n(3) Cheque");
                    }

                }
                else
                {
                    Console.WriteLine("O Valor da compra deve ser maior do que 0 (Zero)" +
                                        "\nPrograma Encerrado.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Insira apenas numeros.");
            }
            catch(Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            finally
            {
                Console.WriteLine("Programa Encerrado");
                Console.ReadKey();
            }



        }
    }
}
