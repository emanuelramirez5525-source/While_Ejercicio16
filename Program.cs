// Pedir números hasta que el usuario ingrese 0. 
int num = 1;

while (num !=0)
{
    Console.WriteLine("Ingrese números");
    num = int.Parse(Console.ReadLine());
}
Console.WriteLine("El número ingresado es 0");