using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class StartScene : Scene
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("당신은 어두운 골목에서 정신을 차린다.", ConsoleColor.White, 1000);
            Util.Print("조금 멍한 정신으로 주위를 둘러 보았지만, 주변에 특별한 것은 보이지 않는다.", ConsoleColor.White, 1000);
            Util.Print("상황을 파악하기 위해 기억을 더듬어 봐도, 어째서인지 기억이 조금 흐릿하다.", ConsoleColor.White, 1000);
            Util.Print("그래도 모험가가 되기 위해 이곳에 왔다는 것은 기억하고 있기에", ConsoleColor.White, 1000);
            Util.Print("당신은 주머니에 100 골드가 들어있는 것을 확인하고는 골목 끝의 큰 길로 나아갔다.", ConsoleColor.White, 1000);
            Util.Print("", ConsoleColor.Red, 1000);
        }

        public override void Choice()
        {
            Console.WriteLine("계속하려면 아무키나 입력하세요.");
        }

        public override void Result()
        {
            Game.Player.Gold += 100;
        }

        public override void Wait()
        {
        }
        public override void Next()
        {
            Game.ChangeScene("Town");
        }
    }
}
