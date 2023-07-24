using ChallengeApp;

var employee = new Employee("Paweł", "Kuczek");
employee.AddGrade("4,6");
employee.AddGrade(5);
employee.AddGrade(2.55);
employee.AddGrade('2');

//var statistics1 = employee.GetStatisticsWithForEach();
//var statistics2 = employee.GetStatisticsWithFor();
//var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics = employee.GetStatisticsWithWhile();
Console.WriteLine($"Statystyki pracownika: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Sum of grades: {statistics.SumOfGrades:N2}");

