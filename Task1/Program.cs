// Задайте массив. Программа определяет, присутствует ли
// заданное число в массиве. Ответ: Да/Нет

int[] array = new int[5];
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string answer = "Нет";

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,17);    
    System.Console.Write(array[i]+ " ");
    if (num == array[i])
    {
        answer = "Да";
    }
}
System.Console.WriteLine(answer);