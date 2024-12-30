using System;

namespace ConsoleApp
{
    class Program
    {
        // Geriye değer döndürmeyen void bir metot
        static void HalimizVeKeyfimiz()
        {
            // "Halimiz itten beter keyfimiz paşada yok" ve "Koy masaya bir duble buzsuz olsun" cümlelerini yazdırma
            Console.WriteLine("Halimiz itten beter, keyfimiz paşada yok.");
            Console.WriteLine("Koy masaya bir duble buzsuz olsun.");
        }

        static void Main(string[] args)
        {
            // HalimizVeKeyfimiz metodunu çağırıyoruz
            HalimizVeKeyfimiz();

            // Kullanıcının bir tuşa basmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
