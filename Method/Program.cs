using System;

namespace Method
{
    class Program
    {
        // Main programının görevi kullanıcında veri almak, bilgiye dönüştürüp çıktı sağlamaktır...
        static void Main(string[] args)
        {
            Console.WriteLine("4 işlem örneği!");

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz( +,-,*,/");
            char islem = Convert.ToChar(Console.ReadLine());

            int[] sayilar = new int[0];
            int i = 0;
            char cevap;
            float islemSonucu = 0;

            do
            {
                Array.Resize(ref sayilar, i + 1);
                Console.WriteLine("Sayı Giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
   

                Console.WriteLine("Yeni Sayı Girmek istiyor musunuz..? E/H");
                cevap = Convert.ToChar(Console.ReadLine());
               
                if (cevap =='E')
                    i++;

            } while (cevap == 'E');

            // todo : bu işlemi n adet sayı için yapan metodu yazınız.. Perşembe gününe kadar gönderiniz...
            // Method çağrılıyor. 
    
            islemSonucu = Islem(islem, sayilar);

            Console.Write($"İşlem Sonucunuz = {islemSonucu}");

            Console.ReadKey();
        }

        // todo:  ascii table nedir. Neden 255 karakter vardır.. araştırınız...Ve Bu programdaki gibi txt dosyasına açıklamasını yazınız...
        private static float Islem(char islem, params int[] sayi)
        {

            float sonuc = 0;
            foreach (var item in sayi)
            {

                switch (islem)
                    {
                    case '+':
                        sonuc += item;
                    break;
                    
                    case '-':
                        sonuc -= item;
                        break;
                    case '*':
                        sonuc *= item;
                        break;
                    case '/':
                        sonuc /= item;
                        break;
                }
            }
            
            return sonuc;
        }
    }



    /**        string liste ="";
            foreach (var item in sayilar)
            {
                liste = liste + item + ",";
            }

*/
}

