using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
 public class Araba
 {
  protected string renk;
  protected string model;
  protected byte vites;
  protected bool vitesTuru;

  public Araba()
  {
   renk = "beyaz";
   vites = 0;
   vitesTuru = false;
  }

  public Araba(string r, string m, byte v, bool vT)
  {
   renk = r; // �n�ne this koyulabilir.
   model = m;
   this.vites = v;
   this.vitesTuru = vT;
  }

  public void Yaz()
  {
   Console.WriteLine("Araban�n rengi : {0}", renk);
   Console.WriteLine("Araban�n modeli : {0}", model);
   Console.WriteLine("Araban�n vites say�s� : {0}", vites);
   Console.WriteLine("Araban�n vites t�r� : {0}", vitesTuru.ToString());
  }

  // Alt s�n�flarda ezdirilecek fonksiyon
  public virtual int[] Lastik()
  {
   int[] ebat = { 55, 16 };
   return ebat;
   //return new int[]{1,2,3};
  }

 }

 // Kamyon s�n�f� Araba s�n�f�ndan t�retiliyor
 public class Kamyon : Araba
 {
  private bool damper;
  public static string kamyonArkasiYazisi;

  public bool Damper // Kaps�lleme:Encapsulation
  {
   get { return damper; }
   set { damper = value; }
  }

  // parametreli kurucu
  public Kamyon(string r, string m, byte v, bool vT, bool d)
   : base(r, m, v, vT)
  {
   this.damper = d;
  }

  public void Yaz2()
  {
   base.Yaz(); // kal�t�m al�nan s�n�ftaki Yaz() fonksiyonu
   Console.WriteLine("Araban�n damperi var m�? : " + damper.ToString());
  }

  // Polymorphism (�ok bi�imlilik) virtual, override
  // Araba s�n�f�ndaki Lastik fonksiyonu ezildi.
  public override int[] Lastik()
  {
   int[] ebat = { 85, 35 };
   return ebat;
  }

  public static int KalanMesafe()
  {
   int alinanYol = 100;
   int toplamYol = 1200;
   return toplamYol - alinanYol;
  }
 }

 class Program
 {
  static void Main(string[] args)
  {
   Araba araba = new Araba(); // araba nesnesi
   araba.Yaz();
   //int[] ebatlar = araba.Lastik();
   Console.WriteLine("Araba lastik ebatlar� : {0},{1}",
    araba.Lastik()[0], araba.Lastik()[1]);
   Araba araba2 = new Araba("K�rm�z�", "Toyota Corolla", 6, false);
   araba2.Yaz();
   //Kamyon kamyon = new Kamyon();
   //Hata verir. ��nk� parametresiz kurucu mevcut de�il.
   Kamyon kamyon = new Kamyon("Siyah", "MAN", 6, false, true);
   kamyon.Yaz2();
   int[] ebatlar = kamyon.Lastik();
   Console.WriteLine("Kamyon lastik ebatlar� : {0},{1}",
    ebatlar[0], ebatlar[1]);

   // static de�i�kenler sadece s�n�f ismiyle �a�r�labilir.
   // nesne ile �a�r�lamazlar.
   Kamyon.kamyonArkasiYazisi = "Hatal�ysam aram�zda kals�n!";
   Console.WriteLine(Kamyon.kamyonArkasiYazisi);
   Console.WriteLine(Kamyon.KalanMesafe() + " km yol kalm��t�r.");
  }
 }
}
