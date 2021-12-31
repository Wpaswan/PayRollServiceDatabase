using EmployeePayrollService;

Console.WriteLine("Welcome to Employee Payroll!");
EmployeeRepo repo = new EmployeeRepo();
EmployeeModel employee = new EmployeeModel();
employee.EmployeeName = "Mohan";
employee.Department = "Tech1";
employee.PhoneNumber = "6302907678";
employee.Address = "02-Patna";
employee.Gender = 'M';
employee.BasicPay = 10000.00M;
employee.Deductions = 1500;
employee.StartDate = Convert.ToDateTime("2020-11-03");
employee.City ="Madhubani";
employee.Country ="India";

if (repo.AddEmployee(employee))
    Console.WriteLine("Records added successfully");
employee.EmployeeName = "Dablu";
employee.Department = "It";
employee.PhoneNumber = "7865432123";
employee.Address = "02-Ranchi";
employee.Gender = 'M';
employee.BasicPay = 10000.00M;
employee.Deductions = 1500;
employee.StartDate = Convert.ToDateTime("2022-04-03");
employee.City ="Bokaro";
employee.Country ="India";
if (repo.AddEmployee(employee))
    Console.WriteLine("Records added successfully");
employee.EmployeeName = "Terissa";
employee.Department = "Science";
employee.PhoneNumber = "7865432123";
employee.Address = "02-xyz";
employee.Gender = 'F';
employee.BasicPay = 10000.00M;
employee.Deductions = 1500;
employee.StartDate = Convert.ToDateTime("2022-04-03");
employee.City="Abc";
employee.Country ="Wxy";
if (repo.AddEmployee(employee))
    Console.WriteLine("Records added successfully");
repo.GetAllEmployee();
Console.ReadKey();