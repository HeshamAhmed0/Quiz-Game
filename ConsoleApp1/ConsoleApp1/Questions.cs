using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Questions
    {
        private int? INTinput;
        public int? counter=0;
        public void  GetCounter()
        {
            Console.WriteLine($"Your Counter Is : {counter}");
        }
        public void Start()
        {
            Qestion01();
            Qestion02();
            Qestion03();
            Qestion04();
            Qestion05();
        }
        public void Repeat(int Result)
        {
            for (int i = 1; i < 3; i++)
            {
                Console.Write("Enter Correct Answer : ");
                INTinput = int.Parse(Console.ReadLine());
                if (INTinput == Result)
                {
                    Console.WriteLine("Your Answer Is Correct ");
                    counter++;
                    GetCounter();

                    continue;
                }
                
            }
        }
        public void Qestion01()
        {
            Console.Write("E01 =>>>  20 * 50 = ");
             INTinput =int.Parse(Console.ReadLine());
            if (INTinput != 1000)
            {
                Repeat(1000);
            }
            else
            {
                Console.WriteLine("Your Answer Is Correct ");
                counter++;
                GetCounter();

            }
            
        }

        public void Qestion02()
        {
            Console.Write("E01 =>>>  2000 * 10  + 400 = ");
            INTinput = int.Parse(Console.ReadLine());
            if (INTinput != 20400)
            {
                Repeat(20400);
            }
            else
            {
                Console.WriteLine("Your Answer Is Correct ");
                counter++;
                GetCounter();

            }
        } 
        public void Qestion03()
        {
            Console.Write("E01 =>>>  200 * 10  + 400 = ");
            INTinput = int.Parse(Console.ReadLine());
            if (INTinput != 2400)
            {
                Repeat(2400);
            }
            else
            {
                Console.WriteLine("Your Answer Is Correct ");
                counter++;
                GetCounter();

            }
        }
        public void Qestion04()
        {
            Console.WriteLine("Choose Famouse Football Player ");
            Console.WriteLine("1 : Mohamed Ramadan\n2 : Mohamed Salah\n3 : Mohamed Helmy");
            Console.Write("Your Answer : ");
            INTinput=int.Parse(Console.ReadLine());
            if (INTinput==2)
            {
                Console.WriteLine("Your Answer Correct");
                counter++;
                GetCounter();
            }
            else
            {
                Repeat(2);
            }
        }
        public void Qestion05() 
        {
            Console.WriteLine("            Choose");
            Console.WriteLine(".....Is The Food Of Rappit");
            Console.WriteLine("1 : Carrot. 2 : Rice. 3 : Tometo");
            INTinput =int.Parse(Console.ReadLine());
            if (INTinput==1)
            {
                Console.WriteLine("Your Answer Is Correct");
                counter++;
                GetCounter();
            }
            else
            {
                Repeat(1);
            }
        }
        public int GetScore()
        {
            return counter??0;
        }
    }
}
