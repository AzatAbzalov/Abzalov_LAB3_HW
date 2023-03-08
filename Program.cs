//Вариант 1

Vector x = new(6);
Console.WriteLine($"Введите вектор из {x.Array.Length} чисел");
x.InpVector();
Console.WriteLine("Массив: " + x);
Console.WriteLine("Введите индекс эл-а: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Эл-т с индексом {i} = {x.ElementReturn(i)}");


Console.WriteLine("Введите индекс эл-а: ");
i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите новое значение эл-а: ");
double new_element = Convert.ToDouble(Console.ReadLine());
x.ElementChange(i, new_element);
Console.WriteLine("Массив: " + x);


Vector y = new(6);
y.VectorRandom(-100, 100);
Console.WriteLine("Рандомный массив: " + y);

double z = 2;
if (x.LineSearch(z) == -1) Console.WriteLine($"Эл-а {z} нет");
else Console.WriteLine($"Индекс эл-а {z} = {x.LineSearch(z)}");

if (x.CheckSort()) Console.WriteLine("Массив отсортирован по возрастанию");
else Console.WriteLine("Массив не отстортирован");

int index = 0;
z = 2;
if (x.CheckSort())
{
    index = x.BinarySearch(z);
    if (index == -1) Console.WriteLine($"Элемент {z} отсутствует");
    else Console.WriteLine($"Индекс эл-а {z} = {index}");
}

Vector x2 = new(x.Array);
x2.RightShiftOnePos();
Console.WriteLine($"Массив, со сдвигом вправо на 1: " + x2);

if (x.NegativeElOnEvenPl()) Console.WriteLine("В массиве все элементы с четными индексами отрицательные");
else Console.WriteLine("В массиве среди эл-ов с чётными индексами есть неотрицательные");

Vector a = new(6);
Console.WriteLine($"Введите вектор из {a.Array.Length} чисел");
a.InpVector();
Console.WriteLine("Массив: " + a);
int l = 0;
int r = a.Array.Length - 1;
Vector.MergeSort(a.Array, l, r);
Console.WriteLine(a);






