using QueryingDBWithLINQ.Models;

Employee[] employeeArray = [
    new Employee(){EmployeeID=1, EmployeeName="Peter", Salary=12000},
    new Employee(){EmployeeID=2, EmployeeName="Linta", Salary=32000},
    new Employee(){EmployeeID=3, EmployeeName="John", Salary=12300},
    new Employee(){EmployeeID=4, EmployeeName="Bob", Salary=7000},
    new Employee(){EmployeeID=5, EmployeeName="Ali", Salary=3000},
    new Employee(){EmployeeID=6, EmployeeName="Laiba", Salary=12765},
    new Employee(){EmployeeID=7, EmployeeName="Fatima", Salary=3400}
    ];

//Use LINQ to find below 20000 salary employee
Console.WriteLine("==========EMP by Salary under 20K============");
Employee[] employees = employeeArray.Where(s => s.Salary < 20000).ToArray();
foreach (var emp in employees)
{
    Console.WriteLine(emp.EmployeeName);
}

//Use LINQ to find the emp with name Linta 
Console.WriteLine("==========EMP by NAME============");
Employee[] employeesByName = employeeArray.Where(s => s.EmployeeName.Equals("Linta")).ToArray();
foreach (var emp in employeesByName)
{
    Console.WriteLine(emp.EmployeeName);
}

//Use LINQ to find the emp by ID 
Console.WriteLine("==========EMP by ID============");
Employee[] employeesByID = employeeArray.Where(s => s.EmployeeID==4).ToArray();
foreach (var emp in employeesByID)
{
    Console.WriteLine(emp.EmployeeName);
}