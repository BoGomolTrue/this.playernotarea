using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Змейка
{
    class Blok:GameObject
    {
        public Blok()
        {
            my_Color = Color.Purple;
        }
        public void Add(Point a)
        {
            body.Add(a);
        }
    }
}
