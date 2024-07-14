// Напишите программу, 
// которая на вход принимает два числа и выводит,
// какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (firstNumber > secondNumber)
    {
        System.Console.WriteLine("Первое число больше");
    }
    else
    {
        System.Console.WriteLine("Второе число больше");
    }
}