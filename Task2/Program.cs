// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10;10]. Замените все отрицательные элементы
// на положительные, а положительные на отрицательные.

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,11);
    System.Console.Write(array[i]+ "\t");    
}

System.Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    System.Console.Write(array[i]+ "\t"); 
}