using System.Reflection.Metadata.Ecma335;

namespace BankInterfaces;

public class akbank : IBank
{
    private decimal GetInterestRate(int ay)
     {
                return ay switch
                {
                    1 => 2.0m,
                    3 => 3.0m,
                    6 => 4.0m,
                    12 => 5.0m,
                    24 => 6.0m,
                };
     }
    public decimal GetCredit(decimal miktar, int ay)
        {
            decimal faizOrani= GetInterestRate(ay);
            decimal toplamMiktar = miktar * (1 + (faizOrani/ 100));
            Console.WriteLine($"Akbank Bankası: {ay} Ay, Faiz Oranı: {faizOrani}%, Toplam Miktarı: {toplamMiktar}");
            return toplamMiktar;
        }


}
