namespace CZGotov
{
    internal class Program
    { //Я тут проверил ГИТ)
        static void Main(string[] args)
        {
            Field Game = new Field();
            Console.WriteLine("Внимание, запомните номера ячеяк");
            Game.Print();
            Console.WriteLine("Игра началась");
            int Round = 0;
            Game.ArrayNull();


            int GameStop = 0;
            int GamePlay = 0;
            do
            {
                Console.WriteLine("Введите 0 для следующего хода или 1 для выхода");
                GamePlay = int.Parse(Console.ReadLine());
                if (GamePlay == 0)
                {
                    Field.Number(Round);

                    Game.Print();
                    Console.WriteLine($"Номер хода: {Round}");
                    Game.GameSistem(Round);
                    Game.Print();
                    Game.GAME();
                    Round++;
                }
                else { }
            }
            while (GameStop == GamePlay);
        }
    }
}