using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Data.SQLite;
using System.Runtime.Serialization.Formatters.Binary;
//using WindowsFormsApplication1.Properties;


namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        
        Leaf leaf;        
        string comment;
        int pnum = 0;        
        bool active = false;       
        public Form2()
        {
            InitializeComponent();            
            helpProvider1.SetHelpKeyword(this, "page_11.html");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            helpProvider1.SetShowHelp(this, true);
            //leaf = new Leaf0birch();
            switch (Data.type)
            {
                case 0:
                    leaf = new Leaf0birch();
                    break;
                case 1:
                    leaf = new Leaf1linden();
                    break;
                default:
                    leaf = new Leaf0birch();
                    break;
            }

            if (Data.creating)
            {
                buttonEdit.Enabled = false;
                buttonOpenImage.Enabled = true;
            }
            else
            {
                buttonEdit.Enabled = true;
                buttonOpenImage.Enabled = false;
                Data.bd = new DbFacadeSQLite(Data.sPath);                
                //формируем запрос
                Select select = new Select()
                    .From("leaf")
                    .Columns("params, pic, comment")
                    .Where("id = " + Data.leaf);
                //выполняем
                Dictionary<string, object> item = Data.bd.FetchOneRow(select);
                //далее получаем значения            
                byte[] byteArray = (byte[])item["pic"];
                MemoryStream ms0 = new MemoryStream(byteArray);
                leaf.img = Image.FromStream(ms0);                           
                pictureBox1.Size = leaf.img.Size;                                
                pictureBox1.Image = Image.FromStream(ms0);                
                Array.Clear(byteArray, 0, byteArray.Length);                
                ms0.Close();
                byte[] br = (byte[])item["params"];
                MemoryStream ms1 = new MemoryStream(br);
                // Прорисовываем линии и точки поверх изображения.
                leaf.setParams(ms1);
                ms1.Close();
                Array.Clear(br, 0, br.Length);
                leaf.drawInitLine(pictureBox1.Image);
                // Заполняем таблицу
                labelFluctValue.Text = leaf.assim(dataGridView1).ToString();
                tabControl1.SelectTab(1);
                labelHint.Text = leaf.getHint(1);
                textBoxComment.Text = item["comment"].ToString();            
            }

                labelHint.Text = leaf.getHint(0);
            
        }

        
        //Изменение размера изображения
        public Image ResizeImg(Image b, int nWidth, int nHeight)
        {
            
            Image result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(b, 0, 0, nWidth, nHeight);
                g.Dispose();                
            }
            return Clean(result, nWidth, nHeight); 
        }



        //Очистка изображения
        private Bitmap Clean(Image b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);            
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.DrawImage(b, 0, 0, nWidth, nHeight);

                int firstR = 0;
                int firstG = 0;
                int firstB = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        firstR += result.GetPixel(i, j).R;
                        firstG += result.GetPixel(i, j).G;
                        firstB += result.GetPixel(i, j).B;
                    }
                }
                firstR /= 100; firstR -= 10;
                firstG /= 100; firstR -= 10;
                firstB /= 100; firstR -= 10;

                int endR = 0;
                int endG = 0;
                int endB = 0;
                for (int i = nWidth-1; i > nWidth - 10; i--)
                {
                    for (int j = nHeight-1; j > nHeight - 10; j--)
                    {
                        endR += result.GetPixel(i, j).R;
                        endG += result.GetPixel(i, j).G;
                        endB += result.GetPixel(i, j).B;
                    }
                }
                endR /= 100; endR -= 10;
                endG /= 100; endR -= 10;
                endB /= 100; endR -= 10;

                for (int i = 0; i < nWidth; i++)
                {
                    for (int j = 0; j < nHeight; j++)
                    {
                        //if ((result.GetPixel(i,j).G+result.GetPixel(i,j).R+result.GetPixel(i,j).B)>500)
                        if ((result.GetPixel(i, j).G > firstG) && (result.GetPixel(i, j).R > firstR) && (result.GetPixel(i, j).B > firstB)
                            ||
                            (result.GetPixel(i, j).G > endG) && (result.GetPixel(i, j).R > endR) && (result.GetPixel(i, j).B > endB))
                        {
                            result.SetPixel(i,j,Color.Transparent);
                        }
                    }
                }
                g.Dispose();
            }
            return result;
        }       



        //Открытие изображения
        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                string str = openFileDialog1.FileName;
                Image img = Image.FromFile(str);
                double k = (double)img.Size.Height / (double)img.Size.Width;           
                pictureBox1.Height = (Convert.ToInt32(Math.Round(k * 400)));
                leaf.img = ResizeImg(img, 400, pictureBox1.Height);
                active = true;
                pictureBox1.Image = (Image)leaf.img.Clone();
                labelHint.Text = leaf.getHint(1);
                buttonEdit.Enabled = true;                
            }
        }
    

        //Расстановка точек
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {            
            if (active)
            {                
                labelHint.Text = leaf.getHint(pnum+2);
                if (leaf.draw(pictureBox1.Image, pnum, e))
                { 
                    buttonOpenImage.Enabled = false;
                    tabControl1.SelectTab(0);
                }
                else
                {
                    active = false;
                    buttonSave.Enabled = true;                    
                    labelFluctValue.Text = leaf.assim(dataGridView1).ToString();
                    tabControl1.SelectTab(1);             
                }
                pictureBox1.Invalidate();
                pnum++;
                pictureBox1.Refresh();                       
            }            
        }


 
        //Сохранить
        private void buttonSave_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();// Store it in Binary Array as Stream
            MemoryStream ms2 = new MemoryStream();                      
            // Сохранили картинку в MemStream
            leaf.img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            // Картинка в массиве
            byte[] arrImage = ms.GetBuffer();
            // Записали картинку в поток
            ms2.Write(arrImage, 0, arrImage.Length);
            comment = (textBoxComment.Text == "") ? "-" : textBoxComment.Text;
            ParametersCollection parametr = new ParametersCollection();
            parametr.Add("params", leaf.getParams(), DbType.Binary);            
            parametr.Add("pic", ms2.GetBuffer(), DbType.Binary);
            parametr.Add("grade", leaf.assim(), DbType.Double);
            parametr.Add("comment", comment, DbType.String);            
            parametr.Add("sel_id", Data.sel, DbType.Int32);            
            Data.index1 = (Data.creating)?Data.bd.Insert("leaf", parametr):Data.bd.Update("leaf", parametr, "id = " + Data.leaf.ToString());
            if (Data.index1 < 0)
            MessageBox.Show(Data.bd.LastError);
        }
           
            
        
        //Обнулить
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Временно не работает","Увы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            pnum = 0;
            buttonSave.Enabled = false;
            buttonOpenImage.Enabled = true;
            active = true;
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            GC.Collect();         
            pictureBox1.Image = new Bitmap((Bitmap)leaf.img.Clone());            
            dataGridView1.Rows.Clear();
            pictureBox1.Refresh();
        }



    }
}
