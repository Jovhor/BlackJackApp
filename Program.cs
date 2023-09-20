using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApp
{
    class Program
    {
        private const int V = 7;

        static void Main(string[] args)
        {
            int sumBody = 0;
            int cardNumber;

            Console.WriteLine("Blackjack \n");
            Console.WriteLine("Приложение для игры в очко");
            Console.WriteLine("У Вас на руках карты.");
            Console.WriteLine("Существуют 6, 7, 8, 9, 10, J, Q, K, A.\n");

            while (true)
            {

                Console.WriteLine("Выложите карту:");
                string userCard = Console.ReadLine();

                switch (userCard)
                {
                    case "6":
                        cardNumber = 6;
                        sumBody = sumBody + cardNumber;
                        Console.WriteLine($"Сумма на столе = {sumBody}");
                        break;
                    case "7":
                        cardNumber = 7;
                        sumBody += cardNumber;
                        Console.WriteLine($"Сумма на столе = {sumBody}");
                        break;
                    case "8":
                        cardNumber = 8;
                        sumBody += cardNumber;
                        Console.WriteLine($"Сумма на столе = {sumBody}");
                        break;
                    case "9":
                        cardNumber = 9;
                        sumBody += cardNumber;
                        Console.WriteLine($"Сумма на столе = {sumBody}");
                        break;
                    case "10":
                        cardNumber = 10;
                        sumBody += cardNumber;
                        Console.WriteLine($"Сумма на столе = {sumBody}");
                        break;
                    case "J":
                    case "Q":
                    case "K":
                    case "A":
                        cardNumber = 10;
                        sumBody += cardNumber;
                        Console.WriteLine($"Сумма на столе = {sumBody}");
                        break;
                    default:
                        Console.WriteLine("Такой карты не существует. Кого ты пытаешься обмануть?");
                        Console.WriteLine($"Сумма на столе = {sumBody}");
                        break;
                }

                if (sumBody > 21)
                {
                    Console.WriteLine("Перебор. Тебе за щек...");
                    Console.WriteLine("Нажмите любую кнопку...");
                    Console.ReadKey();
                    break;
                }
                else if (sumBody == 21)
                {
                    Console.WriteLine("Очко! Твоей мам...");
                    Console.WriteLine("Нажмите любую кнопку...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Недобор.");
                }
            }
        }
    }
}
