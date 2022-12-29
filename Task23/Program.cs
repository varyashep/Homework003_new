using static System.Console; 

WriteLine("Введите число: ");

int degree = 3;
int base_number;
int n = 1;

if (int.TryParse(ReadLine(), out base_number))
{
    WriteLine($"Кубы чисел от 1 до {base_number}:");
    while (n <= base_number)
    {   
        WriteLine(Math.Pow(n, degree));
        n++;
    }
}
else
{
    WriteLine("Ошибка. Необходимо ввести число.");
}