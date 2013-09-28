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
    public partial class Form4 : Form
    {
        string name;
        DateTime date;
        string place;
        string user;
        int type;
        string comment;    
    
        public Form4()
        {
            InitializeComponent();

            Data.bd = new DbFacadeSQLite(Data.sPath);

            Select select = new Select()
                .From("sel")
                .Columns("name, typeofleaf_id, date, user, place, comment, grade")
                .Where("id = " + Data.sel);
            
            Dictionary<string, object> item = Data.bd.FetchOneRow(select);
            textBox1.Text = item["name"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(item["date"]);
            textBox2.Text = item["place"].ToString();
            textBox3.Text = item["user"].ToString();
            comboBox1.SelectedIndex = Convert.ToInt32(item["typeofleaf_id"]);
            textBox4.Text = item["comment"].ToString();      
            
        }

        //Применить
        private void button2_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            place = textBox2.Text;
            user = textBox3.Text;
            date = dateTimePicker1.Value;
            type = comboBox1.SelectedIndex;
            comment = textBox4.Text;

            ParametersCollection parametr = new ParametersCollection();
            parametr.Add("name", name, DbType.String);
            parametr.Add("date", date, DbType.DateTime);
            parametr.Add("place", place, DbType.String);
            parametr.Add("user", user, DbType.String);
            parametr.Add("comment", comment, DbType.String);
            parametr.Add("typeofleaf_id", type, DbType.Int32);
            int res = Data.bd.Update("sel", parametr, "id = " + Data.sel.ToString());
            if (res < 0)
                MessageBox.Show(Data.bd.LastError);
        }
        
    }
}
