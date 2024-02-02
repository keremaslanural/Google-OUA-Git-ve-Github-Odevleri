//------------------------- Uygulama: If Statement ile oyun örneği

/*-----Oyun Kuralları-----
20'ye kadar sayı olan bir zar.
15-20 arasında büyük zarar.
10-15 arasında orta boyut zarar.
5-10 arasında zarar yok.
0-5 arasında kendimize zarar.
4. veya 5. zar 18 üzerinde gelirse ekstra zarar.
 */

Random zar = new Random(); //Stateless Random class'ından Instantiation ile bir örnek oluşturduk.

//zar.Next(0, 20); //Random class'ının Next fonksiyonu belirli bir aralıkta sayı döndürür.

int birinciAtis = zar.Next(1, 21);
int ikinciAtis = zar.Next(1, 21);
int ucuncuAtis = zar.Next(1, 21);
int dorduncuAtis = zar.Next(1, 21);
int besinciAtis = zar.Next(1, 21);

float ortalama = (birinciAtis + ikinciAtis + ucuncuAtis) / 3f;

Console.WriteLine("Attığın Sayılar: " + birinciAtis + " " + ikinciAtis + " " + ucuncuAtis + " " + dorduncuAtis + " " + besinciAtis);
Console.WriteLine("Ortalama: " + ortalama);

if (ortalama > 15)
{
    Console.WriteLine("Canavara büyük zarar verdin.");
}
else if(ortalama > 10 && ortalama <=15) //alternatif olasılıklar else-if
{
    Console.WriteLine("Canavara orta zarar verdin."); 
}
else if (ortalama > 5 && ortalama <= 10)
{
    Console.WriteLine("Canavara zarar veremedin.");
}
else if (ortalama > 2 && ortalama <= 5)
{
    Console.WriteLine("Kendine zarar.");
}
else //en son olasılık else
{
    Console.WriteLine("Canavar seni öldürdü."); //ortalama < 2 olduğu durumda else çalışır.
}

if(dorduncuAtis >= 18 || besinciAtis >= 18)
{
    Console.WriteLine("Canavara ekstra zarar verdin.");
}

if(ortalama >= 10) //Nested if yapısı örneği.
{
    Console.WriteLine("Özel güç 1/3");
    if(birinciAtis > 12)
    {
        Console.WriteLine("Özel güç 2/3");
        if (ikinciAtis > 15)
        {
            Console.WriteLine("Özel güç 3/3");
            Console.WriteLine("Özel güç çağırıldı!");
        }
        else if(ikinciAtis > 12)
        {
            Console.WriteLine("Özel güç çağırılamadı fakat bir goblin\nordusu canavarın dikkatini dağıttı!");
        }
    }
}

Console.ReadLine(); 



