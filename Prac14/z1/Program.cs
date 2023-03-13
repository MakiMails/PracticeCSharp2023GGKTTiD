class Program
{
    delegate string WorkText(string text);
    static event WorkText events;

    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();
        
        events += TextToUpper;
        events += TextToLower;
        events += TextReverse;
        
        WorkEvent(events, text);
    }

    static string TextToUpper(string text) => text.ToUpper();
    static string TextToLower(string text) => text.ToLower();
    static string TextReverse(string text)
    {
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    
    static void WorkEvent(WorkText workText, string text) =>
        Console.WriteLine(workText?.Invoke(text));
}
