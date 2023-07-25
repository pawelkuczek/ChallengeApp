using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny zarządu");
Console.WriteLine("===========================================");
Console.WriteLine();

var supervisor = new Supervisor("Jan", "Kowalski", 'M');

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę dyrektora: ");
    var input = Console.ReadLine();
    {
        if (input == "q" || input == "Q")
            break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}


var statistics = supervisor.GetStatistics();
Console.WriteLine($"Statystyki dyrektora: {supervisor.Name} {supervisor.Surname}");
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"MIN: {statistics.Min}");
Console.WriteLine($"MAX: {statistics.Max}");

