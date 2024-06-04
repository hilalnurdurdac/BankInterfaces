using BankInterfaces;


        IBank yapıKrediBank = new yapıKrediBank();
        IBank isBank = new isBank();

        Console.WriteLine("Kredi tutarınızı giriniz:  ");
        decimal miktar = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ay sayısını girin: 1 , 3 , 6 , 12 , 24 : ");
        int ay = int.Parse(Console.ReadLine());

        Console.WriteLine("Banka seçin (YapıKredi için 1, İş Bankası için 2): ");
        int bankSecimi = int.Parse(Console.ReadLine());

        if (bankSecimi == 1)
        {
            yapıKrediBank.GetCredit(miktar, ay);
        }
        else if (bankSecimi == 2)
        {
            isBank.GetCredit(miktar, ay);
        }
        else
        {
            Console.WriteLine("Geçersiz banka seçtiniz");
        }