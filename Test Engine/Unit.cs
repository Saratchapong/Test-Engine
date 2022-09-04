using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Engine
{
    class Unit
    {
        public int speed;
        public string name;

        public Unit()
        {

        }

        public Unit(int speed, string name)
        {
            this.speed = speed;
            this.name = name;
        }

        public void showName()
        {
            Console.WriteLine("" + speed + "  " + name);
        }
    }
}
