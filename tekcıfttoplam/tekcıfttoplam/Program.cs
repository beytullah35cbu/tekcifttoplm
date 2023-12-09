using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        Console.Write("TEK'leri mi ÇİFT'leri mi toplamak istersiniz? (T/Ç): ");
        char tercih = char.ToUpper(Console.ReadLine()[0]);


      int toplam=0;

        switch (tercih)
        {
            case 'T': 
                for (int i = 1; i <= sayi; i += 2)
                {
                    toplam += i;
                }
                Console.WriteLine($"1 ile {sayi} arasındaki TEK sayıların toplamı: {toplam}");
                break;

            case 'Ç':
                for (int i = 2; i <= sayi; i += 2)
                {
                    toplam += i;
                }
                Console.WriteLine($"1 ile {sayi} arasındaki ÇİFT sayıların toplamı: {toplam}");
                break;

            default:
                Console.WriteLine("Geçerli bir seçenek girilmedi.");
                break;
        }

        Console.ReadKey();
    }
}
