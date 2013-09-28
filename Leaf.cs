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

        //Сериализация параметров
        public abstract byte[] getParams();

        //Десериализация параметров
        public abstract void setParams(MemoryStream ms);


        public abstract void drawInitLine(Image image);


        public abstract double assim (DataGridView q);

      
        
//        public struct Params
//        {}
//        public Object p;
        
    }
}
