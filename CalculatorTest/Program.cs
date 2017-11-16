using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Unesi prvi broj:");
            int operand1 = Int32.Parse (Console.ReadLine());

            Console.WriteLine("Unesi drugi broj:");
            int operand2 = Int32.Parse(Console.ReadLine());
            Calculator c = new Calculator(operand1, operand2);
            c.WriteOperands();

            Console.WriteLine("Sabiranje");
            string sabiranje = c.WriteNumber(c.saberi());
            Console.WriteLine(sabiranje);
            Console.ReadLine();

            Console.WriteLine("Oduzimanje");
            string oduzimanje = c.WriteNumber(c.oduzmi());
            Console.WriteLine(oduzimanje);
            Console.ReadLine();

            Console.WriteLine("Pomnozi");
            string mnozenje = c.WriteNumber(c.pomnozi());
            Console.WriteLine(mnozenje);
            Console.ReadLine();

            Console.WriteLine("Podijeli");
            string dijeljenje = c.WriteNumber(c.dijeli());
            Console.WriteLine(dijeljenje);
            Console.ReadLine();

            Console.WriteLine("Povrsina kruga");
            string povrsina = c.WriteNumber(c.povrsina_kruga());
            Console.WriteLine(povrsina);
            Console.ReadLine();



        }
    }
}
