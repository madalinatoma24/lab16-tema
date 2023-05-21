using lab16_tema.Models;
using System;
using System.Linq;

//Seed();

using var ctx = new StudentDBContext();
var studenti = ctx.Students.OrderBy(p => p.Nume).ToList();
studenti.ForEach(p => Console.WriteLine(p));

/*Afisati cel mai tanar student de
la constructii cu varsta de peste
20 de ani*/

var junior=ctx.Students.Where(p => p.Varsta > 20 && p.Specializare == Specializari.Constructii).OrderBy(p => p.Varsta).FirstOrDefault();
Console.WriteLine(junior);

static void Seed()
{
    using var ctx = new StudentDBContext();
    
    ctx.Database.EnsureCreated();

    ctx.Students.Add(new Student
    {
        Nume = "Ion",
        Varsta = 25,
        Prenume = "Mihai",
        Specializare = Specializari.Informatica
    });

    ctx.Students.Add(new Student
    {
        Nume = "Aldo",
        Varsta = 23,
        Prenume = "Monica",
        Specializare = Specializari.Litere
    });

    ctx.Students.Add(new Student
    {
        Nume = "Toma",
        Varsta = 21,
        Prenume = "Madalina",
        Specializare = Specializari.Informatica
    });

    ctx.Students.Add(new Student
    {
        Nume = "Popescu",
        Varsta = 23,
        Prenume = "Mihai",
        Specializare = Specializari.Constructii
    });

    ctx.Students.Add(new Student
    {
        Nume = "Stoica",
        Varsta = 22,
        Prenume = "Livia",
        Specializare = Specializari.Constructii
    });

    ctx.SaveChanges();
}
