using EmployeePayrollService;
EmployeeRepo repo = new EmployeeRepo();
EmployeeModel employee = new EmployeeModel();
Console.WriteLine("Welcome to Employee Payroll!");
Console.WriteLine("Please select any");
Console.WriteLine("1.To add \n 2.To get details \n 3.Retrive data between range \n 4.To find sum of salary \n 5.To find average of salary" +
    " \n 6.To find max salary \n 7.To find min salary \n 8.To count salary");
int choice=Convert.ToInt32(Console.ReadLine());
switch (choice) {
    case 1:
        Console.WriteLine("Enter employee name:");
        employee.EmployeeName = Console.ReadLine();
        Console.WriteLine("Enter technology");
        employee.Department = Console.ReadLine();
        Console.WriteLine("Enter contact number");
        employee.PhoneNumber = Console.ReadLine();
        Console.WriteLine("Enter address");
        employee.Address = Console.ReadLine();
        Console.WriteLine("Enter sex");
        employee.Gender = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter basic pay");
        employee.BasicPay = Convert.ToInt32((Console.ReadLine() != null) ? Console.ReadLine() : 0);
        Console.WriteLine("Enter Deduction amount");
        employee.Deductions = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter data in format yy-mm-dd");
employee.StartDate = Convert.ToDateTime(Console.ReadLine());
if (repo.AddEmployee(employee))
    Console.WriteLine("Records added successfully");
break;
        case 2:
        Console.WriteLine("All employee records:");
        repo.GetAllEmployee();
        break;
    case 3:
        Console.WriteLine("Records beween range");
        repo.RetriveDataBetweenRange();
        break;
    case 4:
       Console.WriteLine("Sum:");
       var result=repo.FindSum();
       if(result!=false)
       Console.WriteLine(result);
        break;
    case 5:
        Console.WriteLine("Average=");
        repo.FindAverage();
        break;
    case 6:
        Console.WriteLine("Maximum salary:");
        repo.FindMaxSalary();
        break;
    case 7:
         Console.WriteLine("Minimum Salary");
         repo.FindMinSalary();
        break;
    case 8:
         Console.WriteLine("Salary count:");
         repo.countSalary();
         break;
}
Console.ReadKey();