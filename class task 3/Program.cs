using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace class_task_3
{
    internal class Program
    {
        struct Supershop
        {
            public string PName;
            public string Type;
            public int Price;  
            public void setData()
            {
                Console.Write("PName : ");
                 PName = Console.ReadLine();
                Console.Write("Type : ");
                Type = Console.ReadLine();
                Console.Write("Price : ");
                Price = Convert.ToInt32(Console.ReadLine());
            }

            public void getData()
            {
                Console.WriteLine(PName + "\t" + Type + "\t" + Price);
            }
        }

        static void Main(string[] args)
        {
            Supershop[] s = new Supershop[40];

            int pc = 10;
            s[0] = new Supershop { PName = "Soap", Type = "Ts", Price = 50 };
            s[1] = new Supershop { PName = "Sham", Type = "To", Price = 16 };
            s[2] = new Supershop { PName = "Ri", Type = "Gr", Price = 65 };
            s[3] = new Supershop { PName = "Ol", Type = "G", Price = 180 };
            s[4] = new Supershop { PName = "Br", Type = "B", Price = 35 };
            s[5] = new Supershop { PName = "Bu", Type = "D", Price = 90 };
            s[6] = new Supershop { PName = "M", Type = "D", Price = 70 };
            s[7] = new Supershop { PName = "Pn", Type = "S", Price = 15 };
            s[8] = new Supershop { PName = "N", Type = "St", Price = 60 };
            s[9] = new Supershop { PName = "J", Type = "Be", Price = 100 };

            Console.WriteLine("Add Product ------------ press 1");
            Console.WriteLine("Show Product -------- press 2");
            Console.WriteLine("Delete Product --------- press 3");
            Console.WriteLine("Exit Application --------- press 0");

            bool r = true;
            while (r)
            {
                Console.Write("Enter choice: ");
                int c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 0:
                        Console.WriteLine("Exit");
                        r = false;
                        break;

                    case 1:
                        Console.Write("Enter how many products to add: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            s[pc].setData();
                            pc++;
                        }
                        break;

                    case 2:
                        if (pc == 0)
                        {
                            Console.WriteLine("Empty List");
                        }
                        else
                        {
                            Console.WriteLine("\nPName\tType\tPrice");
                            for (int i = 0; i < pc; i++)
                            {
                                s[i].getData();
                            }
                        }
                        break;

                    case 3:
                        Console.Write("Enter the product name to delete: ");
                        string name = Console.ReadLine();
                        int index = -1;

                        for (int i = 0; i < pc; i++)
                        {
                            if (s[i].PName ==name )
                            {
                                index = i;
                                break;
                            }
                        }

                        if (index == -1)
                        {
                            Console.WriteLine("Not Found");
                        }
                        else
                        {
                            Console.WriteLine("Deleting: ");
                            s[index].getData();

                            for (int i = index; i < pc - 1; i++)
                            {
                                s[i] = s[i + 1];
                            }

                            pc--;
                            Console.WriteLine("Deleted");
                        }
                        break;
                       
                }
            }
        }
    }
}
