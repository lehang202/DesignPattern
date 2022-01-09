using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Prototype
{
    public abstract class PrototypeShape
    {
        public int x;
        public int y;
        public String color;

        public Color Color { get; set; } = Color.Black;
        public Point A { get; set; }
        public Point B { get; set; }
        public abstract void draw(Graphics g);

        public PrototypeShape()
        {
        }

        public PrototypeShape(PrototypeShape target)
        {
            if (target != null)
            {
                this.x = target.x;
                this.y = target.y;
                this.color = target.color;
            }
        }        
        public abstract PrototypeShape clone();

        //public Boolean equals(Object object2)
        //    {
        //        if (!(object2.IsInstanceOfType(new Shape()))) 
        //            return false;
        //        Shape shape2 = (Shape)object2;
        //        return shape2.x == x && shape2.y == y && Objects.equals(shape2.color, color);
        //    }
        //}
    }
}
