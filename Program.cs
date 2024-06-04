using BankInterfaces;


        IBank yapıKrediBank = new yapıKrediBank();
        IBank isBank = new isBank();
        IBank ziraatBank = new ziraatBank();
        IBank akbank = new akbank();

        Console.WriteLine("Kredi tutarınızı giriniz:  ");
        decimal miktar = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ay sayısını girin: 1 , 3 , 6 , 12 , 24 , 36 , 48 : ");
        int ay = int.Parse(Console.ReadLine());

        Console.WriteLine("Banka seçin:");
        Console.WriteLine("1 = YapıKredi Bankası");
        Console.WriteLine("2 = İş Bankası ");
        Console.WriteLine("3 = Ziraat Bankası ");
        Console.WriteLine("4 = Akbank Bankası");
        int bankSecimi = int.Parse(Console.ReadLine());

        if (bankSecimi == 1)
        {
            yapıKrediBank.GetCredit(miktar, ay);
        }
        else if (bankSecimi == 2)
        {
            isBank.GetCredit(miktar, ay);
        }
        else if (bankSecimi == 3)
        {
            ziraatBank.GetCredit(miktar, ay);
        }
        else if (bankSecimi == 4)
        {
            akbank.GetCredit(miktar, ay);
        }
        else
        {
            Console.WriteLine("Geçersiz banka seçtiniz");
        }