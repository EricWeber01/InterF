using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterF
{
    interface iRepository
    {
        void Add(string n, int p, int c);
        void Del(int ind);
        void Edit(int ind, string n, int p, int c);
        void Find(string n);
        void Findex(int ind);
        void Show();


    }
    class Good
    {
        public string Name { get; set; }
        int Price;
        int Count;
        public Good(string n, int p, int c)
        {
            Name = n;
            Price = p;
            Count = c;
        }
        public void Show()
        {
            Console.WriteLine($"{Name} | {Price}$ | {Count}");
        }
    }
    class Repository : iRepository
    {
        Good[] g = new Good[0];

        public void Add(string n, int p, int c)
        {
            Array.Resize(ref g, g.Length + 1);
            g[g.Length - 1] = new Good(n, p, c);
        }
        public void Del(int ind)
        {
            if (ind >= 0 && ind < g.Length)
            {
                for (int i = ind; i < g.Length - 1; i++)
                {
                    g[i] = g[i + 1];
                }
                Array.Resize(ref g, g.Length - 1);
            }
            else
                Console.WriteLine("Indexation Error");
        }
        public void Edit(int ind, string n, int p, int c)
        {
            g[ind] = new Good(n, p, c);
        }
        public void Find(string n)
        {
            for (int i = 0; i < g.Length; i++)
            {
                if (g[i].Name.ToLower() == n.ToLower())
                {
                    g[i].Show();
                }
            }
        }

        public void Findex(int ind)
        {
            for (int i = 0; i < g.Length; i++)
            {
                if (i == ind)
                {
                    g[i].Show();
                }
            }
        }
        public void Show()
        {
            for (int i = 0; i < g.Length; i++)
            {
                g[i].Show();

            }
        }
    }
    class Shop
    {
        iRepository r = new Repository();
        public void Show()
        {
            r.Show();
        }
        public void Add(string n, int p, int c)
        {
            r.Add(n, p, c);
        }
        public void Del(int ind)
        {
            r.Del(ind);
        }
        public void Edit(int ind, string n, int p, int c)
        {
            r.Edit(ind, n, p, c);
        }
        public void Find(string n)
        {
            r.Find(n);
        }
        public void Findex(int ind)
        {
            r.Findex(ind);
        }
    }
}