using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc
{
    public class calc
    {
        public static int calculator(int num1, int num2, string op) {
            if (op == "+") {
                return num1 + num2;
            } else if (op == "-") {
                return num1 - num2;
            } else if (op == "*") {
                return num1 * num2;
            } else {
                return num1 / num2;
            }
        }

        public static string chooseOperator() {
            Console.WriteLine("What operation do you want to do: +, -, *, or /");
            string op = Console.ReadLine();
            if (op == "+" || op == "-" || op == "*" || op == "/"){
                return op;
            } else {
                Console.WriteLine("Not a valid operator");
                op = chooseOperator();
                return op;
            }
        }

        public static int chooseNumber() {
            int number;
            try {
                Console.WriteLine("Please choose a number: ");
                number = int.Parse(Console.ReadLine());
                return number;
            } catch (Exception) {
                Console.WriteLine("Not a valid number");
                number = chooseNumber();
                return number;
            }
        }

        public static void Main(string[] args)
        {
          int num1 = chooseNumber();
          int num2 = chooseNumber();
          string op = chooseOperator();
          int result = calculator(num1, num2, op);

          Console.WriteLine(num1 + " " + op + " " + num2 + " = " + result);
        }
    }
}
