// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese la edad del ganador: ");
int edad=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de adivinanzas acertadas: ");
int aciertos=int.Parse(Console.ReadLine());
int ganancia = 0;
if (edad >= 18)
{
    if (edad < 3)
    {

        ganancia = 30;
    }
    else 
    {
        ganancia = 50;
    
    }



}
else {
    if (edad < 3)
    {
        ganancia = 50;

    }
    else 
    {
        ganancia = 80;
    }
}
float extra = (edad * 5) + (aciertos * 2);

float total=ganancia + extra;
Console.WriteLine("el extra es : "+ extra);
Console.WriteLine("El monto total que el ganador recibe como premio es: "+total);