using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public abstract class Leaf
    {
        public Image img;
     
        //Возращает строку для текстоволго поля
        public abstract string getHint(int n);

        //Расчёт ассимметрии листа
        public abstract double assim();

        //прорисовка линий
        public abstract bool draw(Image image, int pnum, MouseEventArgs e);

        //Нахождение точки пересечения
        public int Crossing(Point p1, Point p2, Point p3, Point p4)
        {
            double x = p1.X + ((p2.X - p1.X) * (p3.Y - p1.Y)) / (p2.Y - p1.Y);
            return (int)x;
        }

        public abstract int getNumberOfAttributes();
        public abstract string getNameOfAttribute(int number=0);

        //Сериализация параметров
        public abstract byte[] getParams();

        //Возврат параметров.
        public abstract double getAttributeValues(int number=0, int side=0);

        //Десериализация параметров
        public abstract void setParams(MemoryStream ms);
        

        public abstract void drawInitLine(Image image);


        public abstract double assim (DataGridView q);

        public abstract void rotateImage();

        public abstract void setP2(System.Drawing.Point p);
        

        public void rotateImage(ref Point p0, ref Point p1, ref Point p2)
        {
            double angle = Math.Atan2(((double)p2.X - (double)p0.X) , ((double)p2.Y - (double)p0.Y));
            p0 = new Point((int)(p1.X + (p0.X - p1.X) * Math.Cos(angle) - (p0.Y - p1.Y) * Math.Sin(angle)), (int)(p1.Y + (p0.Y - p1.Y) * Math.Cos(angle) + (p0.X - p1.X) * Math.Sin(angle)));
            p2 = new Point((int)(p1.X + (p2.X - p1.X) * Math.Cos(angle) - (p2.Y - p1.Y) * Math.Sin(angle)), (int)(p1.Y + (p2.Y - p1.Y) * Math.Cos(angle) + (p2.X - p1.X) * Math.Sin(angle)));
            Bitmap returnBitmap = new Bitmap(img.Width, img.Height);
            Graphics g = Graphics.FromImage(returnBitmap);
            g.TranslateTransform(p1.X, p1.Y);
            g.RotateTransform(Convert.ToSingle(angle*(180/Math.PI)));
            g.TranslateTransform(-p1.X, -p1.Y);
            g.DrawImage(img, new Point(0, 0));
            img = returnBitmap;
        }
      
        
//        public struct Params
//        {}
//        public Object p;
        
    }
}
