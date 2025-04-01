using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class Quest_01_StartScene : Scene
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("\"제 딸 아이가 사라졌습니다!\"", ConsoleColor.White, 1000);
            Util.Print("당신이 다가오는 것을 본 여인이 다급한 기세로 소리쳤습니다.", ConsoleColor.White, 1000);
            Util.Print("당신은 우선 여인을 진정시킨 뒤에 자세한 사정을 듣습니다.", ConsoleColor.White, 1000);
            Util.Print("여인은 아침부터 딸아이가 없어져서 수소문을 한 끝에", ConsoleColor.White, 1000);
            Util.Print("딸아이가 무언가를 쥐고 사냥터로 향하는 것을 본 목격자를 만났습니다.", ConsoleColor.White, 1000);
            Util.Print("이후 광장에서 딸아이를 찾아줄 사람을 구하고 있던 것이었습니다.", ConsoleColor.White, 1000);
            Util.Print("\"최대한 사례하겠습니다! 제발 제 딸아이를 구해주세요!\"", ConsoleColor.White, 1000);
            Util.Print("여인이 다시 한번 간곡히 말했습니다.", ConsoleColor.White, 1000);
        }

        public override void Choice()
        {
            Console.WriteLine("1. 여인의 부탁을 수락한다.");
            Console.WriteLine("2. 내 알바 아니다. 거리로 돌아간다.");
        }
        
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.Player.AddQuset(new Quest("Quest_01", "하루아침에 사라진 여인의 딸을 찾아주자."));
                    Util.Print("\"감사합니다..! 감사합니다!\"", ConsoleColor.White, 1000);
                    Util.Print("여인이 거듭 감사인사를 하며 조금 해진 인형 하나를 건넵니다.", ConsoleColor.White, 1000);
                    Util.Print("\"제 딸아이가 아끼던 인형입니다. 보여주면 바로 알거에요.\"", ConsoleColor.White, 1000);
                    Game.Player.AddItem(new Item("낡은 인형", "조금 낡은 여자아이 인형. 머리핀만은 새 것으로 보인다."));
                    Util.Print("당신은 인형을 받고 거리로 돌아갑니다.", ConsoleColor.White, 1000);

                    break;
                case ConsoleKey.D2:
                    Util.Print("당신은 간절히 부탁하는 여인을 뒤로 한 채 거리로 발걸음을 옮깁니다.", ConsoleColor.White, 1000);
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
                case ConsoleKey.D2:
                    Game.ChangeScene("Town");
                    break;
            }
        }

    }
}
