using SchoolClassProject;
using System.Xml;

SchoolClass kilencA = new SchoolClass
{
    SchoolYear = 9,
    ClassId = "a",
    MonthlyPay = 7000
};

SchoolClass kilencB = new SchoolClass
{
    SchoolYear = 9,
    ClassId = "b",
    MonthlyPay = 6000
};

Console.WriteLine(kilencA);
Console.WriteLine(kilencB);

Console.WriteLine(kilencA.whoPaysHowMuchMore(kilencB));