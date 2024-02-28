// Найдите произведение пар чисел в массиве.
// Пары - первый и последний, второй и предпоследний и т.д.
// Результат в новый массив

System.Console.WriteLine("Введите размер массива:");            
int size = Convert.ToInt32(Console.ReadLine());                 //Конвертация в целочисленное значение размера массива          4

int[] array = new int[size];                                    //Определение ячеек по размеру массива                          4 (0, 1, 2, 3)
int[] array2 = new int[size/2];                                 //Определение ячеек для второго массива /2                      2 (0, 1)
int middle = 0;                                                 //Введение переменной для средней цифры при нечетном кол-ве
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,11);                       //Случайное заполнение массива от -10 до 10
    System.Console.Write(array[i]+ "\t");                       //Вывод значений массива через табуляцию
}

System.Console.WriteLine();

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array[i] * array[size-1-i];                     //Присваивает для каждого элемента нового массива произведение
    System.Console.Write(array2[i]+ "\t");                      //первого элемента исходного массива и последнего элемента
    if (i == array2.Length - 1)                                 //исходного массива. Для 4 элемента его индекс будет 3, т.е.
    {                                                           //size - 1
        middle = array[i+1];
    }
}
System.Console.WriteLine(" ");
if (size % 2 > 0)                                               //Проверяем четное ли у нас кол-во элементов в новом массиве
{
    System.Console.WriteLine($"Число {middle} не имеет пару!");
}