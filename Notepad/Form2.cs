using Notepad.Prototype;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Notepad.Prototype.Rectangle;

namespace Notepad
{
    public partial class Form2 : Form
    {
        List<PrototypeShape> shapes = new List<PrototypeShape>();        
        private bool isDrawing = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void test()
        {
            ArrayList shapes = new ArrayList();
            ArrayList shapesCopy = new ArrayList();
            //List<Shape> shapes = new ArrayList<>();
            //List<Shape> shapesCopy = new ArrayList<>();

            Circle circle = new Circle();
            circle.x = 10;
            circle.y = 20;
            circle.radius = 15;
            circle.color = "red";
            shapes.Add(circle);

            // Dễ dàng có thể tạo ra một object clone mới, không duplicate source, source đẹp rõ ràng
            Circle anotherCircle = (Circle)circle.clone();
            shapes.Add(anotherCircle);

            Rectangle rectangle = new Rectangle();
            rectangle.width = 10;
            rectangle.height = 20;
            rectangle.color = "blue";
            shapes.Add(rectangle);

            //cloneAndCompare(shapes, shapesCopy);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ArrayList shapes = new ArrayList();
            Rectangle rectangle = new Rectangle();
            rectangle.width = 10;
            rectangle.height = 20;
            rectangle.color = "blue";
            shapes.Add(rectangle);

            //Rectangle rectangle1 = new Rectangle();
            //rectangle1.A = new Point(200, 220);
            //rectangle1.B = new Point(250, 220);
            //rectangle1.C = new Point(215, 185);
            //rectangle1.D = new Point(215, 185);
            //rectangle1.draw(e.Graphics);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;                      
            Invalidate();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.A = e.Location;
            rectangle.B = new Point(rectangle.A.X + 50, rectangle.A.Y + 80);
            
            Invalidate();
        }
    }
}
