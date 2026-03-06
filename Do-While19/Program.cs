Console.WriteLine("Tabla de multiplicar con el número que el usuario ingrese");
Console.WriteLine("Ingrese un número");
int numero=int.Parse(Console.ReadLine());
int i = 1;
do
{
    Console.WriteLine(numero + " x " + i + "=" + (numero * i));
    i++;
}
while (i <= 10);