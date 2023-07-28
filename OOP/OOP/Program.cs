using OOP.Abstraction;
using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.Polymorphism;

Employee employee = new Employee();
EmployeeInformation employeeInformation = new EmployeeInformation("Hello World",0,"John");
IPM pM = new IPM();
PMM pMM = new PMM();
ClassA classA = new ClassA();
ClassB classB = new ClassB();
employee.SetEmail("oopexample@gmail.com");
employee.SetPhone("056321548652");
employee.SetAge(30);
employee.SetName("S");

employeeInformation.Print();

Console.WriteLine(employee.GetAge());
Console.WriteLine(employee.GetEmail());
Console.WriteLine(employee.GetPhone());
Console.WriteLine(employee.GetName());

pM.Print();
pMM.Print();
classA.Print();
classB.Print();
