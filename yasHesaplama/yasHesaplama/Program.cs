using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen doğum tarihinizi girin (YYYY-AA-GG):");

        
        string input = Console.ReadLine();

    
        if (!DateTime.TryParse(input, out DateTime dogumTarihi))
        {
            Console.WriteLine("Geçerli bir tarih formatı giriniz! (YYYY-AA-GG)");
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
            return;
        }

        int yas = CalculateAge(dogumTarihi);

       
        Console.WriteLine($"Yaşınız: {yas}");

        if (yas < 18)
        {
            Console.WriteLine("Henüz reşit değilsiniz.");
        }
        else if (yas >= 18 && yas < 65)
        {
            Console.WriteLine("Çalışma çağındasınız.");
        }
        else
        {
            Console.WriteLine("Emeklilik çağında olabilirsiniz.");
        }

        Console.WriteLine("Programı kapatmak için bir tuşa basın...");
        Console.ReadKey();
    }


    static int CalculateAge(DateTime dogumTarihi)
    {
        {
            DateTime today = DateTime.Now;
            int yas = today.Year - dogumTarihi.Year;


            if (dogumTarihi.Date > today.AddYears(-yas))
            {
                yas--;
            }

            return yas;
        }
    }
}