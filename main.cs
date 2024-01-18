Console.WriteLine("Şifreniz Oluşturuluyor lütfen bekleyiniz.");
System.Threading.Thread.Sleep(4000);

string sifreİcerigi = "abcçdefgğhıijklmnoöprsştuüvyzABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ0123456789?*_-";

Random random = new Random();
int sifreninUzunlugu = random.Next(6, 13);
string sifreSonHali = "";

for(int i = 0; i<sifreninUzunlugu; i++)
{
    int randomKarakter = random.Next(sifreİcerigi.Length);

    System.Threading.Thread.Sleep(1000);

    Console.WriteLine(sifreİcerigi[randomKarakter]);
    sifreSonHali = sifreSonHali + sifreİcerigi[randomKarakter];
}

Console.WriteLine(sifreSonHali);

if(sifreninUzunlugu >= 10)
{
    Console.WriteLine("Güvenilir bir şifre oluşturuldu.");
} else if (sifreninUzunlugu >= 8 && sifreninUzunlugu <= 9)
{
    Console.WriteLine("Orta düzeyde bir şifre oluşturuldu.");
} else
{
    Console.WriteLine("Zayıf bir şifre oluşturuldu.");
}