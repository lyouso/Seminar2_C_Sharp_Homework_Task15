Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
DayOfTheWeek(number);

void DayOfTheWeek(int number1)
{
   while (number1 <= 7)
   {
       if (number1 < 6) Console.WriteLine(number1 + " - это будний день");
       else Console.WriteLine(number1 + " - это выходной");
       break;
   }

}