using ChallengeApp;

var employee = new Employee("Paweł", "Kuczek");
employee.AddGrade(3);
employee.AddGrade(4);
employee.AddGrade(5);
var statistics = employee.GetStatistics();
Console.WriteLine($"Statystyki pracownika: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:N2}" );
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Sum of grades: {statistics.SumOfGrades}");