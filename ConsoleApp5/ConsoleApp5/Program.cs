using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Myclass
{
    class Program
    {
        public static void Main(string[] args)
        {
            MDT Homework = new MDT();
            Homework.Name = "Media Trade";
            Homework.Number = "7124574235102";
            Homework.OwnerName = "Jame Goldgood";
            Homework.Value = 1000000;

            PrintCarInformation(Homework);
        }
            static void PrintCarInformation(MDT Shop)
            {
                Console.WriteLine("Name: {0}", Shop.Name);
                Console.WriteLine("Registered Value: {0}", Shop.Number);
                Console.WriteLine("Number: {0}", Shop.OwnerName);
                Console.WriteLine("Owner Name: {0}", Shop.Value);
                Console.ReadLine();
            }
        }
            public class MDT
    {
            public string Name;
            public string Number;
            public string OwnerName;
            public int Value;
            }
        }
    


