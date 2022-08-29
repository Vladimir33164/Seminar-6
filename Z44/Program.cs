//Задача 44: Не используя рекурсию, выведите первые N чисел 
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int countFibonacci = 10;
int firstElement = 0; // i = 1
int secondElement = 1; // i = 2

Console.WriteLine(firstElement); 
Console.WriteLine(secondElement); 
        // i = 3
for(int i = 3; i <= countFibonacci; i++)
{
    int nextElement = firstElement + secondElement;
    Console.WriteLine(nextElement);
    firstElement = secondElement;
    secondElement = nextElement;
}
