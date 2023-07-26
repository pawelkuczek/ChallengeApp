using ChallengeApp;
Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Paweł", "Kuczek", 'M');
employee.GradeAdded += EmployeeGradeAdded;

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    {
        if (input == "q" || input == "Q")
            break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Statystyki pracownika: {employee.Name} {employee.Surname}");
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"MIN: {statistics.Min}");
Console.WriteLine($"MAX: {statistics.Max}");
Console.WriteLine($"AVERAGE LETTER: {statistics.AverageLetter}");
Console.WriteLine($"SUM OF GRADES: {statistics.SumOfGrades}");
Console.WriteLine($"GRADES COUNT: {statistics.Count}");


void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}