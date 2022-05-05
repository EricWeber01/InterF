using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterF
{
    interface iClient
    {
        string Name { get; set; }
    }
    interface iAccount : iClient
    {
        void Add(int b);
        void Show();
    }
    public class Client : iAccount
    {
        public string Name { get; set; }
        public int Ballance { get; set; }
        public Client()
        {
            Ballance = 0;
        }
        public void Add(int b)
        {
            Ballance += b;
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name} | Ballance: {Ballance}");
        }
    }
}