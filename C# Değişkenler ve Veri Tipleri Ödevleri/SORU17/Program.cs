namespace SORU17;

class Program
{
    static void Main(string[] args)
    {
        // Byte, short, int ve long tipinde değişkenler oluşturma
        byte byteDeger = 42;
        short shortDeger = 42;
        int intDeger = 42;
        long longDeger = 42;

        // Bellekte kapladıkları alanı yazdırma
        Console.WriteLine("Byte Bellek Alanı: " + sizeof(byte) + " byte");  
        Console.WriteLine("Short Bellek Alanı: " + sizeof(short) + " byte");
        Console.WriteLine("Int Bellek Alanı: " + sizeof(int) + " byte");   
        Console.WriteLine("Long Bellek Alanı: " + sizeof(long) + " byte");  
    }
}
