using objektumok;
using System.Net.NetworkInformation;
using System.Security.Claims;

Puding puding1 = new Puding(); //példányosítottam itt hívom meg a konstruktort
puding1.Hofok = 80;
puding1.Mennyiseg = -100;

Puding puding2 = new Puding(60, 2);


Console.WriteLine("Hőfok: " + puding1.Hofok);
Console.WriteLine("Mennyiség: " + puding1.Mennyiseg);
Console.WriteLine("Puding: " + puding1.ToString()); //örökölte az objetből a to.stringet

Console.WriteLine("Puding: " + puding2);
puding2.Eves();
Console.WriteLine("Puding: " + puding2);
puding2.Eves();
Console.WriteLine("Puding: " + puding2);

if (puding2.Eves()) Console.WriteLine("Puding evés 1:" + puding2);
if (puding2.Eves()) Console.WriteLine("Puding evés 2:" + puding2);

var cica1 = new Macska();
var cica2 = new Macska("Inci", 3, false);

Console.WriteLine();
Console.WriteLine(cica1);
Console.WriteLine(cica2);
Console.WriteLine();

if (cica1.Eszik(0.5)) Console.WriteLine(cica1.Nev + " evett");
else Console.WriteLine(cica1.Nev + " nem volt éhes");
Console.WriteLine();
if (cica2.Eszik(0.5)) Console.WriteLine(cica2.Nev + " evett");
else Console.WriteLine(cica2.Nev + " nem volt éhes");

Console.WriteLine();
Console.WriteLine(cica1);
Console.WriteLine(cica2);
Console.WriteLine();

cica1.Futkos();
cica2.Futkos();

Console.WriteLine();
Console.WriteLine(cica1);
Console.WriteLine(cica2);
Console.WriteLine();
Console.WriteLine(Macska.macskaSzam + " macskám van!");

var cica3 = new Macska("Cirmi", 3);
Macska cica4 = new Macska("Gömbi", 5);
Console.WriteLine(Macska.macskaSzam + " macskám van!");
