using z1.Model;

MyList<int> myList = new MyList<int>();

myList.Add(1);
myList.Add(2);
myList.Add(3);

for (int i = 0; i < myList.Length; i++)
{
    Console.WriteLine(myList[i]);
}

Console.WriteLine($"Size: {myList.Length}");
Console.WriteLine();
Console.WriteLine("Challenge a static method: ");
WriteArray(myList.GetArray());


void WriteArray<T>(T[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
