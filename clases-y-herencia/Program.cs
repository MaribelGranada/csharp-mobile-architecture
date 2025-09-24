/*Clases*/

var rect = new Rectangulo();
rect.Base = 20;
rect.Altura = 40;

Console.WriteLine($"El area del Rectangulo es : {rect.Area()}");
Console.WriteLine($"El perimetro del Rectangulo es : {rect.Perimetro()}");

Console.WriteLine($"");
var cuar = new Cuadrado();

cuar.Base = 20;
cuar.Altura = 40;

Console.WriteLine($"El area del cuadrado es : {cuar.Area()}");
Console.WriteLine($"El perimetro del cuadrado es : {cuar.Perimetro()}");
Console.WriteLine($"El lado del cuadrado es : {cuar.Lado}");
class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area() => Base * Altura;
    public double Perimetro() => 2 * Base + 2 * Altura;

}

class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }

    }
}

