Console.Clear();

Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);

int b = 7;
int c = 23;

int result1 = a % b;
int result2 = a % c;

if (result1 == 0 && result2 == 0)
{
Console.Write($"Число {a} кратно {b} и {c}");
} 

else 
{
Console.Write("Некратно");
}