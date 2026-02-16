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

int Lnumber = numberList[2];

Console.WriteLine($"El número {Lnumber} es el mayor");

//foreach (int element in numberList)
//{
//    Console.WriteLine(element);
//}

