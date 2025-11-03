using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure_i
{
    struct Student
    {
        public int Id;
        public string Name;

        public void setData()
        {
            Console.Write("Student ID: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Student Name: ");
            Name = Console.ReadLine();
        }

        public void getData()
        {
            Console.WriteLine(Id + "\t" + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[40];

            bool d = true;
            int c;
            int sC = 0;

            Console.WriteLine("Add A Student ------------ press 1");
            Console.WriteLine("Show all Students -------- press 2");
            Console.WriteLine("Delete A Student --------- press 3");
            Console.WriteLine("Exit Application --------- press 0");

            while (d)
            {
                Console.Write("Enter your choice: ");
                c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 0:
                        Console.WriteLine("Exiting the app!!");
                        d = false;
                        break;
                    case 1:
                        Console.Write("Enter how many: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            s[sC].setData();
                            sC++;
                        }
                        break;
                    case 2:
                        if (sC == 0)
                        {
                            Console.WriteLine("Empty List!!");
                        }
                        for (int i = 0; i < sC; i++)
                        {
                            s[i].getData();
                        }
                        break;
                    case 3:
                        Console.Write("Enter the id you want to delete: ");
                        int m = Convert.ToInt32(Console.ReadLine());
                        int id = -1;
                        for (int i = 0; i < sC; i++)
                        {
                            if (s[i].Id == m)
                            {
                                id = i;
                                Console.Write("Deleting ");
                                s[i].getData();
                            }
                        }
                        if (id == -1)
                        {
                            Console.WriteLine("Invalid ID!!");
                        }
                        else
                        {
                            for (int i = id; i < sC; i++)
                            {
                                s[i] = s[i + 1];
                            }
                            sC--;
                        }
                        break;
                }
            }
        }
    }
}