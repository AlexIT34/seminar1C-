// Console.WriteLine("Введите трёхзначное число: ");
Console.Write("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine()!);

int a = num % 10;

System.Console.WriteLine($"Последнее цифра {a}");

