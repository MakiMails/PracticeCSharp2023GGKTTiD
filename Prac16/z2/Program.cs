using z2.Model;

MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

myDictionary.Add(0, "Obj 1");
myDictionary.Add(1, "Obj 2");
myDictionary.Add(2, "Obj 3");
myDictionary.Add(1, "Obj 4"); 

for(int i = 0; i < myDictionary.Length; i++)
{
    Console.WriteLine(myDictionary[i]);
}

Console.WriteLine($"Size myDictionary {myDictionary.Length}");
