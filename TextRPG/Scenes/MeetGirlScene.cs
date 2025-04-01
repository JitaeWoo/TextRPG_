using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class MeetGirlScene : Scene
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("고블린을 쫒아낸 후, 당신은 여자아이의 상태를 확인한다.", ConsoleColor.White, 1000);
            Util.Print("넘어지면서 다리를 조금 다친 것인지 피가 나고 있다.", ConsoleColor.White, 1000);
            Util.Print("여자아이는 어딘가 조금 불안한 눈빛으로 당신을 올려다보며 말한다.", ConsoleColor.White, 1000);
            Util.Print("\"가..감사합니다...\"", ConsoleColor.White, 1000);
            if(Game.Player.HasItem("낡은 인형"))
            {
                Util.Print("당신은 인상착의를 확인하여 이 아이가 여인의 아이라는 것을 깨닫는다.", ConsoleColor.White, 1000);
                Util.Print("우선 아이의 경계를 풀기 위해 여인에게 받았던 인형을 준다.", ConsoleColor.White, 1000);
                Util.Print("\"앗! 내 인형! ..혹시 엄마가 보내신 거에요?\"", ConsoleColor.White, 1000);
                Util.Print("당신은 아이를 향해 고개를 끄덕인다.", ConsoleColor.White, 1000);
                Util.Print("아이는 그제서야 안심했는지 짧게 한숨을 쉬고는 이내 웃는 얼굴로 다시 감사인사를 건넨다.", ConsoleColor.White, 1000);
                Util.Print("\"감사합니다! 모험가님!\"", ConsoleColor.White, 1000);
                Util.Print("당신은 아이를 여인에게 데려다 주었다.", ConsoleColor.White, 1000);
                Util.Print("여인의 감사와 사례를 받으며 다시 거리로 돌아갔다.", ConsoleColor.White, 1000);
                Util.Print("150G 획득!", ConsoleColor.White, 1000);
            }
            else
            {
                Util.Print("당신은 불안해 하는 아이를 안심시키고 마을 경비대에 맡긴다.", ConsoleColor.White, 1000);
                Util.Print("경비대로부터 아이를 보호한 것에 대해 소소한 보상을 받았다.", ConsoleColor.White, 1000);
                Util.Print("50G 획득!", ConsoleColor.White, 1000);
            }
        }

        public override void Choice()
        {
            Console.WriteLine("계속하려면 아무키나 눌러주세요...");
        }

        public override void Result()
        {
            if (Game.Player.HasItem("낡은 인형"))
            {
                Game.Player.Gold += 150;
            }
            else
            {
                Game.Player.AddQuset(new Quest("Quest_01", "하루아침에 사라진 여인의 딸을 찾아주자."));
                Game.Player.Gold += 50;
            }
            Game.Player.AddQuset(new Quest("Quest_02", "숲에서 만난 아이를 보호하자."));
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
