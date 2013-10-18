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
            InitializeComponent();
            helpProvider1.SetHelpKeyword(this, "page_10.html");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            helpProvider1.SetShowHelp(this, true);
            Data.bd = new DbFacadeSQLite(Data.sPath);

            Select select = new Select()
                .From("sel")
                .Columns("name, typeofleaf_id, date, user, place, comment, grade")
                .Where("id = " + Data.sel);
            
            Dictionary<string, object> item = Data.bd.FetchOneRow(select);
            textBoxName.Text = item["name"].ToString();
            dateTimePickerDate.Value = Convert.ToDateTime(item["date"]);
            textBoxPlace.Text = item["place"].ToString();
            textBoxAuthor.Text = item["user"].ToString();
            comboBoxType.SelectedIndex = Convert.ToInt32(item["typeofleaf_id"]);
            textBoxComment.Text = item["comment"].ToString();      
            
        }

        //Применить
        private void button2_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            place = textBoxPlace.Text;
            user = textBoxAuthor.Text;
            date = dateTimePickerDate.Value;
            type = comboBoxType.SelectedIndex;
            comment = textBoxComment.Text;

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
