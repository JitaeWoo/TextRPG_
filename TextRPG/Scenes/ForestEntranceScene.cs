using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class ForestEntranceScene : Scene
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("당신은 몬스터들이 나오는 숲 앞에 도착했다.", ConsoleColor.White, 1000);
            Util.Print("울창한 나무들 앞에 경고하는 듯한 표지판이 하나 있다.", ConsoleColor.White, 1000);
        }

        public override void Choice()
        {
            Console.WriteLine("1. 숲 안쪽으로 들어간다.");
            Console.WriteLine("2. 표지판을 읽어본다.");
            Console.WriteLine("3. 거리로 돌아간다.");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("숲 안쪽으로 들어갑니다...");
                    break;
                case ConsoleKey.D2:
                    Util.Print("주의!", ConsoleColor.Red, 1000);
                    Util.Print("이 앞은 위험한 몬스터가 출몰하므로 전문가를 제외한 인원의 출입을 통제합니다.", ConsoleColor.Red, 1000);
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("마을 거리로 돌아갑니다...");
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
                    Game.ChangeScene("Forest");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Town");
                    break;
            }
        }
    }
}
