using static System.Console;

int x0,y0,z0;
int x1,y1,z1;

WriteLine("Введите координаты точки 1 ");
Write("x: ");
x0 = int.Parse(ReadLine()!);
Write("y: ");
y0 = int.Parse(ReadLine()!);
Write("z: ");
z0 = int.Parse(ReadLine()!);

WriteLine("Введите координаты точки 2 ");
Write("x: ");
x1 = int.Parse(ReadLine()!);
Write("y: ");
y1 = int.Parse(ReadLine()!);
Write("z: ");
z1 = int.Parse(ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x1-x0, 2) + Math.Pow(y1-y0, 2) + Math.Pow(z1-z0, 2));

WriteLine($"Расстояние между точками: {distance:f2}");