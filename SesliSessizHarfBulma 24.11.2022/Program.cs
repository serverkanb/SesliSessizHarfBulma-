using System.Reflection.Metadata.Ecma335;

namespace SesliSessizHarfBulma_24._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelime:  ");
            string kelime = Console.ReadLine();
            Console.WriteLine("Sesli Mi(1)?,Sessiz Mi(2)? ");
            string sesliSessiz = Console.ReadLine().ToLower();
            string sonuc = "";

            string[] sesliharfler = new string[8]
            {
                "a","e","ı","i","o","ö","u","ü"
            };

            if (sesliSessiz == "1")
            {

                sonuc = SesliBul(kelime, sesliharfler);
                Console.WriteLine(sonuc);
            }
            else
            {
                sonuc = Sessizbul(kelime, sesliharfler);
                Console.WriteLine(sonuc);
            }




        }

        static string SesliBul(string kelime, string[] sesliler)
        {
            string sonuc = "";
            int sayac = 0;
            foreach (char kelimeKarakter in kelime)
            {

                foreach (string sesli in sesliler)
                {
                    if (kelimeKarakter.ToString() == sesli)
                    {
                        sayac++;
                        if (!sonuc.Contains(kelimeKarakter))
                        {
                            sonuc += kelimeKarakter;
                        }

                        break;
                    }
                }
            }
            return sonuc;

        }

        static string Sessizbul(string kelime, string[] sesliler)
        {
            string sonuc = "";
            int sayac = 0;
            bool sessizBulundu;
            foreach (char kelimekarakter in kelime)
            {
                sessizBulundu = false;
                foreach (string sesli in sesliler)
                {
                    if (kelimekarakter.ToString() == sesli)
                    {
                        sessizBulundu = false;
                        break;
                    }
                }
                if (sessizBulundu)
                {
                    sayac++;
                    if (!sonuc.Contains(kelimekarakter))
                        sonuc += kelimekarakter;
                }
            }
            return sonuc + "(" + sonuc + ")";
        }
    }
}