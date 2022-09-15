using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        // 1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        
        int boyut;
        ArrayList ciftSayilar1 = new ArrayList();
        Console.Write("Dizi boyutunu giriniz = ");
        boyut = int.Parse(Console.ReadLine());
        int[] sayilar1 = new int[boyut];
        for (int i = 0; i < sayilar1.Length; i++)
        { 
            Console.Write((i+1)+ ".Sayıyı giriniz = ");
            sayilar1[i] = int.Parse(Console.ReadLine());
            if(sayilar1[i]%2==0)
            {
                ciftSayilar1.Add(sayilar1[i]);
            }
        }
        Console.WriteLine("Girdiğiniz çift sayılar");
        foreach (var item in ciftSayilar1)
        {
            Console.WriteLine(item);
        }


        // 2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        int n;
        int m;
        ArrayList bolunenler2 = new ArrayList();
        Console.Write("n sayısını giriniz= ");
        n = int.Parse(Console.ReadLine());
        Console.Write("m sayısını giriniz= ");
        m = int.Parse(Console.ReadLine());
        int[] sayilar = new int[n];
        for (int i = 0; i < sayilar.Length; i++)
        { 
            Console.Write((i+1)+ ".Sayıyı giriniz = ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }
        foreach (var item in sayilar)
        {
            if(item==m)
            {
                bolunenler2.Add(item);
            }
            else if(m%item==0)
            {
                bolunenler2.Add(item);
            }
        }
        Console.WriteLine("Eşit veya Tam bölenlerin listesi");
        foreach (var item in bolunenler2)
        {
            Console.WriteLine(item);
        }

        // 3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        int sayi3;
        Console.WriteLine("Bir sayı giriniz");
        sayi3=int.Parse(Console.ReadLine());
        string[] kelimeler3 = new string[sayi3];
        for (int i = 0; i < kelimeler3.Length; i++)
        {
            string kelime3;
            Console.WriteLine((i+1)+".Kelimeyi giriniz");
            kelime3=Console.ReadLine();
            kelimeler3[i]=kelime3;
        }
        kelimeler3= kelimeler3.Reverse().ToArray();
        foreach (var item in kelimeler3)
        {
            Console.WriteLine(item);
        }

        // 4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        string cumle4;
        Console.WriteLine("Bir cümle Yazınız:");
        cumle4=Console.ReadLine();
        char[] character4= cumle4.ToCharArray();
        string[] kelimeler4=cumle4.Split(" ");
        Console.WriteLine("Cümledeki harf sayısı:"+ character4.Length);
        Console.WriteLine("Cümledeki kelime sayısı:"+ kelimeler4.Length);


        

    }
}