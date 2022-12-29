using static System.Console;

int number;
WriteLine("Введите пятизначное число:");
if (int.TryParse(ReadLine(), out number) && number > 999 && number < 100000)
{
    if ((number % 10 == (number / 10000)) && ((number / 10) % 10 == (number / 1000) % 10))
    {
        WriteLine("Число является палиндромом");
    }
    else
    {
        WriteLine("Число не является палиндромом");
    }
}
else
{
    WriteLine("Ошибка. Необходимо ввести пятизначное число.");
}