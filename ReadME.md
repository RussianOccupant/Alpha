string[] array = {"Hello", "World", "and", "two", "my", "favorite", "friends", "!"}; Создаем массив из строчных выражений
Console.Write("[ "); создаем левую скобку для красоты

for (int i = 0; i < array.Length; i++) создаем цикл, который будет пробегать по всему массиву
{
    string count = array[i]; добавляем стринговую переменную, приравниваем ей значение массива
    if (count.Length <= 3) проверяем меньше либо равно 3 значение массива 
    {
        Console.Write($"{count} "); выводим то, что попадает в условие
    }
}
Console.Write("]"); определяем правую скобку для красоты