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
            initSel(comboBoxLeft);
            initSel(comboBoxRight);
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
                .Where("id = " + (comboBoxLeft.Text.Split(' ')[0]));            
            Dictionary<string, object> item = Data.bd.FetchOneRow(select);            
            labelNameValueLeft.Text = item["name"].ToString();
            labelDateValueLeft.Text = item["date"].ToString();
            labelPlaceValueLeft.Text = item["place"].ToString();
            labelCommentValueLeft.Text = item["comment"].ToString();
            labelGradeValueLeft.Text = item["grade"].ToString();
            labelTypeValueLeft.Text = Data.typeOfLeafToText(Convert.ToInt32(item["typeofleaf_id"]));
            labelQualityValueLeft.Text = Data.qualityText((double)item["grade"]);
            labelSigmaValueLeft.Text = item["deviation"].ToString();
            Dictionary<string, object> item1 = Data.bd.FetchOneRow("SELECT  COUNT(*) FROM leaf WHERE sel_id = " + (comboBoxLeft.Text.Split(' ')[0]));
            labelCountValueLeft.Text = item1["COUNT(*)"].ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Data.bd = new DbFacadeSQLite(Data.sPath);
            Select select = new Select()
                .From("sel")
                .Columns("name, typeofleaf_id, date, place, comment, grade, deviation")
                .Where("id = " + (comboBoxRight.Text.Split(' ')[0]));
            Dictionary<string, object> item = Data.bd.FetchOneRow(select);
            labelNameValueRight.Text = item["name"].ToString();
            labelDateValueRight.Text = item["date"].ToString();
            labelPlaceValueRight.Text = item["place"].ToString();
            labelCommentValueRight.Text = item["comment"].ToString();
            labelGradeValueRight.Text = item["grade"].ToString();
            labelTypeValueRight.Text = Data.typeOfLeafToText(Convert.ToInt32(item["typeofleaf_id"]));
            labelQualityValueRight.Text = Data.qualityText((double)item["grade"]);
            labelSigmaValueRight.Text = item["deviation"].ToString();
            Dictionary<string, object> item1 = Data.bd.FetchOneRow("SELECT  COUNT(*) FROM leaf WHERE sel_id = " + (comboBoxRight.Text.Split(' ')[0]));
            labelCountValueRight.Text = item1["COUNT(*)"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResult.Text = ((Convert.ToDouble(labelGradeValueLeft.Text) - Convert.ToDouble(labelGradeValueRight.Text))/(Math.Sqrt(Math.Pow(Convert.ToDouble(labelSigmaValueLeft.Text),2)+Math.Pow(Convert.ToDouble(labelSigmaValueRight.Text),2)))).ToString();
        }
    }
}
