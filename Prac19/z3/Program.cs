using System.Collections.Generic;
using z3.Model;

Diary diary = new Diary("MakiMails",
    new IdInfo(12412));
Console.WriteLine("------------------");
Console.WriteLine("Shallow copy:");
diary.Add("1 record in diary.");
Diary diary1 = diary.ShallowCopy();
diary1.Add("2 record in diary copy.");
Console.WriteLine(diary1);
Console.WriteLine(diary);
Console.WriteLine("------------------");
Console.WriteLine("Deep copy:");
Diary diary2 = diary.DeepCopy();
Console.WriteLine(diary2);
Console.WriteLine(diary);
diary2.Add("3 record in diary copy.");
Console.WriteLine(diary);
Console.WriteLine("------------------");
Console.WriteLine();
Console.WriteLine("==================");
Console.WriteLine("Records in diary: ");
WriteDictionary(diary.Records);
Console.WriteLine();
Console.WriteLine("Records in diary1: ");
WriteDictionary(diary1.Records);
Console.WriteLine();
Console.WriteLine("Records in diary2: ");
WriteDictionary(diary2.Records);
Console.WriteLine("==================");


void WriteDictionary(Dictionary<int,Record> d)
{
    foreach (var couple in d)
    {
        Console.WriteLine($"Key: {couple.Key} Value: \n{couple.Value}");
    }
}
