using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spisak_na_slugiteli
{
    public class Employee
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Greshka!");
                    return;
                }
                else
                {
                    this.name = value;
                }


            }
        }
        private double zaplata;
        public double Zaplata
        {
            get
            {
                return zaplata;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Greshka!");
                    return;
                }
                this.zaplata = value;
            }
        }
        private string dlygnost;
        public string Dlagnost
        {
            get
            {
                return dlygnost;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Greshka!");
                    return;
                }
                dlygnost = value;

            }
        }
        private string otdel;


        public string Otdel
        {
            get
            {
                return otdel;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Greshka!");
                    return;
                }
                otdel = value;
            }
        }

        private string elPosha;


        public string ElPosha
        {
            get { return elPosha; }
            set
            {
                if (value == null || value == "")
                {
                    elPosha = "n/a";
                }
                else
                {
                    elPosha = value;
                }

            }
        }

        private int age;


        public int Age
        {
            get { return age; }
            set 
            { 
                if (value==null || value==0)
                {
                    age =-1;
                }
                //dopylnenie :)
                if (value<16)
                {
                    Console.WriteLine("Greshni godini");
                    return;
                }
                else
                {
                    age = value;
                }
                
            }
        }
        public void PrintMe()
        {
            Console.WriteLine($"imeto e {this.Name}");
            Console.WriteLine($"zaplatata e {this.Zaplata:f2}");
            //Console.WriteLine($"Otdela e {this.Otdel}");
            //Console.WriteLine($"Dlygnostta e {this.Dlagnost}");

            Console.WriteLine($"El. posha e {this.ElPosha}");
            Console.WriteLine($"Godinite sa {this.Age}");
        }
    }
}
