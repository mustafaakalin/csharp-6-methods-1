// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

internal class Program
{
    public static float AlanHesapla(float k_kenar, float u_kenar)
    {
        return k_kenar * u_kenar;
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("alan hesabı için kısa kenar ölçüsü giriniz: ");
        float k_kenar = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("alan hesabı için uzun kenar ölçüsü giriniz: ");
        float u_kenar = Convert.ToSingle(Console.ReadLine());
        // float k_kenar = 5;
        // float u_kenar = 10;
        float alan = AlanHesapla(k_kenar, u_kenar);
        System.Console.WriteLine("Alan: " + alan);
    }
}