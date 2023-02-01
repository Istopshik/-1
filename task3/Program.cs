System.Console.WriteLine("Введите число и программа определит, является ли оно четным: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
if(number % 2==0)
{
    System.Console.WriteLine("Число является четным");
}
else
{
    System.Console.WriteLine("Число ялвяется нечетным");
}