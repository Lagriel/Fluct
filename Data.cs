using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Data
    {
        public static string Value 
        {get; set;}
//        public static SQLiteClass mydb
 //       {get; set;}
        public static string sPath
        {get; set;}
        public static string sSql
        {get; set;}
        public static DbFacadeSQLite bd
        {get; set;}
        public static int index1
        { get; set; }
        public static int sel
        { get; set; }
        public static int leaf
        { get; set; }
        public static int type
        { get; set; }
        public static bool creating
        { get; set; }

        public static byte qualityNumber(double grade)
        {
            if (grade < 0.055) return 1;
            else if (grade <= 0.06) return 2;
            else if (grade <= 0.065) return 3;
            else if (grade <= 0.07) return 4;
            else return 5;
        }

        public static byte qualityNumberOld(double grade)
        {
            if (grade < 0.04) return 1;
            else if (grade <= 0.044) return 2;
            else if (grade <= 0.049) return 3;
            else if (grade <= 0.054) return 4;
            else return 5;
        }

        public static string qualityText(double grade)
        {
            if (grade < 0.055) return "Условно нормальное";
            else if (grade <= 0.06) return "Незначительные отклонения от нормы";
            else if (grade <= 0.065) return "Средний уровень отклонений от нормы";
            else if (grade <= 0.07) return "Существенные отклонения от нормы";
            else return "Критическое состояние";
        }

        public static string qualityTextOld(double grade)
        {
            if (grade < 0.04) return "Условно нормальное";
            else if (grade <= 0.044) return "Незначительные отклонения от нормы";
            else if (grade <= 0.049) return "Средний уровень отклонений от нормы";
            else if (grade <= 0.054) return "Существенные отклонения от нормы";
            else return "Критическое состояние";
        }

        public static string typeOfLeafToText(int typeOfLeaf)
        {
            switch (Data.type)
            {
                case 0:
                    return "Берёза";
                case 1:
                    return "Липа";
                case 2:
                    return "Осина";
                default:
                    return "";
            }
        }
        
        public static double veracity(int count, double student)
        {
            if (count < 11)
            {
                if (student < 1.372)
                    return 0.8;
                if (student < 1.8125)
                    return 0.9;
                if (student < 2.2281)
                    return 0.95;
                if (student < 2.7638)
                    return 0.98;
                if (student < 3.1693)
                    return 0.99;
                if (student < 3.5814)
                    return 0.995;
                if (student < 4.1437)
                    return 0.998;
                return 0.999;
            }
            if (count < 21)
            {
                if (student < 1.3253)
                    return 0.8;
                if (student < 1.7247)
                    return 0.9;
                if (student < 2.086)
                    return 0.95;
                if (student < 2.5280)
                    return 0.98;
                if (student < 2.8453)
                    return 0.99;
                if (student < 3.1534)
                    return 0.995;
                if (student < 3.5518)
                    return 0.998;
                return 0.999;
            }
            if (count < 51)
            {
                if (student < 1.298)
                    return 0.8;
                if (student < 1.6759)
                    return 0.9;
                if (student < 2.0086)
                    return 0.95;
                if (student < 2.4033)
                    return 0.98;
                if (student < 2.6778)
                    return 0.99;
                if (student < 3.9370)
                    return 0.995;
                if (student < 3.2614)
                    return 0.998;
                return 0.999;
            }
            if (count < 101)
            {
                if (student < 1.2901)
                    return 0.8;
                if (student < 1.6602)
                    return 0.9;
                if (student < 1.9840)
                    return 0.95;
                if (student < 2.3642)
                    return 0.98;
                if (student < 2.6259)
                    return 0.99;
                if (student < 2.8707)
                    return 0.995;
                if (student < 3.1737)
                    return 0.998;
                return 0.999;
            }
            if (count < 201)
            {
                if (student < 1.2858)
                    return 0.8;
                if (student < 1.6525)
                    return 0.9;
                if (student < 1.9719)
                    return 0.95;
                if (student < 2.3451)
                    return 0.98;
                if (student < 2.6006)
                    return 0.99;
                if (student < 2.8385)
                    return 0.995;
                if (student < 3.1315)
                    return 0.998;
                return 0.999;
            }
            
            {
                if (student < 1.2830)
                    return 0.8;
                if (student < 1.6470)
                    return 0.9;
                if (student < 1.9640)
                    return 0.95;
                if (student < 2.3330)
                    return 0.98;
                if (student < 2.7850)
                    return 0.99;
                if (student < 2.8190)
                    return 0.995;
                if (student < 3.1060)
                    return 0.998;
                return 0.999;
            }
        }              

    }
    
}
