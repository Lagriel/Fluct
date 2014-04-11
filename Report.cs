﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libxl;
using System.Data;
using System.IO;

namespace WindowsFormsApplication1
{
    class Report
    {
        public static bool singleReport(string fileName)
        {
            try
            {
                Book book = new BinBook();


                Format normalFormat = book.addFormat();
                normalFormat.setBorder(libxl.BorderStyle.BORDERSTYLE_THIN);
                normalFormat.setBorderColor(Color.COLOR_BLACK);

                Format borderBottomFormat = book.addFormat();
                borderBottomFormat.setBorder(libxl.BorderStyle.BORDERSTYLE_THIN);
                borderBottomFormat.setBorderColor(Color.COLOR_BLACK);
                borderBottomFormat.borderBottom = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

                Format borderLeftFormat = book.addFormat();
                borderLeftFormat.setBorder(libxl.BorderStyle.BORDERSTYLE_THIN);
                borderLeftFormat.setBorderColor(Color.COLOR_BLACK);
                borderLeftFormat.borderLeft = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

                Format mediumFormat = book.addFormat();
                mediumFormat.setBorder(libxl.BorderStyle.BORDERSTYLE_MEDIUM);
                mediumFormat.setBorderColor(Color.COLOR_BLACK);


                Sheet sheet = book.addSheet("Invoice");

                Select select = new Select()
                .From("sel")
                .Columns("name, typeofleaf_id, date, place, comment, grade")
                .Columns("name, typeofleaf_id, date, place, comment, grade, deviation")
                .Where("id = " + Data.sel);

                Dictionary<string, object> item = Data.bd.FetchOneRow(select);
                sheet.writeStr(2, 1, "Название выборки", mediumFormat);
                sheet.writeStr(2, 3, item["name"].ToString(), mediumFormat);
                sheet.writeStr(3, 1, "Тип листьев", mediumFormat);
                sheet.writeStr(3, 3, Data.typeOfLeafToText(Convert.ToInt32(item["typeofleaf_id"])), mediumFormat);
                sheet.writeStr(4, 1, "Дата сбора листьев", mediumFormat);
                sheet.writeStr(4, 3, item["date"].ToString(), mediumFormat);
                sheet.writeStr(5, 1, "Место сбора листьев", mediumFormat);
                sheet.writeStr(5, 3, item["place"].ToString(), mediumFormat);
                sheet.writeStr(6, 1, "Комментарий", mediumFormat);
                sheet.writeStr(6, 3, item["comment"].ToString(), mediumFormat);
                sheet.writeStr(7, 1, "Степень флуктуирующей ассимметрии", mediumFormat);
                sheet.writeNum(7, 3, Convert.ToDouble(item["grade"]), mediumFormat);
                sheet.writeStr(8, 1, "Среднее квадратическое отклонение σ", mediumFormat);
                sheet.writeNum(8, 3, Math.Pow(Convert.ToDouble(item["grade"]), 2), mediumFormat);
                for (int q = 2; q < 9; q++)
                {
                    sheet.setMerge(q, q, 1, 2);
                    sheet.setMerge(q, q, 3, 4);
                }
                sheet.setCol(0, 4);
                sheet.setCol(1, 20);
                sheet.setCol(2, 20);
                int i = 12;
                DataTable dt = Data.bd.Execute("SELECT grade, comment, params FROM leaf WHERE sel_id = " + Data.sel.ToString());
                bool first = true;
                foreach (DataRow row in dt.Rows)
                {
                    Leaf leaf = new Leaf0birch();
                    byte[] br = (byte[])row["params"];
                    MemoryStream ms1 = new MemoryStream(br);
                    leaf.setParams(ms1);
                    ms1.Close();

                    if (first)
                    {
                        sheet.writeStr(i - 2, 0, "№", borderBottomFormat);
                        sheet.writeStr(i - 2, 1, "Степень \n ассимметрии", borderBottomFormat);
                        sheet.writeStr(i - 2, 2, "Комментарий", borderBottomFormat);
                        sheet.setMerge(i - 2, i - 1, 0, 0);
                        sheet.setMerge(i - 2, i - 1, 1, 1);
                        sheet.setMerge(i - 2, i - 1, 2, 2);
                        for (int ii = 1; ii <= leaf.getNumberOfAttributes() + 1; ii++)
                        {
                            sheet.writeStr(i - 2, ii * 3, leaf.getNameOfAttribute(ii), normalFormat);
                            sheet.setMerge(i - 2, i - 2, ii * 3, ii * 3 + 2);
                            sheet.writeStr(i - 1, ii * 3, "L", borderBottomFormat);
                            sheet.writeStr(i - 1, ii * 3 + 1, "R", borderBottomFormat);
                            sheet.writeStr(i - 1, ii * 3 + 2, "LR", borderBottomFormat);
                        }
                        first = false;
                    }
                    sheet.writeNum(i, 0, (i - 11), normalFormat);
                    sheet.writeNum(i, 1, Convert.ToDouble(row["grade"]), normalFormat);
                    sheet.writeStr(i, 2, row["comment"].ToString(), normalFormat);


                    for (int ii = 1; ii <= leaf.getNumberOfAttributes() + 1; ii++)
                    {

                        sheet.writeNum(i, ii * 3, Math.Round(leaf.getAttributeValues(ii, 1), 3), borderLeftFormat);
                        sheet.writeNum(i, ii * 3 + 1, Math.Round(leaf.getAttributeValues(ii, 2), 3), normalFormat);
                        sheet.writeNum(i, ii * 3 + 2, Math.Round(leaf.getAttributeValues(ii), 3), normalFormat);
                    }
                    i++;
                }

                //sheet.writeStr(0, 0, "!");
                book.save(fileName);
                return true;
               // MessageBox.Show("Отчёт успешно сохранён", "Всё ок.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                //throw new System.Exception();
                return false;
                //MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        }

    }
}
