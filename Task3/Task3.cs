
Console.Clear();

Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);

int c = a % b;

if (c == 0)
{
    Console.Write("Кратно");
}

else 
{
   Console.Write($"Не кратно, остаток {c}"); 
}