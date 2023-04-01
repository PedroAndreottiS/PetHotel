// See https://aka.ms/new-console-template for more information






Console.WriteLine("Qual é a espécie do seu animal? ");
String especie = Console.ReadLine()!;
Console.WriteLine("Qual é a raça?");
String Raca = Console.ReadLine()!;
Console.WriteLine("Qual é o nome do seu Pet? ");
String Nome = Console.ReadLine()!;
Console.WriteLine("Qual é a idade do seu Pet? ");
String Idade = Console.ReadLine()!;
Console.WriteLine("Qual é a cor do seu animal? ");
String Cor = Console.ReadLine()!;

Console.WriteLine("+=========================================================+");
Console.WriteLine("|                     Pet Hotel Vasco                     |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| espécie: {especie.PadLeft(18,'.')} | Raça:{Raca.PadLeft(20,'.')} |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Atende pela alcunha de: {Nome.PadLeft(31,'.')} |");
Console.WriteLine($"| Idade: {Idade.PadLeft(3, '.')} | Cor: {Cor.PadLeft(37,'.')} |");
Console.WriteLine("+=========================================================+");