﻿Console.WriteLine("--- Pet Hotel Check-in ---\n");

Console.Write("Cachorro......: ");
string especie = Console.ReadLine()!;

Console.Write("Vira lata.........: ");
string raca = Console.ReadLine()!;

Console.Write("Bob......: ");
string alcunha = Console.ReadLine()!;

Console.Write("Idade (8).: ");
string idade = Console.ReadLine()!;

Console.Write("Caramelo..: ");
string pelagemCor = Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Pet Hotel \"Nem um pio\"");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                  |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("| Cachorro: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Vira lata: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("| Bob ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(alcunha.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");
Console.Write("| 8 ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Caramelo: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("+=========================================================+");

Console.ResetColor();