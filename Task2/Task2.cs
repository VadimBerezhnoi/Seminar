Console.Clear();

int num = new Random().Next(100, 1000);  // 100 - 999

Console.WriteLine(num);

int a1 = num / 100;
int a2 = num % 10;

int max = a1;

if (a2 > max)
{
    max = a2;
}

//Console.Write($"{a1}{a2}");