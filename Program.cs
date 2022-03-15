using System;
namespace csharp_enum
{
    class Program
    {
        static void Main(string[]args)
        {
          Console.WriteLine(Gunler.Pazar);
          Console.WriteLine((int)Gunler.Cumartesi);

          int sicaklik=32;
          if(sicaklik<=(int)HavaDurumu.Normal)
         
              Console.WriteLine("Dışarıya çıkmak için ısınmasını bekleyebilirsiniz !");
              else if(sicaklik>=(int)HavaDurumu.Sicak)
              Console.WriteLine("Dışarıya çıkmak için sıcak bir gün.");
              else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<=(int)HavaDurumu.CokSicak)
              Console.WriteLine("Hadi dışarıya çıkalım.");

         
        }
    }
    enum Gunler 
{
    Pazartesi=1, 
    Sali, 
    Carsamba, 
    Persembe, 
    Cuma=23, 
    Cumartesi, 
    Pazar
}
enum HavaDurumu
{
Soguk=5,
Normal=20,
Sicak=25,
CokSicak=30
}
}
