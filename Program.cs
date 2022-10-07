// See https://aka.ms/new-console-template for more information
using Emplyeewageapp;

Console.WriteLine("Hello, World!");

employeewage obj = new employeewage();
obj.empwagecount();
employee.Empattendance();
partimeemp.Partime();
empswitch.Switch();
Wages.Ctc();
Wages2.Ctc2();

Refractor.computeRefractor();
MultipleCompanies.computeMultipleCompanies("DMart", 30, 21, 168);
MultipleCompanies.computeMultipleCompanies("Reliance", 25, 25, 100);
TotalWagesBuilderObject dmart = new TotalWagesBuilderObject("DMart", 30, 21, 168);
TotalWagesBuilderObject reliance = new TotalWagesBuilderObject("Reliance", 25, 25, 100);
dmart.computeTotalWages();
Console.WriteLine(dmart.ToString());
reliance.computeTotalWages();
Console.WriteLine(reliance.ToString());
