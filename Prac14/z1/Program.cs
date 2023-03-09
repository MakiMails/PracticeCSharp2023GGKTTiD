class Program
{
    delegate string WorkText(string text);
    static event WorkText events;

    static void Main()
    {
        events += TextToUpper;
        events += TextToLower;
        events += TextReverse;
        //2 задание
        WorkEvent(events, "sdfsd");
    }

    static string TextToUpper(string text) => text.ToUpper();
    static string TextToLower(string text) => text.ToLower();
    static string TextReverse(string text)
    {
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    //2 задание
    static void WorkEvent(WorkText workText, string text) =>
        Console.WriteLine(workText?.Invoke(text));
}
