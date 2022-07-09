using Billetera_interface.Clases;

var b1 = new Billetera();
var b2 = new Billetera();

b1.billetesDe500 = 3;
b1.billetesDe50 = 2;

b2.billetesDe1000 = 1;
b2.billetesDe100 = 5;

Console.WriteLine("La primer billetera contiene " + b1.Total() + " pesos");
Console.WriteLine("La segunda billetera contiene " + b2.Total() + " pesos");
var b3 = b1.Combinar(b2);
b1.vaciar();
b2.vaciar();

Console.WriteLine("La nueva billetera contene "+ b3.Total() + " pesos");
Console.WriteLine("La primer billetera contiene " + b1.Total() + " pesos");
Console.WriteLine("La segunda billetera contiene " + b2.Total() + " pesos");