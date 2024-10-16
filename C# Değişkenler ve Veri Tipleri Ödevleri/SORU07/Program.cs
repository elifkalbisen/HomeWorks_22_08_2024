namespace SORU07;

class Program
{
    static void Main(string[] args)
    {
        // int tipinde büyük bir sayıyı byte'a dönüştürme
        int buyukSayi = 1000000;
        byte byteSayi = (byte)buyukSayi;
        Console.WriteLine("Büyük sayının byte'a dönüşümü: " + byteSayi);
    }
}
