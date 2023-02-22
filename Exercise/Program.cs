string[] array = {"Hello", "World", "and", "two", "my", "favorite", "friends", "!"};
Console.Write("[ ");

for (int i = 0; i < array.Length; i++)
{
    string count = array[i];
    if (count.Length <= 3)
    {
        Console.Write($"{count} ");
    }
}
Console.Write("]");