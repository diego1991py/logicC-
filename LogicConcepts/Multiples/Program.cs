Console.Write("Ingrese un número: ");

var number_a = Console.ReadLine();

var number_b = Console.ReadLine();

if (int.TryParse(number_a, out int first_number) && int.TryParse(number_b, out int second_number))
{
    if (first_number % second_number == 0)
    {
        Console.WriteLine($"El numero {first_number} es multiplo de {second_number}");
    }
    else { Console.WriteLine($"El numero {first_number} no es multiplo de {second_number}"); }
}

else
{
    Console.WriteLine("Por favor ingresar solo números");
}



