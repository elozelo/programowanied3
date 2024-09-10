// See https://aka.ms/new-console-template for more information
Console.Write("Hello, World!");
Console.Write("Hello, World!\n");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

int x = 10;
string name = "Jan";
string surname = "Kowalski";

Console.WriteLine(x);
Console.WriteLine(name);
Console.WriteLine("Witaj " + name + " " + surname + " tutaj");
Console.WriteLine("Witaj {0} {1} tutaj", name, surname);

Console.WriteLine($"Witaj {name} {surname} tutaj");

Console.WriteLine("Predkosc to km\\h");
Console.WriteLine(@"Predkosc to km\h");
Console.WriteLine($@"Predkosc {name} to km\h");

int number = 5;
int secondNumber = number;
secondNumber = 6;
Console.WriteLine($"number = {number}");
Console.WriteLine($"number = {secondNumber}");



void ParametrTest_v1(int p)
{
    
    p++;
    Console.WriteLine($"ParametrTest_v1: p = {p}");
}
void ParametrTest_v2(ref int p)
{
    
    p++;
    Console.WriteLine($"ParametrTest_v2: p = {p}");
}
void ParametrTest_v3(out int p)
{
    
    p++;
    Console.WriteLine($"ParametrTest_v3: p = {p}");
}

ParametrTest_v1(number);
Console.WriteLine($"number = {number}");

ParametrTest_v2(ref number);
Console.WriteLine($"number parametr test 2 = {number}");

int thirdNumber;
ParametrTest_v3(out number);
Console.WriteLine($"number = {thirdNumber}");