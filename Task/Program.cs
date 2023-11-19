int getFromUserArraySize(int count = 3)
{
    int size;
    string inputSize = "Введите размер массива: ";
    Console.Write(inputSize);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    if (int.TryParse(Console.ReadLine(), out size) && size > 0 && size < int.MaxValue)
    {
        Console.ResetColor();
        return size;
    }
    else if (count != 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ошибка ввода! Вы попытались указать размер массива в виде текста, символа, отрицательного числа,\nлибо введенное число привело к переполнению типа ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("int (целочисленного типа данных)!");
        Console.ResetColor();
        Console.WriteLine($"Повторите ввод. Количество попыток - {count}");
        return getFromUserArraySize(count - 1);
    }
    else
    {
        size = new Random().Next(1, 9);
        Console.WriteLine($"Размер массива [{size}] - сформирован автоматически!");
    }
    Console.ResetColor();
    return size;
}
void FillArray(string?[] array)
{
    Console.Write("Заполните массив текстом.\nДля сохранения текста нажмите клавишу ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Enter");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{i}] ");
        array[i] = Console.ReadLine();
    }
}
string[] FindStringOfThreeSymbol(string[] array)
{
    string temp = string.Empty;
    int j = 0, count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        temp = array[i];
        if (temp.Length <= 3)
        {
            count++;
        }
    }
    string[] resultArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        temp = array[i];
        if (temp.Length <= 3)
        {
            resultArray[j] = temp;
            j++;
        }
    }
    return resultArray;
}
