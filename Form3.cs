﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        string name;
        DateTime date;
        string place;
        string user;
        int type;
        string comment;
        public Form3()
        {
            InitializeComponent();
        }

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
            int res = Data.bd.Insert("sel", parametr);
            if (res < 0)
                MessageBox.Show(Data.bd.LastError);

        }
    }
}