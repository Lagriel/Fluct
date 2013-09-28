using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using libxl;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Book book = new BinBook();


                    Sheet sheet = book.addSheet("Invoice");

                    Select select = new Select()
                    .From("sel")
                    .Columns("name, typeofleaf_id, date, place, comment, grade")
                    .Where("id = " + Data.sel);

                    Dictionary<string, object> item = Data.bd.FetchOneRow(select);
                    sheet.writeStr(1, 1, "Название выборки");
                    sheet.writeStr(1, 2, item["name"].ToString());
                    sheet.writeStr(2, 1, "Тип листьев");
                    sheet.writeStr(2, 2, item["typeofleaf_id"].ToString());
                    sheet.writeStr(3, 1, "Дата сбора листьев");
                    sheet.writeStr(3, 2, item["date"].ToString());
                    sheet.writeStr(4, 1, "Место сбора листьев");
                    sheet.writeStr(4, 2, item["place"].ToString());
                    sheet.writeStr(5, 1, "Комментарий");
                    sheet.writeStr(5, 2, item["comment"].ToString());
                    sheet.writeStr(6, 1, "Степень флуктуирующей ассимметрии");
                    sheet.writeStr(6, 2, item["grade"].ToString());

                    sheet.writeStr(8, 0, "#");
                    sheet.writeStr(8, 1, "Степень флуктуирующей ассимметрии");
                    sheet.writeStr(8, 2, "Комментарий");

                    int i = 9;
                    DataTable dt = Data.bd.Execute("SELECT id, grade, comment FROM leaf WHERE sel_id = " + Data.sel.ToString());
                    foreach (DataRow row in dt.Rows)
                    {
                        sheet.writeStr(i, 0, row["id"].ToString());
                        sheet.writeStr(i, 1, row["grade"].ToString());
                        sheet.writeStr(i, 2, row["comment"].ToString());
                        i++;
                    }
                    //sheet.writeStr(0, 0, "!");
                    book.save(saveFileDialog1.FileName);
                    MessageBox.Show("Отчёт успешно сохранён", "Всё ок.", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
            Close();
        }

    }
}
