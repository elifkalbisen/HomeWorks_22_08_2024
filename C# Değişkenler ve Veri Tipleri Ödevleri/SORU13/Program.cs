namespace SORU13;

class Program
{
    static void Main(string[] args)
    {
        // long'dan int'e dönüşüm
        long buyukLongSayi = 500000000000;
        int longToInt = (int)buyukLongSayi;
        Console.WriteLine("Long'dan int'e dönüşüm: " + longToInt);
    }
}
