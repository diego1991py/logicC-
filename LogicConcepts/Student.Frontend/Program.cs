using Student.Backend;

class Program
{
    static void Main(string[] args)
    {
        string option = InitialOption();
        while (option != "")
        {

            if (option == "a")
            {
                Console.WriteLine("Bienvenido");
                ShowMenu();
            }
            else if (option == "s")
            {
                Console.WriteLine($"Gracias, vuelva pronto");
                break;
            }
            else
            {
                Console.WriteLine($"La opción {option} no es valida");
            }
            option = InitialOption();
        }

    }

    static string InitialOption()
    {
        Console.WriteLine("Por favor ingresar a para ingresar datos o ingresar s para salir");
        string option = Console.ReadLine().ToLower();
        if (string.IsNullOrWhiteSpace(option))
        {
            Console.WriteLine("El campo no debe de estar vacio");
            option = InitialOption();
        }
        return option;
    }

    static void ShowMenu()
    {
        try
        {
            Console.WriteLine("Por favor ingresar número de créditos");
            var stringCredits = Console.ReadLine();

            if (!int.TryParse(stringCredits, out int numberCredits))
            {
                Console.WriteLine("Ingresar solo valores númericos");
                return;
            }

            Console.WriteLine("Por favor ingresar valor de los créditos");
            var stringvalueCredits = Console.ReadLine();

            if (!int.TryParse(stringvalueCredits, out int valueCredits))
            {
                Console.WriteLine("Ingresar solo valores númericos");
                return;
            }

            Console.WriteLine("Por favor ingresar el estrato");
            var stringStratum = Console.ReadLine();

            if (!int.TryParse(stringStratum, out int stratum))
            {
                Console.WriteLine("Ingresar solo valores númericos");
                return;
            }
            var enrollment = new Enrollment(numberCredits, valueCredits, stratum);
            Console.WriteLine(enrollment);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
    }
}

