using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public static class SchoolClassExtension
    {
        public static string whoPaysHowMuchMore(this SchoolClass firstClass, SchoolClass secondClass)
        {
            int difference = 0;
            if (firstClass.MonthlyPay >  secondClass.MonthlyPay)
            {
                difference = firstClass.MonthlyPay - secondClass.MonthlyPay;
                return $"{firstClass.SchoolYear}.{firstClass.ClassId} osztály diákjai {difference} forinttal többet fizetnek";
            }
            else if (firstClass.MonthlyPay < secondClass.MonthlyPay)
            {
                difference = secondClass.MonthlyPay - firstClass.MonthlyPay;
                return $"{secondClass.SchoolYear}.{secondClass.ClassId} osztály diákjai {difference} forinttal többet fizetnek";
            }
            else { return $"{firstClass.SchoolYear}.{firstClass.ClassId} és {secondClass.SchoolYear}.{secondClass.ClassId} osztály tanulói ugyan annyit fizetnek osztálypénzbe! havonta."; }
        }

    }
}
