using Sales.Backend;

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
            Console.WriteLine("Por favor ingresar cantidad de escritorios");
            var stringAmount = Console.ReadLine();

            if (!int.TryParse(stringAmount, out int amount))
            {
                Console.WriteLine("Ingresar solo valores númericos");
                return;
            }
            var sale = new Sale(amount);
            Console.WriteLine(sale);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
    }
}
