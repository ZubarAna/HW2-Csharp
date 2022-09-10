/* Задача 10. Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Новое число: " + ((n % 100) / 10));
*/

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

/*Console.Write("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());
string m = Convert.ToString(n);
if (m.Length > 2){
  Console.WriteLine("третья цифра: " + m[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}
*/

/* Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным

Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n<1 || n>7)
{
        Console.Write("Ты ошибся! Попробуй еще раз: ");
        n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
    */

/* Мороженное
Console.Write("Введите число: ");
int k = Convert.ToInt32(Console.ReadLine());
if(k % 3 == 0 || k % 5 == 0 || k % 8 == 0)
    Console.Write("Yes");
else
    Console.Write("No");
*/
