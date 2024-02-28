// Дано натуральное трехзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд должен располагаться на 0-м
// индексе массива, старший на 2-м.


System.Console.WriteLine("Введите 3-х значное число:");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[3];


for (int i = 0; i < array.Length; i++)
{
    array[i]= num % 10;
    num = num / 10;
    System.Console.Write(array[i]);
}