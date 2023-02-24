// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число N: ");
string N = Console.ReadLine();
int GetSum(string N)
{
int sum=0;
for (int i = 0; i < N.Length; i++)
{
  int B = Convert.ToInt32(N[i].ToString());
  
    sum=sum+B;
}
return sum;
}
Console.WriteLine($"Сумма цифр в числе: {N} = {GetSum(N)}");