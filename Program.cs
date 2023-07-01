// Напишите программу, которая на вход принимает (N), а на выходе показывает все четные числа от 1 до N
// 5 -> 2,4
// 8 -> 2,4,6,8

Console.WriteLine("Введите число => ");         // Вывести приглашение на консоль
string inputedString = Console.ReadLine();     // Ввод пользователя в строку
int number2 = Convert.ToInt32(inputedString);   // Приеобразование введенной строки в число
int cnt = 1;
while(cnt <= number2) 
{
    if (cnt % 2 == 0)
    {
        Console.WriteLine(cnt + " ");
    }
    cnt = cnt+1 ;
}




