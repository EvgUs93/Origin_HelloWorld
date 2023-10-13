int number1 =  20;
int number2 = 6;

if (number1%number2 == 0)
{
  System.Console.WriteLine("кратно");
}
else
{
  int number3 = number1%number2;
  System.Console.WriteLine($"некратно, остаток {number3}");
}