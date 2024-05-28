using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject.Repo;
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
            SchoolClassRepo repo = new SchoolClassRepo();
            List<SchoolClass> schoolClasses = new List<SchoolClass>
            {
                new SchoolClass(9,"a", 5000,30),
                new SchoolClass(9,"b", 5000,30)
            };

            string actual = repo.MostPayedSchoolClass(schoolClasses);
            string expected = "Az összes osztály ugyanannyit fizet";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPayedSchoolClassTestFirstPaidMore()
        {
            SchoolClassRepo repo = new SchoolClassRepo();
            List<SchoolClass> schoolClasses = new List<SchoolClass>
            {
                new SchoolClass(9,"a", 6000,30),
                new SchoolClass(9,"b", 5000,30)
            };

            string actual = repo.MostPayedSchoolClass(schoolClasses);
            string expected = "9.a";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPayedSchoolClassTestsecondPaidMore()
        {
            SchoolClassRepo repo = new SchoolClassRepo();
            List<SchoolClass> schoolClasses = new List<SchoolClass>
            {
                new SchoolClass(9,"a", 5000,30),
                new SchoolClass(9,"b", 5000,30)
            };

            string actual = repo.MostPayedSchoolClass(schoolClasses);
            string expected = "9.b";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPayedSchoolClassTestBothNoPay()
        {
            SchoolClassRepo repo = new SchoolClassRepo();
            List<SchoolClass> schoolClasses = new List<SchoolClass>
            {
                new SchoolClass(9,"a", 5000,30),
                new SchoolClass(9,"b", 5000,30)
            };

            string actual = repo.MostPayedSchoolClass(schoolClasses);
            string expected = "Egyik osztály sem fizet osztálypénzt";

            Assert.AreEqual(expected, actual);
        }
    }
}