using System;

Console.Write("First Name> ");
string firstName = Console.ReadLine();

Console.Write("Last Name> ");
string lastName = Console.ReadLine();

Console.WriteLine($"{lastName} {firstName}");

string reverse = string.Empty;
string fullName = firstName + " " + lastName;

for (int i = fullName.Length - 1; i >= 0; i--)
{
    reverse += fullName[i];
}

Console.WriteLine(reverse);

/*
Console.Write("Who would you like to say hello to? ");

string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Fine, don't say 'hello'!");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}
*/