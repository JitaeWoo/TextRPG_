using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class ForestScene : Scene
    {
        public override void Render()
        {
            Game.PrintInfo();

            if (Game.Player.HasQuest("Quest_02"))
            {
                Util.Print("숲은 평화로웠다.", ConsoleColor.White, 1000);
                Util.Print("당신은 거리로 돌아갔다.", ConsoleColor.White, 1000);
            }
            else
            {
                Util.Print("꽤 깊은 숲 안쪽에서 발걸음을 옮기던 중 당신은 여자아이의 비명을 들었다.", ConsoleColor.White, 1000);
                Util.Print("무슨 일인지 확인하기 위해 당신은 비명이 들리는 쪽으로 향한다.", ConsoleColor.White, 1000);
                Util.Print("비명이 들렸던 곳으로 가보니 고블린 한마리가 넘어진 여자아이에게 다가가는 것이 보인다.", ConsoleColor.White, 1000);
            }
        }

        public override void Choice()
        {
            if (!Game.Player.HasQuest("Quest_02"))
            {
                Console.WriteLine("1. 고블린을 공격한다.");
                Console.WriteLine("2. 모른척하고 왔던 곳으로 돌아간다.");
            }
            else
            {
                Console.WriteLine("계속하려면 아무키나 눌러주세요...");
            }
        }

        public override void Result()
        {

            if (Game.Player.HasQuest("Quest_02"))
            {
                return;
            }

            switch (input)
            {
                case ConsoleKey.D1:
                    Util.Print("당신은 고블린을 향해 돌진했다.", ConsoleColor.White, 1000);
                    if (Game.Player.Power >= 10)
                    {
                        Util.Print("고블린은 당신의 공격에 큰 피해를 입고 도망쳤다.", ConsoleColor.White, 1000);
                    }
                    else
                    {
                        Util.Print("당신의 공격은 고블린에게 간단히 막혔다!", ConsoleColor.White, 1000);
                        Util.Print("고블린은 당신을 비웃으며 들고 있던 단검으로 당신을 찔렀다.", ConsoleColor.White, 1000);
                        Util.Print("당신의 의식이 흐려진다.", ConsoleColor.White, 1000);
                    }
                        break;
                case ConsoleKey.D2:
                    Console.WriteLine("모른척하고자 했지만 마음속의 불편함이 당신을 붙잡는다.");
                    break;
                default:
                    Console.WriteLine("잘못 입력 하셨습니다. 다시 입력해주세요.");
                    break;
            }
        }

        public override void Wait()
        {
            if (!Game.Player.HasQuest("Quest_02"))
            {
                Console.WriteLine("계속하려면 아무키나 눌러주세요...");
                Console.ReadKey();
            }
        }

        public override void Next()
        {
            if (Game.Player.HasQuest("Quest_02"))
            {
                Game.ChangeScene("Town");
            }

            switch (input)
            {
                case ConsoleKey.D1:
                    if(Game.Player.Power >= 10)
                    {
                        Game.ChangeScene("MeetGirl");
                    }
                    else
                    {
                        Game.GameOver("모험을 떠날 때는 준비를 철저히 해야합니다. 목숨은 소중하니까요.");
                    }
                    break;
            }
        }
    }
}
