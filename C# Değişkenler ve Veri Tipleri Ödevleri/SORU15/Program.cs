namespace SORU15;

class Program
{
    static void Main(string[] args)
    {
        // string'den bool'a dönüşüm
        string trueString = "True";
        bool stringToBool = bool.Parse(trueString);
        Console.WriteLine("String'den Bool'a: " + stringToBool);
    }
}
