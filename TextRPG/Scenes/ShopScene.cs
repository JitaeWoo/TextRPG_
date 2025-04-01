namespace TextRPG.Scenes
{
    public class ShopScene : Scene
    {
        public override void Render()
        {
            Game.PrintInfo();
            Console.WriteLine("\"어서오세요~\"");
            Console.WriteLine("\"좋은 물건 많습니다~\"");
            Console.WriteLine("상점에는 다양한 물건들이 늘어져 있다.");
            Console.WriteLine("어떤 물건을 구매하시겠습니까?");
            Console.WriteLine($"소지금 : {Game.Player.Gold}G");
        }

        public override void Choice()
        {
            Console.WriteLine("1. 나무 뭉둥이를 구매한다. 100G");
            Console.WriteLine("2. 가죽 신발을 구매한다. 150G");
            Console.WriteLine("3. 마을로 돌아갑니다.");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    if (Game.Player.Gold >= 100)
                    {
                        Console.WriteLine("나무 뭉둥이를 구매합니다.");
                        Game.Player.Gold -= 100;
                        Game.Player.AddItem(new Item("나무 뭉둥이", "조잡한 나무 뭉둥이. 생명을 빼앗기에는 충분하다. 힘이 3 상승한다."));
                        Console.WriteLine("뭉둥이를 들자 묵직한 무게감이 느껴집니다.");
                        Game.Player.Power += 3;
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;
                case ConsoleKey.D2:
                    if (Game.Player.Gold >= 150)
                    {
                        Console.WriteLine("가죽 신발을 구매합니다.");
                        Game.Player.Gold -= 150;
                        Game.Player.AddItem(new Item("가죽 신발", "보기보다 튼튼한 재질의 가죽 신발. 속도가 3 상승한다."));
                        Console.WriteLine("착용하니 당신의 다리가 가벼워지는 것을 느낍니다.");
                        Game.Player.Speed += 3;
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 마을로 돌아갑니다...");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다. 다시 입력해주세요.");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 입력하세요.");
            Console.ReadKey();
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D3:
                    Game.ChangeScene("Town");
                    break;
            }
        }
    }
}
