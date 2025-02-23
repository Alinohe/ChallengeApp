﻿using ChallengeApp;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracownikow");
Console.WriteLine("================================================");
Console.WriteLine();
Console.WriteLine("Podaj Imie Pracownika");

var name = Console.ReadLine();

Console.WriteLine("Podaj Nazwisko Pracownika");

var surname = Console.ReadLine();

var employee = new EmployeeInFile(name, surname);
var employeeInMemory = new EmployeeInFile("In", "Memory");
employeeInMemory.GradeAdded += EmployeeGradeAdded;
//employeeInMemory.AddGrade(60);
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano Nowa Ocene");
}

employee.GradeAdded += EmployeeGradeAdded;

Console.WriteLine($"ocena dla pracownika {employee.Name} {employee.Surname}:");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Podaj ocene pracownika");

while (true)
{
    Console.WriteLine("Podaj kolejna ocene pracownika lub wyjdz naciskajac q");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    else
    {
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception Found: {ex.Message}");
        }
    }
}


var statistics = employee.GetStatistics();
Console.WriteLine($"ocena dla pracownika {employee.Name} {employee.Surname}:");
Console.WriteLine($"Average: {statistics.Average:N2}");// Letter {statistics.AverageLetter()}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

