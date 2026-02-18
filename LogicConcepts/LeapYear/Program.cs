
bool IsLeapYear(int year)
{
    if(year % 400 == 0)
    {
        return true;
    }
    else if(year % 100 == 0)
    {
        return false;
    }
    else if(year % 4 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}



//Console.WriteLine("Hola, por favor ingresar el año o s para salir");

var numberString = String.Empty;

do
{
    Console.WriteLine("Hola, por favor ingresar el año o s para salir");
    numberString = Console.ReadLine().ToLower();


    if(numberString == "s")
    {
        break;
    }
  
    if (int.TryParse(numberString, out int year))
    {
        if (IsLeapYear(year))
        {
            Console.WriteLine($"El año {year} es bisiesto");
        }
        else
        {
            Console.WriteLine($"El año {year} no es bisiesto");
        }
    }
    else
    {
        Console.WriteLine("Ingresar solo numeros");


}
while (numberString != "s");

Console.WriteLine("Gracias");










