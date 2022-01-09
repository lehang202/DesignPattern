using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Prototype
{
    public class Circle : PrototypeShape
    {
        public int radius;

        public Circle()
        {
        }

        public Circle(Circle target) : base(target)
        {

            if (target != null)
            {
                this.radius = target.radius;
            }
        }
        // Method clone của Circle, trả về một object mới.
        // Từ khóa this mang ý nghĩa state của tất cả các variable sẽ được giữ nguyên

        override
        public PrototypeShape clone()
        {
            return new Circle(this);
        }

        public override void draw(Graphics g)
        {
            var r = (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
            var rect = new RectangleF(A.X - r, A.Y - r, r * 2, r * 2);
            g.DrawEllipse(new Pen(Color), rect);
        }


        //public Boolean equals(Object object2)
        //    {
        //        if (!(object2 instanceof Circle) || !super.equals(object2)) return false;
        //        Circle shape2 = (Circle)object2;
        //        return shape2.radius == radius;
        //    }
        //}
    }
}
