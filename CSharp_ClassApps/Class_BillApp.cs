using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
 class Program
 {
  static void Main(string[] args)
  {
   Fatura f1 = new Fatura(); // nesne1
   Fatura f2; // Kurucu �al��maz.
   f2 = new Fatura(); // Kurucu �al���r.

   f1.Ad = "�stanbul Yay�nevi";
   f1.Tutar = 35;

   f2.Tutar = f1.Tutar;

   Console.WriteLine(f1.Ad);
   Console.WriteLine(f1.Adres);
   Console.WriteLine(f1.No);
   Console.WriteLine(f1.Tutar);

   int fToplam = f1.Toplam();
   int fToplam2 = f2.Toplam();

   Console.WriteLine(fToplam);
   Console.WriteLine(fToplam2);


  }
 }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
 public class Fatura
 {
  public string Ad;
  public string No;
  public string Adres;
  public int Tutar;

  /*
   * Kurucu fonksiyon class ile ayn� isimde olmaz zorundad�r.
   * Kurucu fonksiyonda ba�lang�� de�erleri tutulur.
   * Herhangi bir de�er geri d�nd�rmez. (return yapmaz.)
   * Nesne olu�turulur olu�turulmaz �al���r. (new yap�ld��� an �al���r)
   */
  public Fatura() // Kurucu fonksiyon (Constructor)
  {
   this.Ad = "Ankara Yay�nevi";
   this.Adres = "K�z�lay/ANKARA";
   this.No = "0-312-344-45-66";
   this.Tutar = 30;
  }


  // Bu kullan�m �ok do�ru de�ildir.
  // Her fonksiyon tek i�levi yerine getirmelidir.
  public int Toplam()
  {
   int Konusma, Mesaj, Diger;
   Console.Write("Konusma Tutar�:");
   Konusma = int.Parse(Console.ReadLine());
   Console.Write("Mesaj Tutar�:");
   Mesaj = int.Parse(Console.ReadLine());
   Console.Write("Diger Tutar:");
   Diger = int.Parse(Console.ReadLine());

   return Konusma + Mesaj + Diger;
  }

 }
}

