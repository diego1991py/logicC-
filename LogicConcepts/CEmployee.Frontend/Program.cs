using CEmployee.Backend;

var option = String.Empty;

while (option != "s")
{
    Console.WriteLine("Por favor ingresar a para ingresar datos o ingresar s para salir");
    option = Console.ReadLine().ToLower();

    if (option == "a")
    {
        try
        {
            Console.WriteLine("Por favor ingresar nombre");
            var name = Console.ReadLine(); 

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("El campo del nombre no debe de estar vacio");                
            }
            else
            {
                Console.WriteLine("Por favor ingresar valor de las horas");
                var salaryBasicHour = Console.ReadLine();

                int.TryParse(salaryBasicHour, out int basicHour);

                Console.WriteLine("Por favor ingresar las horas trabajadas");
                var hoursWorked = Console.ReadLine();
                int.TryParse(hoursWorked, out int hours);

                var employee = new Employee(name, basicHour, hours);

                Console.WriteLine("Por favor ingresar el salario mínimo");
                var minimunWage = Console.ReadLine();
                int.TryParse(minimunWage, out int minumun);

                int monthlySalary = employee.CalculateMonthlySalary();

                bool salaryGreaterThan = employee.IsSalaryGreaterThan(minumun);

                if (salaryGreaterThan)
                {
                    Console.WriteLine($"{employee.NameEmployee} {monthlySalary}");
                }
                else
                {
                    Console.WriteLine($"{employee.NameEmployee}");

                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else if (option == "s")
    {
        Console.WriteLine($"Gracias, vuelva pronto");
    }
    else
    {
        Console.WriteLine($"La opción {option} no es valida");
    }

    
}

