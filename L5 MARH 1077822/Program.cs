// See https://aka.ms/new-console-template for more information
int variable1 = 0;

Console.WriteLine("EJERCICIO 1");
Console.WriteLine("Numero Entero");

variable1= Convert.ToInt32(Console.ReadLine());
if(variable1 > 0) 
{
    Console.WriteLine("Numero positivo");
}
else if (variable1 < 0)
{
    Console.WriteLine("Numero negativo");
}
else if(variable1 == 0)
{
    Console.WriteLine("El numero que ingreso es cero");
}
