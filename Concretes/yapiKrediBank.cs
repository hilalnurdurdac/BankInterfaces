namespace BankInterfaces;

public class yapıKrediBank : IBank
{
    public decimal GetCredit(decimal miktar, int ay)
        {
            decimal faizOrani= GetInterestRate(ay);
            decimal toplamMiktar = miktar * (1 + (faizOrani/ 100));
            Console.WriteLine($"YapıKredi Bankası: {ay} Ay, Faiz Oranı: {faizOrani}%, Toplam Miktarı: {toplamMiktar}");
            return toplamMiktar;
        }

        private decimal GetInterestRate(int ay)
        {
            return ay switch
            {
                1 => 3.0m,
                3 => 4.5m,
                6 => 5.0m,
                12 => 8.8m,
                24 => 12.0m,
                36 =>23.0m,
            };
        }
}