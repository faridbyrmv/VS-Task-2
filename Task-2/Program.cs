using System.Runtime.CompilerServices;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
            { //Name Surname

                string name = " Ferid";
                string surname = "Bayramov";

                string fullname = name + " " + surname;

                Console.WriteLine(fullname);

            }

            { //Misal-1

                int num1, num2;

                Console.Write("");
                num1 = 15;

                Console.Write("");
                num2 = 20;

                int cem = num1 + num2;

                Console.WriteLine("Cavab:" + cem);


            }

            { //Misal-2

                int num1, num2;

                Console.Write("");
                num1 = 200;

                Console.Write("");
                num2 = 160;

                int cem = num1 - num2;

                Console.WriteLine("Cavab: " + cem);


            }

            { //Misal-3

                double num1, num2;

                Console.Write("");
                num1 = 4;

                Console.Write("");
                num2 = 5;

                double hasil = num1 * num2;


                double kvadrat = Math.Pow(hasil, 2);

                Console.WriteLine("Cavab: " + kvadrat);


            }

            { //Misal-4

                double num1, num2;

                Console.Write("");
                num1 = 18;

                Console.Write("");
                num2 = 5;

                double cavab = num1 / num2;

                double kvadrat = Math.Pow(cavab, 2);

                Console.WriteLine("Cavab: " + cavab);
                Console.WriteLine("Cavabin kvadrati :" + kvadrat);

            }
        }
        
       
    }
}