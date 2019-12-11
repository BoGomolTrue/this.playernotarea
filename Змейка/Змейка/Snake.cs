using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Змейка
{
    class Snake : GameObject
    {
        public int speed = 1;

        //вызываем конструктор и назначаем цвет змейки
        public Snake()
        {
            my_Color = Color.Green;
        }
        public void Add(Point a)
        {
            body.Add(a);
        }
    }
}