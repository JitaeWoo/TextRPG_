using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class SquareScene : Scene
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("당신은 마을 중앙의 큰 광장에 도착했다.", ConsoleColor.White, 1000);
            Util.Print("광장에는 이런저런 사람들이 한가로이 시간을 보내는 것이 보인다.", ConsoleColor.White, 1000);
            Util.Print("그 중 지나가는 사람을 붙잡고 애절한 표정으로 무언가 말하는 여인도 보인다.", ConsoleColor.White, 1000);
        }

        public override void Choice()
        {
            Console.WriteLine("1. 마을 거리로 돌아간다.");
            Console.WriteLine("2. 여인에게 말을 걸어본다.");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("거리로 돌아갑니다...");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("여인 쪽으로 걸어가 무슨 일인지 물어봅니다.");
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
                    Game.ChangeScene("Town");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Quest_01_Start");
                    break;
            }
        }
    }
}
