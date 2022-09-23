using GenericClass;

GenericList<int> genericListInt = new GenericList<int>();
genericListInt.Add(1);
genericListInt.Add(5);
foreach (int item in genericListInt.getList())
{
    Console.WriteLine(item);
}

GenericList<string> genericListString = new GenericList<string>();
genericListString.Add("hollo");
genericListString.Add("moin");
Console.WriteLine(genericListString.getItem(1));
