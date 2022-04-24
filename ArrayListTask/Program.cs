using ArrayListTask;

string[] vs = new string[] { "number11", "number22", "number33" };

MyList<string> list = new MyList<string>(vs);

list.Add("number1");
list.Add("number2");
list.Add("number3");



foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------");
Console.WriteLine("-----------");
Console.WriteLine(list.Capacity);
Console.WriteLine(list.Count);

list.Insert(2, "555");

foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("-------------");
Console.WriteLine("-----------");
Console.WriteLine(list.Capacity);
Console.WriteLine(list.Count);

//list.Remove("number22");

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("-----------");

//list.RemoveAt(1);

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("-----------");
//Console.WriteLine(list.Capacity);
//Console.WriteLine(list.Count);

//list.TrimExcess();

//Console.WriteLine("-----------");
//Console.WriteLine(list.Capacity);
//Console.WriteLine(list.Count);

//list.Clear();

//Console.WriteLine("-----------");
//Console.WriteLine(list.Capacity);
//Console.WriteLine(list.Count);

