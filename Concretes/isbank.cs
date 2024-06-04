using System.Diagnostics;

namespace BankInterfaces;

public class isBank : IBank
{
    public decimal GetCredit(decimal miktar, int ay)
        {
            decimal faizOrani = GetInterestRate(ay);
            decimal toplamMiktar = miktar * (1 + (faizOrani / 100));
            Console.WriteLine($"Is Bankası: {ay} Ay, Faiz Oranı: {faizOrani}%, Toplam Miktar: {toplamMiktar}");
            return toplamMiktar;
        }

        private decimal GetInterestRate(int ay)
        {
            return ay switch
            {
                1 => 4.0m,
                3 => 5.0m,
                6 => 6.0m,
                12 => 7.0m,
                24 => 8.0m,
        
            };
        }
}