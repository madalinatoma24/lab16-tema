// See https://aka.ms/new-console-template for more information
using lab16_ex2.Models;
Seed();
Console.WriteLine("Hello, World!");

using var ctx = new AutovehiculDbContext();
/*Afisati toate autovehiculele in ordine descrescatoare a anului de fabricatie*/
var auto1 = ctx.Autovehicule.OrderByDescending(a => a.AnFabricatie).ToList();
    auto1.ForEach(a=> Console.WriteLine(a));

/*Afisati autovehiculele grupate in functie de numele producatorului sub forma
“Autovehiculele producatorului Trabant”: 
Id, nume, serie, an de fabricatie */

var auto = ctx.Autovehicule.GroupBy(a => a.Producator.Nume).ToList();
auto.ForEach(a =>
{
    Console.WriteLine($"auto ale producatorului {a.Key}");
    a.ToList().ForEach(a => Console.WriteLine(a));
});

static void Seed()
{
    using var ctx = new AutovehiculDbContext();
    ctx.Autovehicule.Add(new Autovehicul
    {
        AnFabricatie = 2020,
        Nume = "Dacia Logan",
        SeriSasiu= Guid.NewGuid().ToString(),
        Producator = new Producator{ Nume = "Dacia", Adresa = "Calea George Calinescu 1" },
    });

    ctx.Autovehicule.Add(new Autovehicul
    {
        AnFabricatie = 2000,
        Nume = "Skoda Ocavia",
        SeriSasiu = Guid.NewGuid().ToString(),
        Producator = new Producator { Nume = "Skoda", Adresa = "Calea Ion Calinescu 1" },
    });

    ctx.Autovehicule.Add(new Autovehicul
    {
        AnFabricatie = 2020,
        Nume = "Renault Clio",
        SeriSasiu = Guid.NewGuid().ToString(),
        Producator = new Producator { Nume = "Renault", Adresa = "Bulevardul Expozitiei 1" },
    });

    ctx.SaveChanges();
}