namespace BankInterfaces;
public class ziraatBank : IBank
{
    public decimal GetInterestRate(int ay)
        {
            return ay switch
            {
                1 => 2.2m,
                3 => 2.7m,
                6 => 3.5m,
                12 => 5.0m,
                24 => 12.0m,
                36 => 18.0m,
            };
        }
    public decimal GetCredit(decimal miktar, int ay)
   {
    decimal faizOrani= GetInterestRate(ay);
    decimal toplamMiktar = miktar * (1 + (faizOrani/ 100));
    Console.WriteLine($"Ziraat Bankası: {ay} ay, Faiz Orani: {faizOrani}%, Toplam Miktar: {toplamMiktar}");
    return (toplamMiktar);
   }

}


