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
            helpProvider1.SetHelpKeyword(this, "page_6.html");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            helpProvider1.SetShowHelp(this, true);
        }
        


        // Удалить лист
        private void buttonRemoveLeaf_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверенны?", "Удаление листа", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = Data.bd.Delete("leaf", "id = " + Data.leaf.ToString());
                UpdateLeaf();
            }
            
        }
        

        
        // Добавить лист
        private void buttonAddLeaf_Click(object sender, EventArgs e)
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
                отчётыToolStripMenuItem.Enabled = buttonAddLeaf.Enabled = buttonRemoveLeaf.Enabled = true;
                Data.sPath = openFileDialog1.FileName;
                groupBoxSel.Enabled = true;
                UpdadeSel();
                if (comboBoxSels.Items.Count>0) comboBoxSels.SelectedIndex = 0;
            }            
        }
        


        //Создать БД
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "DataBasa files (*.db)|*.db";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                dataGridViewLeafs.Rows.Clear();
                отчётыToolStripMenuItem.Enabled = buttonAddLeaf.Enabled = buttonRemoveLeaf.Enabled = true;
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
                      
                groupBoxSel.Enabled = true;
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
            comboBoxSels.Items.Clear();
            Data.bd = new DbFacadeSQLite(Data.sPath);
            DataTable dt = Data.bd.Execute("SELECT id, name, grade FROM sel");            
            foreach (DataRow row in dt.Rows)
            {                           
                comboBoxSels.Items.Add(row["id"].ToString() + "  " + row["name"].ToString() + "  " + row["grade"].ToString());                
            }            
            buttonRemoveSel.Enabled = ((comboBoxSels.Items.Count > 0) ? true : false);
        }
        


        //Обновление списка листьев
        private void UpdateLeaf()
        {            
            dataGridViewLeafs.Rows.Clear();
            Data.bd = new DbFacadeSQLite(Data.sPath);
            DataTable dt = Data.bd.Execute("SELECT id, grade, comment FROM leaf WHERE sel_id = "+ Data.sel.ToString());
            foreach (DataRow row in dt.Rows)
            {                               
                dataGridViewLeafs.Rows.Add(row["id"].ToString(), Math.Round((double)row["grade"],4), row["comment"]);
            }
            labelGradeValue.Text = Math.Round(fa(Data.sel),4).ToString();            
            buttonRemoveLeaf.Enabled = ((dataGridViewLeafs.Rows.Count > 0) ? true : false);
            UpdateAboutSel();
        }
        


        //Новая выборка
        private void buttonNewSel_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            UpdadeSel();
            if (comboBoxSels.Items.Count > 0) comboBoxSels.SelectedIndex = comboBoxSels.Items.Count-1;
        }
        


        //Обновление описание выборки
        private void UpdateAboutSel()
        {
            Data.sel = Convert.ToInt32(comboBoxSels.Text.Split(' ')[0]);
            Data.bd = new DbFacadeSQLite(Data.sPath);

            //формируем запрос
            Select select = new Select()
                .From("sel")
                .Columns("name, typeofleaf_id, date, place, comment, grade, deviation")
                .Where("id = " + Data.sel);
            //выполняем
            Dictionary<string, object> item = Data.bd.FetchOneRow(select);
            //далее получаем значения
            labelNameOfSelValue.Text = item["name"].ToString();
            labelDateValue.Text = item["date"].ToString();
            labelPlaceValue.Text = item["place"].ToString();
            labelCommentValue.Text = item["comment"].ToString();
            groupBoxLeaf.Enabled = true;
            labelCountValue.Text = dataGridViewLeafs.Rows.Count.ToString();
            Data.type = Convert.ToInt32(item["typeofleaf_id"]);
            labelTypeOfLeafsValue.Text = Data.typeOfLeafToText(Data.type);            

            try
            {
                labelQualityValue.Text =  Data.qualityText((double)item["grade"]);
                labelSigmaValue.Text = Math.Round((double)item["deviation"],4).ToString();
                labelGradeValue.Text += " ± " + Math.Round(Math.Pow((double)item["deviation"], 2),4).ToString();
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
        private void buttonRemoveSel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверенны?", "Удаление выборки", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.bd.Delete("sel", "id = " + Data.sel.ToString());
                Data.bd.Delete("leaf", "sel_id = " + Data.sel.ToString());
                UpdadeSel();
            }
            if (comboBoxSels.Items.Count > 0) comboBoxSels.SelectedIndex = 0;
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
            labelSigmaValue.Text = sigma.ToString();

            ParametersCollection parameters = new ParametersCollection();
            parameters.Add("grade", grade, DbType.Double);
            parameters.Add("deviation", sigma, DbType.Double);
            int result = Data.bd.Update("sel", parameters, "id = " + q.ToString());

            return (grade);

        }



        //Изменить выборку
        private void buttonEditSel_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                UpdadeSel();
        }


        //выбор листа
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewLeafs.SelectedCells.Count > 0)
            Data.leaf = Convert.ToInt32(dataGridViewLeafs.SelectedCells[0].Value);            

        }


        //изменить лист
        private void buttonEditLeaf_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //buttonAddLeaf.Enabled = false;
            //buttonEditLeaf.Enabled = false;
            //buttonEditSel.Enabled = false;
            //buttonNewSel.Enabled = false;
            //buttonRemoveLeaf.Enabled = false;
            //buttonRemoveSel.Enabled = false;            
            отчётыToolStripMenuItem.Enabled = false;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Анализатор флуктуирующей ассимметрии.\nВерсия 0.4-альфа. \n© Кароза Антон. \n+375336715354\nyaAHTOH@ya.ru\n2013.", "О программе.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
        

       
    }
}
