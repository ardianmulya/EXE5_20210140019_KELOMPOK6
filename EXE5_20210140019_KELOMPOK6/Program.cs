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
        }
    }
}
