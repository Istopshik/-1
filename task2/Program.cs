System.Console.WriteLine("Введите, первое число: ");
string firstNumber = Console.ReadLine();
System.Console.WriteLine("Введите, второе число: ");
string secondNumber = Console.ReadLine();
System.Console.WriteLine("Введите, третье число: ");
string thirdNumber = Console.ReadLine();
int number1 = Convert.ToInt32(firstNumber);
int number2 = Convert.ToInt32(secondNumber);
int number3 = Convert.ToInt32(thirdNumber);
int max = number1;
if(max >= number2);
else
{
   max = number2;
} 
if(max >= number3);
else
{
    max = number3;
}
System.Console.Write("Самое большое число из указанных: ");
System.Console.Write(max);