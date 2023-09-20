namespace dongulerforloop;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir Sayi Giriniz");
        int sayac = int.Parse(Console.ReadLine());

        for(int a = 0; a <= sayac; a++)
        {
            if(a%2 == 1)
            Console.WriteLine(a);
        }


        // 1 ile n arsaındaki tek ve çift sayıların toplamı
         Console.Write("Bir Sayı Giriniz");
         int n = int.Parse(Console.ReadLine());   
        int tektoplam = 0;
        int çifttoplam = 0;
        for (int b = 0; b <= n; b++)
        {
            if(b%2 == 1)
              tektoplam += b;
            else
              çifttoplam += b;  

        }

        Console.WriteLine("Tek toplam " + tektoplam);
        Console.WriteLine("Çift toplam " + çifttoplam );

        // break; continue;

        for (int i = 1; i < 10; i++)
        {
            if(i==4)
             break;
            Console.WriteLine(i);
        } 

        for (int i = 1; i < 10; i++)
        {
            if(i==4)
             continue;
            Console.WriteLine(i);
        }
        
    }
}
