int counter = 1;

List<int> numberList = new List<int>();

while (counter <= 3)
{

    Console.Write("Ingrese un número: ");

    var number = Console.ReadLine();

    if (int.TryParse(number, out int newNumber))
    {
        numberList.Add(newNumber);
        counter++;
    }

    else { Console.WriteLine("Ingresar solo números"); }

}

numberList.Sort();
numberList.Reverse();


for (int i = 0; i < 1; i++)
{
    Console.WriteLine($"El número {numberList[0]} es el mayor");
    Console.WriteLine($"El número {numberList[1]} es el del medio");
    Console.WriteLine($"El número {numberList[2]} es el menor");

}