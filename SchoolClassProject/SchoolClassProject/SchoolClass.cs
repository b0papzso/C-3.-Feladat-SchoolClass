using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClass
    {
        public int SchoolYear{get;set;}
        public string ClassId { get;set;}
        public int MonthlyPay { get;set;}
        public int StudentCount {  get;set;}

        public SchoolClass(int schoolYear, string classId, int monthlyPay, int studentCount)
        {
            schoolYear = SchoolYear;
            classId = ClassId;
            monthlyPay = MonthlyPay;
            studentCount = StudentCount;
        }

        public SchoolClass()
        {
            SchoolYear = 0;
            ClassId = string.Empty;
            MonthlyPay = 0;
            StudentCount = 0;
        }

        public override string ToString()
        {
            return $"{SchoolYear}.{ClassId}({MonthlyPay} Ft)";
        }
    }
}
