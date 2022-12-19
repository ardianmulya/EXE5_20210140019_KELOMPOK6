using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140019_KELOMPOK6
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node ardian, windarwan;
        public queue()
        {
            ardian = null;
            windarwan = null;
        }

        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (ardian == null)
            {
                ardian = newnode;
                windarwan= newnode;
                return;
            }
            windarwan.next = newnode;
            windarwan = newnode;
        }
        public void delete()
        {
            if (ardian == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            ardian = ardian.next;
            if (ardian == null)
                windarwan = null;
        }
        public void display()
        {
            Node display;
            for (display = ardian; display != null; display =display.next)
                Console.WriteLine(display.name);
        }
        
    }
     class Program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
