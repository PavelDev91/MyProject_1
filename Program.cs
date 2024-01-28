/*
 * Pavel Dev
 * GitHub: PavelDev91
 * E-mail: PavelDev1991@gmail.com
 */

using System;

using _MyFunc; // Pavel Dev

namespace MyProject_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            Console.SetBufferSize(80, 40);

            Console.SetWindowPosition(0, 0);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Title = "Pavel Dev (GitHub: PavelDev91)";
            //-----------------------------------------------------------------------------------------------------------------

            #region Задание 1 (Ctrl + Shift + /)

            /*            string mNumber;

                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("Введите номер месяца (число от 1 до 12)");

                            mNumber = Console.ReadLine();

                            switch (mNumber)
                            {
                                case "6":
                                case "7":
                                case "8":
                                    Console.WriteLine("Пора года: Лето");
                                    break;

                                case "9":
                                case "10":
                                case "11":
                                    Console.WriteLine("Пора года: Осень");
                                    break;

                                case "12":
                                case "1":
                                case "2":
                                    Console.WriteLine("Пора года: Зима");
                                    break;

                                case "3":
                                case "4":
                                case "5":
                                    Console.WriteLine("Пора года: Весна");
                                    break;

                                default:
                                    Console.WriteLine("Ошибка ввода!");
                                    break;
                            }

                            Console.WriteLine("Продолжить: нажми любую клавишу!");
                            Console.WriteLine("Выход: нажми " + ConsoleKey.Escape);

                            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                            {
                                break;
                            }
                        }*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------

            #region Задание 2 (Ctrl + Shift + /)

            /*            int? mNumber;

                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("Введите номер месяца (число от 1 до 12)");

                            mNumber = MyFunc.StringToInt(Console.ReadLine());

                            if (mNumber == null || mNumber < 1 || mNumber > 12)
                            {
                                Console.WriteLine("Ошибка ввода!");
                            }

                            if (mNumber >= 6 && mNumber <= 8)
                            {
                                Console.WriteLine("Пора года: Лето");
                            }

                            if (mNumber >= 9 && mNumber <= 11)
                            {
                                Console.WriteLine("Пора года: Осень");
                            }

                            if (mNumber == 12 || mNumber == 1 || mNumber == 2)
                            {
                                Console.WriteLine("Пора года: Зима");
                            }

                            if (mNumber >= 3 && mNumber <= 5)
                            {
                                Console.WriteLine("Пора года: Весна");
                            }

                            Console.WriteLine("Продолжить: нажми любую клавишу!");
                            Console.WriteLine("Выход: нажми " + ConsoleKey.Escape);

                            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                            {
                                break;
                            }
                        }*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------

            #region Задание 3 (Ctrl + Shift + /)

            /*            int? intValue;

                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("Проверка числа на четность!");

                            Console.WriteLine("Введите число");

                            intValue = MyFunc.StringToInt(Console.ReadLine());

                            if (intValue == null)
                            {
                                Console.WriteLine("Ошибка ввода!");

                                Console.WriteLine("Продолжить: нажми любую клавишу!");

                                Console.ReadLine();

                                continue;
                            }

                            if (intValue % 2 == 0)
                            {
                                Console.WriteLine("Число четное!");
                            }
                            else
                            {
                                Console.WriteLine("Число не четное!");
                            }

                            Console.WriteLine("Продолжить: нажми любую клавишу!");
                            Console.WriteLine("Выход: нажми " + ConsoleKey.Escape);

                            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                            {
                                break;
                            }
                        }*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------

            #region Задание 4 (Ctrl + Shift + /)

            /*            int? intValue = -0;

                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("Введите температуру!");

                            intValue = MyFunc.StringToInt(Console.ReadLine());

                            if (intValue == null)
                            {
                                Console.WriteLine("Ошибка ввода!");

                                Console.WriteLine("Продолжить: нажми любую клавишу!");

                                Console.ReadLine();

                                continue;
                            }

                            if (intValue > -5)
                            {
                                Console.WriteLine("Тепло!");
                            }

                            if (intValue <= -20)
                            {
                                Console.WriteLine("Холодно!");
                            }

                            if (intValue <= -5 && intValue > -20)
                            {
                                Console.WriteLine("Нормально!");
                            }

                            Console.WriteLine("Продолжить: нажми любую клавишу!");
                            Console.WriteLine("Выход: нажми " + ConsoleKey.Escape);

                            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                            {
                                break;
                            }
                        }*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------

            #region Задание 5 (Ctrl + Shift + /)

            /*            int? intValue;

                        string[] mass = new string[8];

                        mass[0] = "Красный!";
                        mass[1] = "Оранжевый!";
                        mass[2] = "Желтый!";
                        mass[3] = "Зеленый!";
                        mass[4] = "Голубой!";
                        mass[5] = "Синий!";
                        mass[6] = "Фиолетовый!";

                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("Определение цвета радуги!");

                            Console.WriteLine("Введите число (от 1 до 7)");

                            intValue = MyFunc.StringToInt(Console.ReadLine());

                            if (intValue == null || intValue < 1 || intValue > 7)
                            {
                                Console.WriteLine("Ошибка ввода!");

                                Console.WriteLine("Продолжить: нажми любую клавишу!");

                                Console.ReadLine();

                                continue;
                            }

                            Console.WriteLine("Цвет радуги: " + mass[intValue.Value - 1]);

                            Console.WriteLine("Продолжить: нажми любую клавишу!");
                            Console.WriteLine("Выход: нажми " + ConsoleKey.Escape);

                            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                            {
                                break;
                            }
                        }*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------

            #region Задание * (П.С. Сырая версия, так как не хватило времени на тесты...) (Ctrl + Shift + /)

            /*            Console.WriteLine("------------------------------------------------------------------------------");
                        Console.WriteLine("|                              <> Калькулятор <>                             |");
                        Console.WriteLine("------------------------------------------------------------------------------");

                        Console.WriteLine("| Минимальное число:  -9.9999 9999 9999 9999 9999 9999");
                        Console.WriteLine("| Максимальное число:  9 9999 9999 9999 9999 9999 9999");
                        Console.WriteLine("------------------------------------------------------------------------------");

                        Console.WriteLine("| Сложение:                 +");
                        Console.WriteLine("| Вычитание:                -");
                        Console.WriteLine("| Умножение:                *");
                        Console.WriteLine("| Деление:                  /");
                        Console.WriteLine("| Остаток от деления:       %");
                        Console.WriteLine("| Квадратный корень числа:  $");
                        Console.WriteLine("| Возводим число в степень: ^");
                        Console.WriteLine("------------------------------------------------------------------------------");
                        Console.WriteLine("| Очистить | Нажми: " + ConsoleKey.Delete.ToString());
                        Console.WriteLine("| Выход    | Нажми: " + ConsoleKey.Escape.ToString());
                        Console.WriteLine("------------------------------------------------------------------------------");

                        Console.WriteLine("|");
                        Console.WriteLine("------------------------------------------------------------------------------");

                        Console.WriteLine("|");
                        Console.WriteLine("------------------------------------------------------------------------------");

                        Console.CursorVisible = false;

                        //-------------------------------------------------
                        MyFunc._DrawPos DrawPos;

                        DrawPos.L = 2;
                        DrawPos.T = 19;
                        DrawPos.Width = 75;
                        DrawPos.Height = 1;
                        //-------------------------------------------------
                        MyFunc._DrawPos ResultPos;

                        ResultPos.L = 2;
                        ResultPos.T = 17;
                        ResultPos.Width = 75;
                        ResultPos.Height = 1;
                        //-------------------------------------------------

                        MyFunc.DrawCalculator(DrawPos, ResultPos);*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------
        }
    }
}
