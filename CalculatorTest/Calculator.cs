using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    class Calculator
    {
        public Calculator(int operand1, int operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;

        }

        public int operand1;
        public int operand2;
        const double pi = 3.14;
        public void WriteOperands()
        {
            Console.WriteLine("Operand 1: " + this.operand1 + " Operand 2: " + this.operand2);
        }

        public int saberi()
        {
            return this.operand1 + this.operand2;
        }

        public int oduzmi()
        {
            return this.operand1 - this.operand2;
        }

        public int pomnozi()
        {
            return this.operand1 * this.operand2;
        }

        public double dijeli()
        {
            return this.operand1 / this.operand2;
        }
        public string WriteText(string text)
        {
            return text;
        }

        public  string WriteNumber(double number)
        {
            return number.ToString();
        }

        public static int saberi(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public static int oduzmii(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        public static int pomnozi(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        public static double podijeli(int operand1, int operand2)
        {
            return operand1 / operand2;
        }

        public double povrsina_kruga()
        {
            return this.operand1 * this.operand1 * pi;
        }

    }   
}
