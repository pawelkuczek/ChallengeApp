using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Jan", "Kowalski", 'M');
employee.GradeAdded += EmployeeGradeAdded;

try
{

    employee.AddGrade(100);
    employee.AddGrade("80");
    employee.AddGrade(99.5);
    employee.AddGrade('C');

}
catch (Exception e)
{
    Console.WriteLine(e.Message.ToString());
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Statystyki pracownika: {employee.Name} {employee.Surname}");
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"MIN: {statistics.Min}");
Console.WriteLine($"MAX: {statistics.Max}");
Console.WriteLine($"SUM OF GRADES: {statistics.SumOfGrades}");
Console.WriteLine($"AVERAGE LETTER: {statistics.AverageLetter}");


void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

