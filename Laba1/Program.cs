using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{

        class Program
        {
        
            class TestClass
            {
                
                public int a { get; set; }
                public int b { get; set; }

                
                public TestClass(int a, int b)
                {
                    this.a = a;
                    this.b = b;
                }

                
                public void PrintInfo() => Console.WriteLine($"Исходные значения => {a} и {b}");

                // Найти большее число
                public void FindMax() => Console.WriteLine(a > b ? $"{a} больше чем {b}" : $"{b} больше чем {a}");

                // Найти сумму чисел
                public void Sum() => Console.WriteLine($"{a} + {b} = {a + b}");

                // Поменять значение чисел
                public void ChangeNumbers()
                {
                    Console.WriteLine("Введите новые значения ->\nВведите a: ");
                    a = Convert.ToInt32(Console.ReadLine()); 

                    Console.WriteLine("Введите b:"); 
                    b = Convert.ToInt32(Console.ReadLine());
               
            }

            }
            static void Main()
            {
            Console.WriteLine("Ку-ку");
            TestClass Class = new TestClass(15, 10); 

                

                Class.PrintInfo();
                Class.FindMax();
                Class.Sum();
                Class.ChangeNumbers();
                Class.PrintInfo();
                

                Console.ReadLine();
            }
        }
    }
   