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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            initSel(comboBox1);
            initSel(comboBox2);
        }

        private void initSel(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            Data.bd = new DbFacadeSQLite(Data.sPath);
            DataTable dt = Data.bd.Execute("SELECT id, name, grade FROM sel");
            foreach (DataRow row in dt.Rows)
            {
                comboBox.Items.Add(row["id"].ToString() + "  " + row["name"].ToString() + "  " + row["grade"].ToString());
            }            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Data.bd = new DbFacadeSQLite(Data.sPath);            
            Select select = new Select()
                .From("sel")
                .Columns("name, typeofleaf_id, date, place, comment, grade, deviation")
                .Where("id = " + (comboBox1.Text.Split(' ')[0]));            
            Dictionary<string, object> item = Data.bd.FetchOneRow(select);            
            label31.Text = item["name"].ToString();
            label28.Text = item["date"].ToString();
            label26.Text = item["place"].ToString();
            label24.Text = item["comment"].ToString();
            label22.Text = item["grade"].ToString();
            label30.Text = Data.typeOfLeafToText(Convert.ToInt32(item["typeofleaf_id"]));
            label34.Text = Data.qualityText((double)item["grade"]);
            label36.Text = item["deviation"].ToString();
            Dictionary<string, object> item1 = Data.bd.FetchOneRow("SELECT  COUNT(*) FROM leaf WHERE sel_id = " + (comboBox1.Text.Split(' ')[0]));
            label32.Text = item1["COUNT(*)"].ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Data.bd = new DbFacadeSQLite(Data.sPath);
            Select select = new Select()
                .From("sel")
                .Columns("name, typeofleaf_id, date, place, comment, grade, deviation")
                .Where("id = " + (comboBox2.Text.Split(' ')[0]));
            Dictionary<string, object> item = Data.bd.FetchOneRow(select);
            label1.Text = item["name"].ToString();
            label4.Text = item["date"].ToString();
            label5.Text = item["place"].ToString();
            label8.Text = item["comment"].ToString();
            label6.Text = item["grade"].ToString();
            label3.Text = Data.typeOfLeafToText(Convert.ToInt32(item["typeofleaf_id"]));
            label10.Text = Data.qualityText((double)item["grade"]);
            label19.Text = item["deviation"].ToString();
            Dictionary<string, object> item1 = Data.bd.FetchOneRow("SELECT  COUNT(*) FROM leaf WHERE sel_id = " + (comboBox2.Text.Split(' ')[0]));
            label2.Text = item1["COUNT(*)"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label37.Text = ((Convert.ToDouble(label22.Text) - Convert.ToDouble(label6.Text))/(Math.Sqrt(Math.Pow(Convert.ToDouble(label36.Text),2)+Math.Pow(Convert.ToDouble(label19.Text),2)))).ToString();
        }
    }
}
