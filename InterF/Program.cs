using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Лаба 1
            /*
            iAccount c = new Client() { Name = "John Doe" };
            c.Add(100);
            c.Show();
            Console.WriteLine();
            iVictim mouse = new Animal("Мышь", "Серый", 1);
            mouse.SetV();
            iVictim hare = new Animal("Кролик", "Белый", 2);
            hare.SetV();
            iPredator dog = new Animal("Собака", "Черный", 7);
            dog.SetP();
            iPredator cat = new Animal("Кот", "Рыжий", 4);
            cat.SetP();
            iHubrid bird = new Animal("Орёл", "Коричневый", 10);
            mouse.Run(cat as Animal);
            cat.Kill(mouse as Animal);
            bird.KillThemAll(dog as Animal);
            bird.KillThemAll(hare as Animal);*/
            // Лаба 2
            /*Shop shop = new Shop();
            shop.Add("имя_товара1", 100, 2);
            shop.Add("имя_товара2", 100, 2);
            shop.Add("имя_товара3", 100, 2);
            shop.Add("имя_товара4", 100, 2);
            shop.Add("имя_товара5", 100, 2);
            shop.Add("имя_товара6", 100, 2);
            shop.Show();
            Console.WriteLine("\n\n");
            shop.Del(1);
            shop.Find("ИМЯ_ТОВАРА3");
            Console.WriteLine("\n\n");
            shop.Edit(3, "новое_имя_товара", 200, 1);
            shop.Show();*/
            // ДЗ 1
            /*Team t = new Team();
            do
            {
                t.Start();
            } while (t.Finish() != true);*/
            // ДЗ 2
            for (int i = 0; i < 50; i++)
            {
                Warrior w = new Warrior() { Name = "Пупа" };
                Console.WriteLine(w);
            }
        }
    }
}
