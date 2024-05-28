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
        public char ClassId { get;set;}
        public int MonthlyPay { get;set;}
        public int StudentCount {  get;set;}

        public SchoolClass(int schoolYear, char classId, int monthlyPay, int studentCount)
        {
            schoolYear = SchoolYear;
            classId = ClassId;
            monthlyPay = MonthlyPay;
            studentCount = StudentCount;
        }

        public SchoolClass()
        {
            SchoolYear = 0;
            ClassId = 'a';
            MonthlyPay = 0;
            StudentCount = 0;
        }

        public override string ToString()
        {
            return $"{SchoolYear}.{ClassId}({MonthlyPay} Ft)";
        }
    }
}
