using CatWorx.BadgeMaker;

List<Employee> employees = GetEmployees();
Util.PrintEmployees(employees);
Util.MakeCSV(employees);

static List<Employee> GetEmployees()
{
    List<Employee> employees = new List<Employee>();
    while (true)
    {
        // Move the initial prompt inside the loop, so it repeats for each employee
        Console.WriteLine("Enter first name (leave empty to exit): ");

        // change input to firstName
        string firstName = Console.ReadLine();
        if (firstName == "")
        {
            break;
        }

        // add a Console.ReadLine() for each value
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter ID: ");
        int id = Int32.Parse(Console.ReadLine());
        string photoUrl = "https://placekitten.com/300/300";
        Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
        employees.Add(currentEmployee);
    }
    return employees;
}


