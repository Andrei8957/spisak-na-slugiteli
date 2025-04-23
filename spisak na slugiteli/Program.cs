using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spisak_na_slugiteli
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> persons = new List<Employee>();
            Console.Write("kolko hora she razglegdame - ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                Employee emp = new Employee();//sazdawa se prazen slugitel//taka wikam employee klasa
                Console.Write("Wywedi ime - ");
                emp.Name = Console.ReadLine();
                Console.Write("Wywedi zaplatata - ");
                emp.Zaplata = double.Parse(Console.ReadLine());
                Console.Write("Wywedi dlagnost - ");
                emp.Dlagnost = Console.ReadLine();
                Console.Write("Wywedi otdel - ");
                emp.Otdel = Console.ReadLine();
                Console.Write("Wywedi El. posha - ");
                emp.ElPosha = Console.ReadLine();
                Console.Write("Wywedi godini - ");
                emp.Age = Console.ReadLine();
                Console.WriteLine("----------------------");
                persons.Add(emp);

            }
            //double zaplataMax = double.MinValue;
            //int mqstoNaPerson = 0;
            double MaxAvg = double.MinValue;

            string OtdelNaiVisokaZaplata = "";
            for (int i = 0; i < persons.Count; i++)
            {
                double suma = persons[i].Zaplata;
                int count = 1;
                string segashenOtdel;
                double avg = 0;
                for (int j = i + 1; j < persons.Count; j++)
                {
                    if (persons[i].Otdel == persons[j].Otdel)
                    {

                        suma +=persons[j].Zaplata;
                        count++;
                    }
                }

                avg = suma / count;



                if (avg > MaxAvg)
                {
                    MaxAvg = avg;
                    OtdelNaiVisokaZaplata = persons[i].Otdel;
                }



                //if (persons[i].Zaplata > zaplataMax)
                //{
                //    zaplataMax = persons[i].Zaplata;
                //     mqstoNaPerson = i;
                //}

            }

            Console.WriteLine($"otdela s nai-golqma zaplata e {OtdelNaiVisokaZaplata}");
            Console.WriteLine($"slugiteli ot otdel {OtdelNaiVisokaZaplata}");
            for (int i = 0; i < persons.Count; i++)
            {

                if (OtdelNaiVisokaZaplata == persons[i].Otdel)
                {
                    persons[i].PrintMe();
                    Console.WriteLine("-------------------");
                }

            }

            for (int i = 0; i < persons.Count - 1; i++)
            {
                for (int j = i + 1; j < persons.Count; j++)
                {
                    if (persons[i].Zaplata < persons[j].Zaplata)
                    {
                        Employee swap = persons[i];
                        persons[i] = persons[j];
                        persons[j] = swap;
                    }
                }
            }
            Console.WriteLine("Sled sled sortirane slugitelite sa: ");
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine($"{persons[i].Name}");
            }
            //for (int i = 0; i < persons.Count; i++)
            //{
            //    persons[i].PrintMe();
            //    Console.WriteLine("--------------------");
            //}
            //Popravih nqkoi nesha po zadachata i dobavih drugi nadqvam se taka da e po-dobre :)
        }
    }
}