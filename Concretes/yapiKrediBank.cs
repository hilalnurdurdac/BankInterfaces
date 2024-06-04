namespace BankInterfaces;

public class yapıKrediBank : IBank
{
    public decimal GetCredit(decimal miktar, int ay)
        {
            decimal faizOrani= GetInterestRate(ay);
            decimal toplamMiktar = miktar * (1 + (faizOrani/ 100));
            Console.WriteLine($"YapıKrediBank: {ay} ay, Faiz Orani: {faizOrani}%, Toplam Miktar: {toplamMiktar}");
            return toplamMiktar;
        }

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
}