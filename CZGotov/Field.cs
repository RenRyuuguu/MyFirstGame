using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZGotov
{
    internal class Field
    {
        //private int[,] GammeArray = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };//Наш массив
        public bool GameNumber;

        private int[,] GammeArray { get; set; } = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//наш массив с гетером сетером

        //Работа программы !
        public void GameSistem(int GameRound)
        {

            Console.WriteLine("Введите номер клетки для изменения");
            int GameField = int.Parse(Console.ReadLine());
            switch (GameField)
            {
                case 1:
                    if (GameNumber = GameRound % 2 == 0)
                    {
                        GammeArray[2, 0] = 1;
                    }
                    else
                    {
                        GammeArray[2, 0] = 2;
                    }
                    break;
                case 2:
                    if (GameNumber = GameRound % 2 == 0)
                    {
                        GammeArray[2, 1] = 1;
                    }
                    else
                    {
                        GammeArray[2, 1] = 2;
                    }

                    break;
                case 3:
                    if (GameNumber = GameRound % 2 == 0)
                    {
                        GammeArray[2, 2] = 1;
                    }
                    else
                    {
                        GammeArray[2, 2] = 2;
                    }

                    break;
                case 4:
                    if (GameNumber = GameRound % 2 == 0)
                    {
                        GammeArray[1, 0] = 1;
                    }
                    else
                    {
                        GammeArray[1, 0] = 2;
                    }

                    break;
                case 5:
                    if (GameNumber = GameRound % 2 == 0)
                    {
                        GammeArray[1, 1] = 1;
                    }
                    else
                    {
                        GammeArray[1, 1] = 2;
                    }
                    break;
                case 6:
                    if (GameNumber = GameRound % 2 == 0)
                    {
                        GammeArray[1, 2] = 1;
                    }
                    else
                    {
                        GammeArray[1, 2] = 2;
                    }

                    break;
                case 7:
                    if (GameNumber = GameRound % 2 == 0)
                    {
                        GammeArray[0, 0] = 1;
                    }
                    else
                    {
                        GammeArray[0, 0] = 2;
                    }

                    break;
                case 8:
                    if (GameNumber = GameRound % 2 == 0)
                    {
                        GammeArray[0, 1] = 1;
                    }
                    else
                    {
                        GammeArray[0, 1] = 2;
                    }

                    break;
                case 9:
                    if (GameNumber = GameRound % 2 == 0)
                    {
                        GammeArray[0, 2] = 1;
                    }
                    else
                    {
                        GammeArray[0, 2] = 2;
                    }

                    break;


            }

        }

        public Field() { Console.WriteLine("-------------------"); }

        //Обработка массива

        public void ArrayNull()
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    GammeArray[i, j] = 0;
                }
                Console.WriteLine("");
            }
            Print();
        }

        //Вывод  массива

        public void Print()
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{GammeArray[i, j]}\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

        }

        //Проверка на четность

        public static void Number(int GameRound)
        {
            Field GameNumerPlay = new Field();
            GameNumerPlay.GameNumber = GameRound % 2 == 0;

            if (GameNumerPlay.GameNumber)
            {
                Console.WriteLine("Ход Крестиков");
            }
            else { Console.WriteLine("Ход Ноликов"); }


        }

        //Проверка на победу
        public void GAME()
        {
            GameWin(GammeArray);//отправка массива в победу
        }
        public void GameWin(int[,] Array)
        {
            if (Array[0, 0] == 1 & Array[0, 1] == 1 & Array[0, 2] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[1, 0] == 1 & Array[1, 1] == 1 & Array[1, 2] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[2, 0] == 1 & Array[2, 1] == 1 & Array[2, 2] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            // shag 1

            else if (Array[0, 0] == 1 & Array[1, 0] == 1 & Array[2, 0] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[0, 1] == 1 & Array[1, 1] == 1 & Array[2, 1] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[0, 2] == 1 & Array[1, 2] == 1 & Array[2, 2] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            // shag 2
            else if (Array[0, 0] == 1 & Array[1, 1] == 1 & Array[2, 2] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[0, 2] == 1 & Array[1, 1] == 1 & Array[2, 0] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            //shag 3
            if (Array[0, 0] == 1 & Array[0, 1] == 1 & Array[0, 2] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[1, 0] == 1 & Array[1, 1] == 1 & Array[1, 2] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[1, 0] == 1 & Array[1, 1] == 1 & Array[1, 2] == 1)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            // shag 2.1

            else if (Array[0, 0] == 2 & Array[1, 0] == 2 & Array[2, 0] == 2)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[0, 1] == 2 & Array[1, 1] == 2 & Array[2, 1] == 2)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[0, 2] == 2 & Array[1, 2] == 2 & Array[2, 2] == 2)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            // shag 2.2
            else if (Array[0, 0] == 2 & Array[1, 1] == 2 & Array[2, 2] == 2)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[0, 2] == 2 & Array[1, 1] == 2 & Array[2, 0] == 2)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            //shag 2,3
            else if (Array[0, 0] == 2 & Array[0, 1] == 2 & Array[0, 2] == 2)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[1, 0] == 2 & Array[1, 1] == 2 & Array[1, 2] == 2)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }
            else if (Array[2, 0] == 2 & Array[2, 1] == 2 & Array[2, 2] == 2)
            {
                Console.WriteLine("Крестики выйграли! Нажмите 1 для выхода");
            }

        }
    }
}
