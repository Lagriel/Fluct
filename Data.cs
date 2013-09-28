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
            if (grade < 0.04) return 1;
            else if (grade <= 0.044) return 2;
            else if (grade <= 0.049) return 3;
            else if (grade <= 0.054) return 4;
            else return 5;
        }

        public static string qualityText(double grade)
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

    }
    
}
