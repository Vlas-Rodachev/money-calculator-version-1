using lab1_2;
using System;

/*Money money = new Money(123, 96);
Money money2 = new Money(169, 69);
Money money3 = money2 - money;
Console.WriteLine(money3.ToString());
money3++;
Console.WriteLine(money3.ToString());
uint x = money;
double y = (double)money;
Console.WriteLine(x);
Console.WriteLine(y);

uint z = money - 10;
Console.WriteLine(z);*/


Money fu1()
{
    while (true)
    {
        Console.WriteLine("Введите номер задания для класса Money");
        Console.WriteLine("1 - Ввести вручную");
        Console.WriteLine("2 - Оставить базовые значения");
        int number_problem1 = IntInputValidator.GetValidIntInput();
        if (number_problem1 == 1)
        {
            Money money = new Money((uint)(IntInputValidator.GetValidIntInput()), (byte)(IntInputValidator.GetValidIntInput()));
            Console.WriteLine(money.ToString());
            Console.WriteLine();
            return money;
        }
        else if (number_problem1 == 2)
        {
            Money money = new Money();
            Console.WriteLine(money.ToString());
            Console.WriteLine();
            return money;
        }
    }
}

Console.WriteLine("Создание первого объекта");
Money money1 = fu1();
Console.WriteLine("Создание второго объекта");
Money money2 = fu1();
bool tr1 = true;
while (tr1)
{
    Console.WriteLine("Введите номер задания");
    Console.WriteLine("1 - вычесть из первого второй объект");
    Console.WriteLine("2 - прибавить копейку к первому объекту");
    Console.WriteLine("3 - вычесть копейку к первому объекту");
    Console.WriteLine("4 - получить рубли (копейки отбрасываются)");
    Console.WriteLine("5 - получить копейки (рубли отбрасываются)");
    Console.WriteLine("6 - вычесть целое число из рублей");
    Console.WriteLine("7 - вычесть объект из числа");
    Console.WriteLine("8 - выход");
    int number_problem = IntInputValidator.GetValidIntInput();
    if (number_problem == 1)
    {
        Money money3 = money2 - money1;
        Console.WriteLine(money3.ToString());
        Console.WriteLine();
    }
    else if (number_problem == 2)
    {
        Console.WriteLine(money1.ToString());
        money1++;
        Console.WriteLine(money1.ToString());
        Console.WriteLine();
    }
    else if (number_problem == 3)
    {
        Console.WriteLine(money1.ToString());
        money1--;
        Console.WriteLine(money1.ToString());
        Console.WriteLine();
    }
    else if (number_problem == 4)
    {
        uint x = money1;
        Console.WriteLine(x);
        Console.WriteLine();
    }
    else if (number_problem == 5)
    {
        double y = (double)money1;
        Console.WriteLine(y);
        Console.WriteLine();
    }
    else if (number_problem == 6)
    {
        uint x = (uint)(IntInputValidator.GetValidIntInput());
        Money z = money1 - x;
        Console.WriteLine(z.ToString());
        Console.WriteLine();
    }
    else if (number_problem == 7)
    {
        uint x = (uint)(IntInputValidator.GetValidIntInput());
        Money z = x - money1;
        Console.WriteLine(z.ToString());
        Console.WriteLine();
    }
    else if (number_problem == 8)
    {
        tr1 = false;
    }
}