using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    public class IntInputValidator
    {
        public static int GetValidIntInput()
        {
            int result;
            while (true)
            {
                Console.Write("Введите значение: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Ошибка! Неверное значение. Попробуйте снова.");
                }
            }
        }
    }

    public class Money
    {
        private uint rubles;
        private byte kopeks;

        public Money()
        {
            rubles = 0; 
            kopeks = 0; 
        }

        public Money(uint x, byte y)
        {
            rubles = x;
            kopeks = y;
            checking_kopecks();
        }

        // вычитание двух объектов
        public static Money operator -(Money a, Money b)
        {
            uint rublesn;
            byte kopeksn;
            if (a.kopeks >= b.kopeks)
            {
                kopeksn = (byte)(a.kopeks - b.kopeks);
                if (a.rubles >= b.rubles)
                {
                    rublesn = a.rubles - b.rubles;
                }
                else
                {
                    rublesn = 0;
                }
            }
            else
            {
                kopeksn = (byte)(100 - (b.kopeks - a.kopeks));

                if (a.rubles + 1 >= b.rubles)
                {
                    rublesn = a.rubles - b.rubles - 1;
                }
                else
                {
                    rublesn = 0;
                }
            }

            return new Money(rublesn, kopeksn);
        }

        //Унарные операции ++
        public static Money operator ++(Money x)
        {
            x.kopeks++;
            x.checking_kopecks();
            return x;   
        }

        //Унарные операции --
        public static Money operator --(Money x)
        {
            if (x.kopeks > 0) x.kopeks--;
            return x;
        }

        public void checking_kopecks()
        {
            rubles += (uint)(kopeks / 100);
            kopeks = (byte)(kopeks % 100);
        }

        //Операции приведения типа
        public static implicit operator uint(Money money) => money.rubles; 
        public static explicit operator double(Money money) => money.kopeks / 100.0;

        public static Money operator -(Money money, uint rublesToSubtract)
        {
            if (rublesToSubtract > money.rubles)
                return new Money(0, 0); // Нельзя уйти в минус

            return new Money(money.rubles - rublesToSubtract, money.kopeks);
        }

        public static Money operator -(uint rublesToSubtract, Money money)
        {
            ulong totalMoneyKopeks = (ulong)money.rubles * 100 + money.kopeks;
            ulong totalSubtractKopeks = (ulong)rublesToSubtract * 100;

            if (totalSubtractKopeks < totalMoneyKopeks)
                return new Money(0, 0); // Нельзя получить отрицательный результат

            ulong resultKopeks = totalSubtractKopeks - totalMoneyKopeks;
            uint resultRubles = (uint)(resultKopeks / 100);
            byte resultKopeks1 = (byte)(resultKopeks % 100);

            return new Money(resultRubles, resultKopeks1);
        }

        public override string ToString()
        {
            return $"RUB='{rubles}', KOP='{kopeks}'";
        }
    }
}
