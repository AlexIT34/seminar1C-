Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);
int numb = -N;
while (numb <= N)
{
   
    
    Console.Write($"{numb} ,");
    numb += 1;
}
