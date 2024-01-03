// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Console.WriteLine("Hello, World!");

var employeesChimera = new List<ChimeraEmployee>()
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

var employeesHelios = new List<IntranetEmployee>()
{
    new() {TabCisZamId=6, Name="Thandi Fritjof"},
    new() {TabCisZamId=7, Name="Shadrach Ivan"},
    new() {TabCisZamId=8, Name="Taalay Nkechinyere"},
    new() {TabCisZamId=9, Name="Ciriaco Calypso"},
    new() {TabCisZamId=10, Name="Fabiano Arcadia"},
    new() {TabCisZamId=11, Name="Albaweniz Halle"},
    new() {TabCisZamId=12, Name="Gittan Ermis"},
};


var employeesExcepted = employeesChimera.ExceptBy(employeesHelios.Select(x => x.TabCisZamId), y => y.Id);

foreach (var employee in employeesExcepted)
{
    Console.WriteLine($"TabCisZamId:{employee.Id}, Name: {employee.Name}");
}