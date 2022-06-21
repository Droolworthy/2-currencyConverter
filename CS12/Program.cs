using System;

namespace CS12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rub;
            float usd;
            float eur;
            int rubToUsd = 65;
            int usdToRub = 67;
            int rubToEur = 80;
            int eurToRub = 86;
            int usdToEur = 77;
            int eurToUsd = 74;
            string userInput;
            float currencyCount;
            string stopProgram = "exit";
            Console.WriteLine("Приветствую вас в нашем банке. Здесь вы можете обменять валюты.");
            Console.Write("Введите баланс рублей: ");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс евро: ");
            eur = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Обменять рубли в доллары нажмите - 1 ");
            Console.WriteLine("Обменять доллары на рубли нажмите - 2 ");
            Console.WriteLine("Обменять рубли в евро нажмите - 3 ");
            Console.WriteLine("Обменять евро в рубли нажмите - 4 ");
            Console.WriteLine("Обменять доллары в евро нажмите - 5 ");
            Console.WriteLine("Обменять евро в доллары нажмите - 6 ");
            Console.WriteLine("Для того чтобы выйти из банка напишите - exit");
            userInput = Console.ReadLine();

            if (userInput != "exit")
            {
                Console.WriteLine(stopProgram);
                userInput = Console.ReadLine();
            }

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Обмен рубли на доллары. ");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount; 
                        usd += currencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во рублей.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен доллары на рубли. ");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount; 
                        rub += currencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во долларов.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Обмен рубли в евро. ");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount; 
                        eur += currencyCount / rubToEur;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во рублей.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Обмен евро в рубли. ");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (eur >= currencyCount)
                    {
                        eur -= currencyCount; 
                        rub += currencyCount * eurToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во евро.");
                    }
                    break;
                case "5":
                    Console.WriteLine("Обмен доллары в евро. ");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount; 
                        eur += currencyCount / usdToEur;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во долларов.");
                    }
                    break;
                case "6":
                    Console.WriteLine("Обмен евро в доллары. ");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (eur >= currencyCount)
                    {
                        eur -= currencyCount; 
                        usd += currencyCount * eurToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во евро.");
                    }
                    break;
            }
            Console.WriteLine($"Ваш баланс - {rub} рублей, {usd} - долларов и {eur} - евро");
            Console.WriteLine("Программа остановлена.");
        }
    }
}
