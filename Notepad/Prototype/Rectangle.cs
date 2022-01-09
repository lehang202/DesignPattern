using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Prototype
{
    public class Rectangle : PrototypeShape
    {
        public int width;
        public int height;
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(Rectangle target) : base(target)
        {
            if (target != null)
            {
                this.width = target.width;
                this.height = target.height;
            }
        }
        public override void draw(Graphics g)
        {
            
            g.DrawLine(new Pen(Color.Red), A, B);
            g.DrawLine(new Pen(Color.Red), B, C);
            g.DrawLine(new Pen(Color.Red), C, D);
            g.DrawLine(new Pen(Color.Red), A, D);
        }

        override
        public PrototypeShape clone()
        {
            return new Rectangle(this);
        }

        //public boolean equals(Object object2)
        //    {
        //        if (!(object2 instanceof Rectangle) || !super.equals(object2)) return false;
        //        Rectangle shape2 = (Rectangle)object2;
        //        return shape2.width == width && shape2.height == height;
        //    }
        //}
    }
}
