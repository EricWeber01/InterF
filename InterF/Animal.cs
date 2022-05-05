using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterF
{
    interface iVictim
    {
        string Name { get; set; }
        void SetV();
        void Run(Animal p);
    }
    interface iPredator
    {
        string Name { get; set; }
        void SetP();
        void Kill(Animal p);
    }
    interface iHubrid : iPredator, iVictim
    {
        new string Name { get; set; }
        void KillThemAll(Animal p);
    }
    class Animal : iHubrid
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Wight { get; set; }
        protected string type;
        public Animal(string _n, string _c, int _w)
        {
            Name = _n;
            Color = _c;
            Wight = _w;

        }
        public void Run(Animal p)
        {
            if (p.type == "victim")
                Console.WriteLine("*Урон игроков равен нулю - попробуйте выбрать другую фракцию*\n(Victim VS. Victim)\n");
            else
                Console.WriteLine($"{this.Name} убегает от {p.Name}\n");
        }
        public void Kill(Animal p)
        {
            if (p.type == "predator")
                Console.WriteLine("*Вы не можете атаковать игроков из своей фракции*\n(Predator VS. Predator)\n");
            else
                Console.WriteLine($"{this.Name} хочет сьесть {p.Name}\n");
        }
        public void KillThemAll(Animal p)
        {
            Console.WriteLine($"{this.Name} хочет сьесть {p.Name}\n");
        }
        public void SetP()
        {
            type = "predator";
        }
        public void SetV()
        {
            type = "victim";
        }
    }
}