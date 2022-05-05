using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterF
{
    interface iBuilder
    {
        string Name { get; set; }
        House Build();
        bool Check(House h);

    }
    class Builder : House, iBuilder
    {
        public string Name { get; set; }

        public House Build()
        {
            return base.Building();
        }
        public bool Check(House h)
        {
            Console.WriteLine("\nОбычный строитель не может заниматься сдачей проэкта\n");
            return false;
        }
    }
    class Leader : House, iBuilder
    {
        public string Name { get; set; }

        public House Build()
        {
            Console.WriteLine("\nНачальник не может заниматься строительством дома\n");
            return null;
        }
        public bool Check(House h)
        {
            return base.FinishH(h);

        }
    }
    class Team
    {
        iBuilder b = new Builder() { Name = "Строитель Жора" };
        iBuilder l = new Leader() { Name = "Прораб Инокентий" };
        House house = new House();

        public void Start()
        {
            this.house = b.Build();
        }
        public bool Finish()

        {
            return l.Check(house);
        }

    }
}
