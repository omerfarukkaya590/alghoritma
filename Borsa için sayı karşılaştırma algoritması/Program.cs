using System;

System.Console.WriteLine("**********BORSA**********");
System.Console.WriteLine("*********LÜTFEN BİRİNCİ DİZİNİN ELEMAN SAYISINI GİRİNİZ.*********");
int n =int.Parse(Console.ReadLine());
System.Console.WriteLine("**********LÜTFEN BİRİNCİ DİZİDEKİ SAYILARI GİRİNİZ***********");
var w= Console.ReadLine().Split(' ');
System.Console.WriteLine("**********LÜTFEN İKİNCİ DİZİDEKİ SAYILARI GİRİNİZ***********");
var yy= Console.ReadLine().Split(' ');
int o =0;
while (o<n)
{
    int sonuc1 =0;
    int sonuc2=0;
   sonuc1= Convert.ToInt32(w[o])/Convert.ToInt32(yy[o]);
   sonuc2= Convert.ToInt32(w[o])/Convert.ToInt32(yy[o+1]);
   if (sonuc1>sonuc2)
   {
    System.Console.WriteLine(sonuc1);
   }
   if (sonuc2>sonuc1)
   {
    System.Console.WriteLine(sonuc2);
   }
   o++;
}





