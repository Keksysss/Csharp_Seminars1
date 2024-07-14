// Напишите программу, 
// которая на вход принимает два числа и выводит,
// какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    System.Console.WriteLine($"a = {firstNumber} большее, b = {secondNumber} меньшее");
}
else
{
    System.Console.WriteLine($"b = {secondNumber} большее, a = {firstNumber} меньшее");
}