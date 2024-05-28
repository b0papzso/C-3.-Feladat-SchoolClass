using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Tests
{
    [TestClass()]
    public class SchoolClassExtensionTests
    {
        [TestMethod()]
        public void MostPayedSchoolClassTestEqualPay()
        {
            SchoolClass kilenca = new SchoolClass
            {
                SchoolYear = 9,
                ClassId = "a",
                MonthlyPay = 5000,
                StudentCount = 30
            };

            SchoolClass kilencb = new SchoolClass
            {
                SchoolYear = 9,
                ClassId = "b",
                MonthlyPay = 5000,
                StudentCount = 30
            };

            string actual = kilenca.MostPayedSchoolClass(kilencb);
            string expected = "Egyenlő a két osztály";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void MostPayedSchoolClassTestFirstPaidMore()
        {
            SchoolClass kilenca = new SchoolClass
            {
                SchoolYear = 9,
                ClassId = "a",
                MonthlyPay = 6000,
                StudentCount = 30
            };

            SchoolClass kilencb = new SchoolClass
            {
                SchoolYear = 9,
                ClassId = "b",
                MonthlyPay = 5000,
                StudentCount = 30
            };

            string actual = kilenca.MostPayedSchoolClass(kilencb);
            string expected = "9.a többet fizettett";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void MostPayedSchoolClassTestsecondPaidMore()
        {
            SchoolClass kilenca = new SchoolClass
            {
                SchoolYear = 9,
                ClassId = "a",
                MonthlyPay = 5000,
                StudentCount = 30
            };

            SchoolClass kilencb = new SchoolClass
            {
                SchoolYear = 9,
                ClassId = "b",
                MonthlyPay = 6000,
                StudentCount = 30
            };

            string actual = kilenca.MostPayedSchoolClass(kilencb);
            string expected = "9.b többet fizetett";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void MostPayedSchoolClassTestBothNoPay()
        {
            SchoolClass kilenca = new SchoolClass
            {
                SchoolYear = 9,
                ClassId = "a",
                MonthlyPay = 0,
                StudentCount = 30
            };

            SchoolClass kilencb = new SchoolClass
            {
                SchoolYear = 9,
                ClassId = "b",
                MonthlyPay = 0,
                StudentCount = 30
            };

            string actual = kilenca.MostPayedSchoolClass(kilencb);
            string expected = "Egyik osztály sem fizet";

            Assert.AreEqual(actual, expected);
        }
    }
}