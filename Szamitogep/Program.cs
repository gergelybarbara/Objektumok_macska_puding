using Szamitogepek;

Szamitogep gep1 = new Szamitogep();
Szamitogep gep2 = new Szamitogep(2048,true);

Console.WriteLine("Az első gép: " + gep1);
Console.WriteLine("A második gép: " + gep2);

Szamitogep gep3 = new Szamitogep(512,false);
Console.WriteLine("A harmadik gép: " + gep3);
Console.WriteLine();

//gep3.Kapcsol();
//Console.WriteLine("A harmadik gép: " + gep3);
//Console.WriteLine();


gep1.Kapcsol();
gep1.ProgramMasol(800);
Console.WriteLine("Az első gép: " + gep1);

gep1.ProgramMasol(400);
Console.WriteLine("Az első gép: " + gep1);

gep3.ProgramMasol(1);
Console.WriteLine("A harmadik gép: " + gep3);