using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClassProject;

namespace SchoolClassProject.Repo
{
    public class SchoolClassRepo
    {
        
        public SchoolClassRepo()
        {
            SchoolClasses = new List<SchoolClass>
            {
                new SchoolClass(9,'a', 5000,30),
                new SchoolClass(9,'b', 6000,30)
            };
        }
        public List<SchoolClass> SchoolClasses { get; set; }
        public string MostPayedSchoolClass(List<SchoolClass> schoolClasses)
        {

            string mostPaidClass = "";
            int maxPay = int.MinValue;
            int classCount = schoolClasses.Count;
            int equalcount = 0;
            int noPayCount = 0;
            foreach (SchoolClass classes in schoolClasses)
            {
                if (classes.MonthlyPay == 0)
                {
                    noPayCount++;
                }
                if (classes.MonthlyPay == maxPay)
                {
                    equalcount++;
                }
                if (classes.MonthlyPay > maxPay)
                {
                    maxPay = classes.MonthlyPay;
                    mostPaidClass = $"{classes.SchoolYear}.{classes.ClassId}";
                }
            }
            if (noPayCount == classCount)
            {
                mostPaidClass = "Egyik osztály sem fizet osztálypénzt";
            }
            if (equalcount == classCount)
            {
                mostPaidClass = "Az összes osztály ugyanannyit fizet";
            }
            return mostPaidClass;
        }
    }

    
}
