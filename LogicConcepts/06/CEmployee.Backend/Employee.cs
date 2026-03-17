namespace CEmployee.Backend;
public class Employee
{
    private string _nameEmployee;
    private int _salaryBasicHour;
    private int _hoursWorked;

    public Employee(string nameEmployee, int salaryBasicHour, int hoursWorked)
    {
        NameEmployee = nameEmployee;
        SalaryBasicHour = salaryBasicHour;
        HoursWorked = hoursWorked;
    }

    public string NameEmployee
    {
        get => _nameEmployee;
        set => _nameEmployee = value;
    }

    public int SalaryBasicHour
    {
        get => _salaryBasicHour;
        set => _salaryBasicHour = ValidateSalaryBasicHour(value);
    }

    public int HoursWorked
    {
        get => _hoursWorked;
        set => _hoursWorked = ValidateHoursWorked(value);
    }

    public int MonthlySalary
    {
        get => CalculateMonthlySalary();
    }



    private int ValidateSalaryBasicHour(int salaryBasicHour)
    {
        if (salaryBasicHour < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(salaryBasicHour), "El valor del salario por hora debe de ser mayor a 0");
        }
        return salaryBasicHour;

    }

    private int ValidateHoursWorked(int hoursWorked)
    {
        if (hoursWorked > 730)
        {
            throw new ArgumentOutOfRangeException(nameof(hoursWorked), "El valor de las horas debe de ser menor que 730");
        }
        return hoursWorked;
    }

    public int CalculateMonthlySalary()
    {
        int monthlySalary = SalaryBasicHour * HoursWorked;
        return monthlySalary;
    }

    public bool IsSalaryGreaterThan(int minimumWage)
    {
       bool salaryGreaterThan = MonthlySalary > minimumWage;
        return salaryGreaterThan;
    }

}
