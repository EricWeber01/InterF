using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterF
{
    interface iPart
    {
        string Type { get; set; }
        int Count { get; set; }
        bool Check();
        void Add();
    }
    interface iWorker
    {
        string Name { get; set; }
        void Build();
    }
    class Basement : iPart
    {
        public string Type { get; set; }
        public int Count { get; set; }
        public Basement()
        {
            Type = "Фундамент";
            Count = 0;
        }
        public void Add()
        {
            if (!Check())
                Count++;
        }
        public bool Check()
        {
            if (Count == 1)
                return true;
            else
                return false;
        }
    }
    class Wall : iPart
    {
        public string Type { get; set; }
        public int Count { get; set; }

        public Wall()
        {
            Type = "Стена";
            Count = 0;
        }
        public void Add()
        {
            if (!Check())
                Count++;
        }
        public bool Check()
        {
            if (Count == 4)
                return true;
            else
                return false;
        }
    }
    class Door : iPart
    {
        public string Type { get; set; }
        public int Count { get; set; }
        public Door()
        {
            Type = "Дверь";
            Count = 0;
        }
        public void Add()
        {
            if (!Check())
                Count++;
        }
        public bool Check()
        {
            if (Count == 1)
                return true;
            else
                return false;
        }
    }
    class Window : iPart
    {
        public string Type { get; set; }
        public int Count { get; set; }
        public Window()
        {
            Type = "Окно";
            Count = 0;
        }
        public void Add()
        {
            if (!Check())
                Count++;
        }
        public bool Check()
        {
            if (Count == 4)
                return true;
            else
                return false;
        }
    }
    class Roof : iPart
    {
        public string Type { get; set; }
        public int Count { get; set; }

        public Roof()
        {
            Type = "Крыша";
            Count = 0;
        }
        public void Add()
        {
            if (!Check())
                Count++;
        }
        public bool Check()
        {
            if (Count == 4)
                return true;
            else
                return false;
        }
    }
    class House
    {
        public iPart[] parts = { new Basement(), new Wall(), new Door(), new Window(), new Roof() };
        public House Building()
        {
            foreach (var p in parts)
            {
                if (p.Check() != true)
                {
                    p.Add();
                    Console.WriteLine("Идет строительство...");
                    Thread.Sleep(2000);
                    House house = this;
                    return house;

                }
            }
            House house1 = this;
            return house1;
        }
        public bool FinishH(House h)
        {
            foreach (var p in h.parts)
            {
                if (!p.Check())
                {
                    Console.WriteLine($"\nНедостаточно компонентов '{p.Type}'\n");
                    return false;
                }
            }
            Console.WriteLine("\nСтроительство окончено\n");
            return true;
        }
    }
}