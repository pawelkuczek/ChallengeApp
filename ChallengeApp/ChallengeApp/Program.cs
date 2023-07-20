string name = "Paweł";
bool isMan = true;
int age = 27;

if (isMan == false && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33 && isMan == false)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (isMan == true && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine($"Cześć, oto Twoje dane: imię - {name}, wiek - {age}, płeć - {(isMan ? "mężczyzna" : "kobieta")}");
}

