/*Из имеющегося массива строк формируется массив из строк, длина 
которых меньше либо равна 3 символа.
*/
Console.Clear();

int GetNumberOfLines(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
string[] GetLinesFromUser(string message, int value)
{
    string[] array = new string[value];
    for (int i = 0; i < value; i++)
    {
        Console.WriteLine(message + $"{i + 1}: ");
        array[i] = Console.ReadLine()!;
    }
    Console.WriteLine();
    return array;
}
void DeletingLinesFromArray(string[] array, out string[] arrayNew, out int j)
{
    arrayNew = new string[array.Length];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
}
void PrintOfArray(string[] array, string message, int length)
{
    Console.WriteLine(message + "[");
    for (int i = 0; i < length; i++)
    {
        if (i != length - 1)
            Console.WriteLine($"\"{array[i]}\", ");
        else
            Console.WriteLine($"\"{array[i]}\"");
    }
    Console.WriteLine("]");
    
}
int numberOfLines = GetNumberOfLines("Введите количество строк вашего массива: ");
string[] linesUser = GetLinesFromUser("Введите строку № ", numberOfLines);
PrintOfArray(linesUser, "Ваш строковый массив: ", linesUser.Length);
DeletingLinesFromArray(linesUser, out string[] arrayLines, out int arrayLinesLength);
PrintOfArray(arrayLines, "Массив элементов меньше четыех сиволов: ", arrayLinesLength);