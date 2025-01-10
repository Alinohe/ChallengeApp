using ChallengeApp;

var employee = new Employee("Robert", "Domanski");
employee.AddGrade(54);
employee.AddGrade(46f);
employee.AddGrade(36);
employee.AddGrade(65);
employee.AddGrade(38);
employee.AddGrade(68);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");

