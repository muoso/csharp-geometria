using Geometria;

Console.WriteLine("Please specify the length of the rectangle's base");
int rectangleBase = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please specify the length of the rectangle's height");
int rectangleHeight = Convert.ToInt32(Console.ReadLine());

Rettangolo MioRettangolo = new Rettangolo(rectangleBase, rectangleHeight, "MioRettangolo");

Console.WriteLine($"L'area del rettangolo misura: {MioRettangolo.calcolaArea()} cm2");
Console.WriteLine($"Il perimetro del rettangolo misura: {MioRettangolo.calcolaPerimetro()} cm");


Rettangolo SecondoRettangolo = new Rettangolo(4, 7, "SecondoRettangolo");
Rettangolo TerzoRettangolo = new Rettangolo(7, 4, "TerzoRettangolo");
Rettangolo QuartoRettangolo = new Rettangolo(4, 2, "QuartoRettangolo");
Rettangolo QuintoRettangolo = new Rettangolo(14, 17, "QuintoRettangolo");

SecondoRettangolo.stampaRettangolo();
SecondoRettangolo.disegnaRettangolo();

TerzoRettangolo.stampaRettangolo();
TerzoRettangolo.disegnaRettangolo();

QuartoRettangolo.stampaRettangolo();
QuartoRettangolo.disegnaRettangolo();

QuintoRettangolo.stampaRettangolo();
QuintoRettangolo.disegnaRettangolo();


