// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Console.WriteLine("Hello, World!");

var employeesChimera = new List<Employee>()
{
    new() {Id=1, Name="Yurii Lukashenko"},
    new() {Id=2, Name="Eddie Piers"},
    new() {Id=3, Name="Walter Bleda"},
    new() {Id=4, Name="Viera Yaa"},
    new() {Id=5, Name="Ada Katalin"},
    new() {Id=6, Name="Thandi Fritjof"},
    new() {Id=7, Name="Shadrach Ivan"},
    new() {Id=8, Name="Taalay Nkechinyere"},
    new() {Id=9, Name="Ciriaco Calypso"},
    new() {Id=10, Name="Fabiano Arcadia"},
};

var employeesHelios = new List<Employee>()
{
    new() {Id=6, Name="Thandi Fritjof"},
    new() {Id=7, Name="Shadrach Ivan"},
    new() {Id=8, Name="Taalay Nkechinyere"},
    new() {Id=9, Name="Ciriaco Calypso"},
    new() {Id=10, Name="Fabiano Arcadia"},
    new() {Id=11, Name="Albaweniz Halle"},
    new() {Id=12, Name="Gittan Ermis"},
};

static int EmployeeSelector(Employee employee) => employee.Id;

var employeesExcepted = employeesChimera.ExceptBy(employeesHelios.Select(EmployeeSelector), EmployeeSelector);

foreach (var employee in employeesExcepted)
{
    Console.WriteLine($"Id:{employee.Id}, Name: {employee.Name}");
}