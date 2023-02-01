System.Console.WriteLine("Введите первое число: ");
string firstNumber = Console.ReadLine();
int number1 = Convert.ToInt32(firstNumber);
System.Console.WriteLine("Введите второе число");
string secondNumber = Console.ReadLine();
int number2 = Convert.ToInt32(secondNumber);
if(number1 > number2)
{
    System.Console.WriteLine("Первое число больше, чем второе");
}
else if(number1 == number2)
{
    System.Console.WriteLine("Введеные вами числа равны");
}
else
{
    System.Console.WriteLine("Второе число больше, чем первое");
}