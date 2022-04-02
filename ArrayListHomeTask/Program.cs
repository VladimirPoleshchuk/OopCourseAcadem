
string path = @"C:\Users\User\Documents\Text.txt";

try
{
    using StreamReader reader = new StreamReader(path);

    List<string> lines = new List<string>();

    if (reader.ReadLine() == null)
    {
        throw new Exception("Фаил пуст.");
    }
    else
    {
        string? line = reader.ReadLine();

        while (line != null)
        {
            lines.Add(line);

            line = reader.ReadLine();
        }
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("Фаил не найден.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

List<int> numbers = new List<int>() { 1, 9, 2, 3, 4, 4, 5, 6, 7, 8, 9, 9, 10 };

for (int i = 0; i < numbers.ToArray().Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        numbers.RemoveAt(i);

        --i;
    }
}

List<int> uniqueNumbers = new List<int>(numbers);

for (int i = 0; i < uniqueNumbers.Count; i++)
{
    for (int j = i + 1; j < uniqueNumbers.Count; j++)
    {
        if (uniqueNumbers[i] == uniqueNumbers[j])
        {
            uniqueNumbers.RemoveAt(j);

            j--;
        }
    }
}