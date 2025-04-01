using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    public class TownScene : Scene
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("사람들이 북적거리는 마을이다...", ConsoleColor.White, 1000);
            Util.Print("주변에는 간간히 다양한 물건을 파는 상점들이 눈에 띈다.", ConsoleColor.White, 1000);
        }

        public override void Choice()
        {
            Console.WriteLine("1. 상점에 들어간다.");
            Console.WriteLine("2. 광장에 가본다.");
            Console.WriteLine("3. 사냥터로 간다.");
            Console.WriteLine("4. 소지품을 점검한다.");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("상점에 들어갑니다...");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("광장으로 걸어갑니다...");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("사냥터로 향합니다...");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("소지품을 확인합니다.");
                    Game.Player.PrintItems();
                    break;
                default:
                    Console.WriteLine("잘못 입력 하셨습니다. 다시 입력해주세요.");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 눌러주세요...");
            Console.ReadKey();
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Shop");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Square");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("ForestEntrance");
                    break;
            }
        }
    }
}
