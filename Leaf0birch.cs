using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing.Drawing2D;
using System.Windows;

namespace WindowsFormsApplication1
{
    public class Leaf0birch : Leaf
    {
        private Pen pen = new Pen(Color.Black);
        private Pen pen1 = new Pen(Color.Red, 2);
        [SerializableAttribute]
        public struct Params
        {
            public System.Drawing.Point p0;
            public System.Drawing.Point p1;
            public System.Drawing.Point p2;
            public System.Drawing.Point p3;
            public System.Drawing.Point p4;
            public System.Drawing.Point p5;
            public System.Drawing.Point p6;
            public System.Drawing.Point p7;
            public System.Drawing.Point p8;
            public System.Drawing.Point p9;
            public System.Drawing.Point p10;
            public int h;
            public int x0;
            public int x1;
            public int x2;
        }
        public Params p;

        // подсказки
        public override string getHint(int n)
        {
            switch (n)
            {
                case 0:
                    return ("Откройте изображение и последовательно отметьте на нём 11 точек в указанном порядке.");
                case 1:
                    return ("1. \n\nОтметьте центральную жилку свержу вниз тремя точками. \n\nОтметьте кончик листа");
                case 2:
                    return ("2. \n\nОтметьте центральную жилку свержу вниз тремя точками. \n\nОтметьте середину центральной жилки.");
                case 3:
                    return ("3. \n\nОтметьте центральную жилку свержу вниз тремя точками. \n\nОтметьте основание центральной жилки.");
                case 4:
                    return ("4. \n\nОтметьте левую первую жилку второго порядка двумя точками. \n\nОтметьте основание левой первой жилки второго порядка.");
                case 5:
                    return ("5. \n\nОтметьте левую первую жилку второго порядка двумя точками. \n\nОтметьте конец левой первой жилки второго порядка.");
                case 6:
                    return ("6. \n\nОтметьте правую первую жилку второго порядка двумя точками. \n\nОтметьте основание правой первой жилки второго порядка.");
                case 7:
                    return ("7. \n\nОтметьте правую первую жилку второго порядка двумя точками. \n\nОтметьте конец правой первой жилки второго порядка.");
                case 8:
                    return ("8. \n\nОтметьте левую вторую жилку второго порядка двумя точками. \n\nОтметьте основание левой второй жилки второго порядка.");
                case 9:
                    return ("9. \n\nОтметьте левую вторую жилку второго порядка двумя точками. \n\nОтметьте конец левой второй жилки второго порядка.");
                case 10:
                    return ("10. \n\nОтметьте правую вторую жилку второго порядка двумя точками. \n\nОтметьте основание правой второй жилки второго порядка.");
                case 11:
                    return ("11. \n\nОтметьте правую вторую жилку второго порядка двумя точками. \n\nОтметьте конец правой второй жилки второго порядка.");
                case 12:
                    return ("Для сохранения результатов нажмите \"Сохранить\". Для выхода без сохранения нажмите \"Отмена\". \n Степени флуктуирующей асимметрии данного листа: \n");            
            }
            return ("");
        }

        //Вычисление ассимметрии
        public override double assim(DataGridView q)
        {           
            //1                               
            double pr1l = Math.Abs(p.x1 - p.x0);
            double pr1r = Math.Abs(p.x2 - p.x1);
            double pr1 = ((pr1l + pr1r) != 0) ? Math.Abs(pr1l - pr1r) / Math.Abs(pr1l + pr1r) : 0;
            q.Rows.Add("Ширина половинок листа.", pr1l.ToString(), pr1r.ToString(), pr1.ToString());
            //2                
            double pr2l = Math.Abs(Math.Sqrt(Math.Pow(Convert.ToDouble(p.p8.X - p.p7.X), 2) + Math.Pow(Convert.ToDouble(p.p8.Y - p.p7.Y), 2)));
            double pr2r = Math.Abs(Math.Sqrt(Math.Pow(p.p10.X - p.p9.X, 2) + Math.Pow(p.p10.Y - p.p9.Y, 2)));
            double pr2 = ((pr2l + pr2r) != 0) ? Math.Abs(pr2l - pr2r) / Math.Abs(pr2l + pr2r) : 0;
            q.Rows.Add("Расстояние от основания до конца жилки второго порядка, второй от основания листа.", pr2l.ToString(), pr2r.ToString(), pr2.ToString());
            //3
            double pr3l = Math.Abs(p.p3.Y - p.p7.Y);
            double pr3r = Math.Abs(p.p5.Y - p.p9.Y);
            double pr3 = ((pr3l + pr3r) != 0) ? Math.Abs(pr3l - pr3r) / Math.Abs(pr3l + pr3r) : 0;
            q.Rows.Add("Расстояние между основаниями первой и второй жилок второго порядка.", pr3l.ToString(), pr3r.ToString(), pr3.ToString());
            //4
            double pr4l = Math.Abs(Math.Sqrt(Math.Pow(p.p4.X - p.p8.X, 2) + Math.Pow(p.p4.Y - p.p8.Y, 2)));
            double pr4r = Math.Abs(Math.Sqrt(Math.Pow(p.p6.X - p.p10.X, 2) + Math.Pow(p.p6.Y - p.p10.Y, 2)));
            double pr4 = ((pr4l + pr4r) != 0) ? Math.Abs(pr4l - pr4r) / Math.Abs(pr4l + pr4r) : 0;
            q.Rows.Add("Расстояние между концами первой и второй жилок второго порядка.", pr4l.ToString(), pr4r.ToString(), pr4.ToString());
            //5            
            Vector v0 = new Vector(Math.Abs(p.p1.X - p.p2.X), Math.Abs(p.p1.Y - p.p2.Y));
            Vector v1 = new Vector(Math.Abs(p.p8.X - p.p7.X), Math.Abs(p.p8.Y - p.p7.Y));
            Vector v2 = new Vector(Math.Abs(p.p10.X - p.p9.X), Math.Abs(p.p10.Y - p.p9.Y));
            double a = Vector.AngleBetween(v0, v1);
            double b = Vector.AngleBetween(v0, v2);                        
            double pr5 = ((a + b) != 0) ? Math.Abs(a - b) / Math.Abs(a + b) : 0;
            q.Rows.Add("Угол между главной жилкой и второй от основания листа жилкой второго порядка.", a.ToString(), b.ToString(), pr5.ToString());
            return ((pr1 + pr2 + pr3 + pr4 + pr5) / 5);            
        }
                
        //Вычисление ассимметрии
        public override double assim()
        {
            //1                               
            double pr1l = Math.Abs(p.x1 - p.x0);
            double pr1r = Math.Abs(p.x2 - p.x1);
            double pr1 = ((pr1l + pr1r) != 0) ? Math.Abs(pr1l - pr1r) / Math.Abs(pr1l + pr1r) : 0;
            //2                
            double pr2l = Math.Abs(Math.Sqrt(Math.Pow(Convert.ToDouble(p.p8.X - p.p7.X), 2) + Math.Pow(Convert.ToDouble(p.p8.Y - p.p7.Y), 2)));
            double pr2r = Math.Abs(Math.Sqrt(Math.Pow(p.p10.X - p.p9.X, 2) + Math.Pow(p.p10.Y - p.p9.Y, 2)));
            double pr2 = ((pr2l + pr2r) != 0) ? Math.Abs(pr2l - pr2r) / Math.Abs(pr2l + pr2r) : 0;
            //3
            double pr3l = Math.Abs(p.p3.Y - p.p7.Y);
            double pr3r = Math.Abs(p.p5.Y - p.p9.Y);
            double pr3 = ((pr3l + pr3r) != 0) ? Math.Abs(pr3l - pr3r) / Math.Abs(pr3l + pr3r) : 0;
            //4
            double pr4l = Math.Abs(Math.Sqrt(Math.Pow(p.p4.X - p.p8.X, 2) + Math.Pow(p.p4.Y - p.p8.Y, 2)));
            double pr4r = Math.Abs(Math.Sqrt(Math.Pow(p.p6.X - p.p10.X, 2) + Math.Pow(p.p6.Y - p.p10.Y, 2)));
            double pr4 = ((pr4l + pr4r) != 0) ? Math.Abs(pr4l - pr4r) / Math.Abs(pr4l + pr4r) : 0;
            //5                
            Vector v0 = new Vector(Math.Abs(p.p1.X - p.p2.X), Math.Abs(p.p1.Y - p.p2.Y));
            Vector v1 = new Vector(Math.Abs(p.p8.X - p.p7.X), Math.Abs(p.p8.Y - p.p7.Y));
            Vector v2 = new Vector(Math.Abs(p.p10.X - p.p9.X), Math.Abs(p.p10.Y - p.p9.Y));
            double pr5l = Vector.AngleBetween(v0, v1);
            double pr5r = Vector.AngleBetween(v0, v2);
            double pr5 = ((pr5l + pr5r) != 0) ? Math.Abs(pr5l - pr5r) / Math.Abs(pr5l + pr5r) : 0;       
            return ((pr1 + pr2 + pr3 + pr4 + pr5) / 5);            
        }
        
        //Нахождение центральной горизонтальной линии
        private void CentrLine(Image b, int nWidth, int nHeight)
        {
            p.h = ((p.p0.Y + p.p2.Y) / 2);
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.DrawImage(b, 0, 0, nWidth, nHeight);
                int i = 1;
                while ((result.GetPixel(i, p.h).Name == "0") && (i < 399))
                    i++;
                p.x0 = i;
                while ((result.GetPixel(i, p.h).Name != "0") && (i < 399))
                    i++;
                p.x2 = i;
                g.Dispose();

            }
        }

        //прорисовка линий при редактировании листа
        public override void drawInitLine(Image image)
        {
            Graphics g = Graphics.FromImage(image);
            g.DrawRectangle(pen1, p.p0.X - 2, p.p0.Y - 2, 4, 4);
            g.DrawRectangle(pen1, p.p1.X - 2, p.p1.Y - 2, 4, 4);
            g.DrawRectangle(pen1, p.p2.X - 2, p.p2.Y - 2, 4, 4);
            g.DrawRectangle(pen1, p.p3.X - 2, p.p3.Y - 2, 4, 4);
            g.DrawRectangle(pen1, p.p4.X - 2, p.p4.Y - 2, 4, 4);
            g.DrawRectangle(pen1, p.p5.X - 2, p.p5.Y - 2, 4, 4);
            g.DrawRectangle(pen1, p.p6.X - 2, p.p6.Y - 2, 4, 4);
            g.DrawRectangle(pen1, p.p7.X - 2, p.p7.Y - 2, 4, 4);
            g.DrawRectangle(pen1, p.p8.X - 2, p.p8.Y - 2, 4, 4);
            g.DrawRectangle(pen1, p.p9.X - 2, p.p9.Y - 2, 4, 4);
            g.DrawRectangle(pen1, p.p10.X - 2, p.p10.Y - 2, 4, 4);
            g.DrawLine(pen, p.p0, p.p1);
            g.DrawLine(pen, p.p1, p.p2);
            g.DrawLine(pen1, p.x0, p.h, p.x2, p.h);
            g.DrawRectangle(pen, p.x1 - 2, p.h - 2, 4, 4);
            g.DrawLine(pen, p.p3, p.p4);
            g.DrawLine(pen, p.p5, p.p6);
            g.DrawLine(pen1, p.p7, p.p3);
            g.DrawLine(pen1, p.p7, p.p8);
            g.DrawLine(pen1, p.p8, p.p4);
            g.DrawLine(pen1, p.p9, p.p5);
            g.DrawLine(pen1, p.p9, p.p10);
            g.DrawLine(pen1, p.p10, p.p6);
            g.Dispose();
            g = null;
            GC.Collect();

                                   
        }

        //прорисовка линий по клику мышью
        public override bool draw(Image image, int pnum, MouseEventArgs e)
        {
            Graphics gr = Graphics.FromImage(image);                    
            gr.DrawRectangle(pen1, e.Location.X - 2, e.Location.Y - 2, 4, 4);
            switch (pnum)
            {
                case 0:
                    p.p0 = e.Location;
                    break;
                case 1:
                    p.p1 = e.Location;
                    gr.DrawLine(pen, p.p0, p.p1);
                    break;
                case 2:
                    p.p2 = e.Location;
                    gr.DrawLine(pen, p.p1, p.p2);
                    CentrLine(image, image.Size.Width, image.Size.Height);
                    gr.DrawLine(pen1, p.x0, p.h, p.x2, p.h);
                    if (p.h < p.p1.Y)
                        p.x1 = Crossing(p.p0, p.p1, new System.Drawing.Point(p.x0, p.h), new System.Drawing.Point(p.x2, p.h));
                    else
                        p.x1 = Crossing(p.p1, p.p2, new System.Drawing.Point(p.x0, p.h), new System.Drawing.Point(p.x2, p.h));
                    gr.DrawRectangle(pen, p.x1 - 2, p.h - 2, 4, 4);
                    break;
                case 3:
                    p.p3 = e.Location;
                    break;
                case 4:
                    p.p4 = e.Location;
                    gr.DrawLine(pen, p.p3, p.p4);
                    break;
                case 5:
                    p.p5 = e.Location;
                    break;
                case 6:
                    p.p6 = e.Location;
                    gr.DrawLine(pen, p.p5, p.p6);
                    break;
                case 7:
                    p.p7 = e.Location;
                    gr.DrawLine(pen1, p.p7, p.p3);
                    break;
                case 8:
                    p.p8 = e.Location;
                    gr.DrawLine(pen1, p.p7, p.p8);
                    gr.DrawLine(pen1, p.p8, p.p4);
                    break;
                case 9:
                    p.p9 = e.Location;
                    gr.DrawLine(pen1, p.p9, p.p5);
                    break;
                case 10:
                    p.p10 = e.Location;
                    gr.DrawLine(pen1, p.p9, p.p10);
                    gr.DrawLine(pen1, p.p10, p.p6);
                    gr.Dispose();
                    gr = null;
                    GC.Collect();
                    return false;
                default:
                    return false;
            }
            gr.Dispose();
            gr = null;
            GC.Collect();
            return true;
        }

        //Сериализация параметров
        public override byte[] getParams()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ps = new MemoryStream(); //поток для пареметров  
            bf.Serialize(ps, p);
            return ps.GetBuffer();
        }

        //Десериализация параметров
        public override void setParams(MemoryStream ms)
        {
            
            BinaryFormatter bf = new BinaryFormatter();
            p=(Params)bf.Deserialize(ms);

        }

        
        
        public Leaf0birch()
        {          
           p= new Params();
        }
    }
}
