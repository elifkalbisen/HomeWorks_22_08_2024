namespace SORU09;

class Program
{
    static void Main(string[] args)
    {
        // string'den int'e dönüşüm
        string sayiString = "42";
        int sayiInt = int.Parse(sayiString); 
        Console.WriteLine("String'den int'e: " + sayiInt);
    }
}
