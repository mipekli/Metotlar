﻿// erişim belirteci  geri dönğş tipi metot adı
//{
// komutlar;

// return;
//}

int a = 2;
int b = 3;

Console.WriteLine(a + b);


int sonuc = Topla(a, b);
Console.WriteLine(sonuc);

metotlar ornek = new metotlar();
ornek.EkranaYazdir(Convert.ToString(sonuc));


int sonuc2 = ornek.ArttirVeTopla(ref a,ref b);
ornek.EkranaYazdir(Convert.ToString(sonuc2));
ornek.EkranaYazdir(Convert.ToString(a+b));


 static int Topla(int d,int dd)
{
    return d + dd;
}

class metotlar
{
  public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);

    }

  public int ArttirVeTopla( ref int d, ref int dd)
  {
      d += 1; 
      dd += 1;
      return d + dd;

  }
}
