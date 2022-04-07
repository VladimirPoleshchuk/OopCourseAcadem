using HashTableTask;

Console.WriteLine("Напишите список  ваших друзей.");
Console.Write("Напишите первое имя: ");

HashTable<string> hashTable;

try
{
    hashTable = new HashTable<string>(5, Console.ReadLine());

    bool isNext = true;

    while (isNext)
    {
        Console.WriteLine("Если хотите закончить запись нашжмите цифру - 1, или напишите следующее имя.");

        string name = Console.ReadLine();   

        if (name == "1")
        {
            isNext = false;
            break;
        }
       
        hashTable.Add(name);
    }   
}
catch (Exception)
{
    throw;
}

Console.WriteLine("Нажмите любую клавишу для проверки списка");
Console.ReadKey();

PrintList();

Console.WriteLine("Удалите из списка одну запись: ");

try
{
    if (!hashTable.Remove(Console.ReadLine()))
    {
        Console.WriteLine("В списке нет такой записи!");
    }
    else
    {
        Console.WriteLine("Запись удалена успешно.");
    }
}
catch (Exception)
{
    throw;
}

Console.WriteLine("Нажмите любую клавишу для проверки списка");
Console.ReadKey();

PrintList();

void PrintList()
{
    for (int i = 0; i < hashTable.Count; i++)
    {
        if (hashTable.Items[i] != null)
        {
            Console.WriteLine(String.Join(", ", hashTable.Items[i]));
        }
    }
}