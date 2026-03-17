Console.Write("Ingrese un número: ");

var number = Console.ReadLine();

if (int.TryParse(number, out int numberInt))
{
    if (numberInt % 2 == 0)
    {
        Console.WriteLine($"El numero {numberInt} es par");
    }
    else 
    { 
        Console.WriteLine($"El número {numberInt} no es par"); 
    }
}
else
{
    Console.WriteLine($"Por favor ingresar solo números");
}

