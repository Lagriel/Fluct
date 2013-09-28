using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
        }
        


        // Удалить лист
        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверенны?", "Удаление листа", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = Data.bd.Delete("leaf", "id = " + Data.leaf.ToString());
                UpdateLeaf();
            }
            
        }
        

        
        // Добавить лист
        private void button4_Click(object sender, EventArgs e)
        {
            Data.creating = true;
            Form2 f = new Form2();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK && Data.index1 > 0)            
                UpdateLeaf();            
        }
        

        
        //Открыть БД
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "DataBasa files (*.db)|*.db";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                button4.Enabled = button6.Enabled = true;
                Data.sPath = openFileDialog1.FileName;
                groupBox1.Enabled = true;
                UpdadeSel();
                if (comboBox1.Items.Count>0) comboBox1.SelectedIndex = 0;
            }            
        }
        


        //Создать БД
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "DataBasa files (*.db)|*.db";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                dataGridView1.Rows.Clear();
                button4.Enabled = button6.Enabled = true;
                Data.sPath = saveFileDialog1.FileName;
                Data.bd = new DbFacadeSQLite(Data.sPath);                

                Data.sSql = @"CREATE TABLE [typeofleaf](";
                Data.sSql += "[id] INTEGER PRIMARY KEY AUTOINCREMENT, ";
                Data.sSql += "[name] TEXT);";

                Data.sSql = @"CREATE TABLE [sel](";
                Data.sSql += "[id] INTEGER PRIMARY KEY AUTOINCREMENT, ";
                Data.sSql += "[name] TEXT, ";
                Data.sSql += "[date] DATETIME, ";
                Data.sSql += "[grade] FLOAT, ";
                Data.sSql += "[comment] TEXT, ";
                Data.sSql += "[user] TEXT, ";
                Data.sSql += "[typeofleaf_id] INTEGER, ";                
                Data.sSql += "[place_x] FLOAT, ";
                Data.sSql += "[place_y] FLOAT, ";
                Data.sSql += "[place] TEXT, ";
                Data.sSql += "[deviation] FLOAT, ";
                Data.sSql += "FOREIGN KEY (typeofleaf_id) REFERENCES typeofleaf(id));";                

                Data.sSql += "CREATE TABLE [leaf](";
                Data.sSql += "[id] INTEGER PRIMARY KEY AUTOINCREMENT, ";
                Data.sSql += "[params] BLOB NOT NULL, ";
                Data.sSql += "[pic] BLOB, ";
                Data.sSql += "[grade] FLOAT, ";
                Data.sSql += "[comment] TEXT, ";              
                Data.sSql += "[sel_id] INTEGER, ";                
                Data.sSql += "FOREIGN KEY (sel_id) REFERENCES sel(id));";
                
                Data.bd.ExecuteNonQuery(Data.sSql);
                      
                groupBox1.Enabled = true;
            UpdadeSel();
            }
        }
        

        
        //Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        


        //Обновление списка выборок
        private void UpdadeSel()
        {
            comboBox1.Items.Clear();
            Data.bd = new DbFacadeSQLite(Data.sPath);
            DataTable dt = Data.bd.Execute("SELECT id, name, grade FROM sel");            
            foreach (DataRow row in dt.Rows)
            {                           
                comboBox1.Items.Add(row["id"].ToString() + "  " + row["name"].ToString() + "  " + row["grade"].ToString());                
            }            
            button3.Enabled = ((comboBox1.Items.Count > 0) ? true : false);
        }
        


        //Обновление списка листьев
        private void UpdateLeaf()
        {            
            dataGridView1.Rows.Clear();
            Data.bd = new DbFacadeSQLite(Data.sPath);
            DataTable dt = Data.bd.Execute("SELECT id, grade, comment FROM leaf WHERE sel_id = "+ Data.sel.ToString());
            foreach (DataRow row in dt.Rows)
            {                               
                dataGridView1.Rows.Add(row["id"].ToString(), row["grade"], row["comment"]);
            }
            label6.Text = fa(Data.sel).ToString();            
            button6.Enabled = ((dataGridView1.Rows.Count > 0) ? true : false);
            UpdateAboutSel();
        }
        


        //Новая выборка
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            UpdadeSel();
        }
        


        //Обновление описание выборки
        private void UpdateAboutSel()
        {
            Data.sel = Convert.ToInt32(comboBox1.Text.Split(' ')[0]);
            Data.bd = new DbFacadeSQLite(Data.sPath);

            //формируем запрос
            Select select = new Select()
                .From("sel")
                .Columns("name, typeofleaf_id, date, place, comment, grade, deviation")
                .Where("id = " + Data.sel);
            //выполняем
            Dictionary<string, object> item = Data.bd.FetchOneRow(select);
            //далее получаем значения
            label1.Text = item["name"].ToString();
            label4.Text = item["date"].ToString();
            label5.Text = item["place"].ToString();
            label8.Text = item["comment"].ToString();
            groupBox2.Enabled = true;
            label2.Text = dataGridView1.Rows.Count.ToString();
            Data.type = Convert.ToInt32(item["typeofleaf_id"]);
            label3.Text = Data.typeOfLeafToText(Data.type);            

            try
            {
                label10.Text =  Data.qualityText((double)item["grade"]);
                label19.Text = item["deviation"].ToString();
            }
            catch (Exception ex)
            { }
            
        }



        //выбор выборки
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAboutSel();
            UpdateLeaf();            
        }
        


        //Удаление выборки
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверенны?", "Удаление выборки", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.bd.Delete("sel", "id = " + Data.sel.ToString());
                Data.bd.Delete("leaf", "sel_id = " + Data.sel.ToString());
                UpdadeSel();
            }
        }
        


        //Перерасчёт степени асимметрии выборки
        private double fa(int q)
        {
            Data.bd = new DbFacadeSQLite(Data.sPath);
            DataTable dt = Data.bd.Execute("SELECT grade FROM leaf WHERE sel_id = " + q.ToString());
            double a = 0;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                a+=Convert.ToDouble(row["grade"]);
                i++;
            }

            double grade = a / i;           

            double sigma = 0;            
            foreach (DataRow row in dt.Rows)
            {
                sigma+=Math.Pow(Convert.ToDouble(row["grade"]) - grade, 2);                
            }
            sigma = Math.Sqrt(sigma / (dt.Rows.Count - 1));
            label19.Text = sigma.ToString();

            ParametersCollection parameters = new ParametersCollection();
            parameters.Add("grade", grade, DbType.Double);
            parameters.Add("deviation", sigma, DbType.Double);
            int result = Data.bd.Update("sel", parameters, "id = " + q.ToString());

            return (grade);

            




        }



        //Изменить выборку
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                UpdadeSel();
        }


        //выбор листа
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count > 0)
            Data.leaf = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);            

        }


        //изменить лист
        private void button5_Click(object sender, EventArgs e)
        {
            Data.creating = false;
            Form2 f = new Form2();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK && Data.index1 > 0)            
                UpdateLeaf();
            
        }

        private void краткийОтчётОВыборкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void сравнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
        }
        

       
    }
}
