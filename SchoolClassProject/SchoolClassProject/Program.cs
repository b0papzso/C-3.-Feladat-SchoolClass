using SchoolClassProject;
using System.Xml;
using SchoolClassProject.Repo;

SchoolClass kilencA = new SchoolClass
{
    SchoolYear = 9,
    ClassId = 'a',
    MonthlyPay = 7000
};

SchoolClass kilencB = new SchoolClass
{
    SchoolYear = 9,
    ClassId = 'b',
    MonthlyPay = 6000
};

Console.WriteLine(kilencA);
Console.WriteLine(kilencB);

Console.WriteLine(kilencA.whoPaysHowMuchMore(kilencB));


SchoolClassRepo repo = new();
Console.WriteLine("Ha az osztályok 10 hónapig gyűjtik az osztálypénzt és mindegyik osztályban 30 diák van, akkor ennyi pénzt gyűjtöttek volna osztályonként: ");
foreach(var classes in repo.SchoolClasses)
{
    Console.WriteLine($"{classes.SchoolYear}.{classes.ClassId} osztálynak van {classes.MonthlyPay * 30 * 10} Ft-ja");
}