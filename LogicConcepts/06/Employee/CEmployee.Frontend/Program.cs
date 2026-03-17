using CEmployee.Backend;

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
        Console.WriteLine("Por favor ingresar nombre");
        var name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("El campo del nombre no debe de estar vacio");
            return;
        }

        Console.WriteLine("Por favor ingresar valor de las horas");
        var salaryBasicHour = Console.ReadLine();

        if (!int.TryParse(salaryBasicHour, out int basicHour))
        {
            Console.WriteLine("Ingresar solo valores númericos");
            return;
        }

        Console.WriteLine("Por favor ingresar las horas trabajadas");
        var hoursWorked = Console.ReadLine();
        if (!int.TryParse(hoursWorked, out int hours))
        {
            Console.WriteLine("Ingresar solo valores númericos");
            return;
        }

        var employee = new Employee(name, basicHour, hours);

        Console.WriteLine("Por favor ingresar el salario mínimo");
        var minimunWage = Console.ReadLine();

        if (!int.TryParse(minimunWage, out int minumun))
        {
            Console.WriteLine("Ingresar solo valores númericos");
            return;
        }

        bool salaryGreaterThan = employee.IsSalaryGreaterThan(minumun);

        if (salaryGreaterThan)
        {
            Console.WriteLine($"Nombre: {employee.NameEmployee} \nSalario Mensual: {employee.MonthlySalary}");
        }
        else
        {
            Console.WriteLine($"Nombre: {employee.NameEmployee}");

        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);

    }
    }

}
