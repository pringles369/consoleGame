int select; //선택지
int level = 01;
string job = "전사";
int atk = 10;
int dfn = 5;
int hp = 100;
int gold = 1500;


public static void Game()
{
    void lobby()
    {
        Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
        Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
        Console.WriteLine();
        Console.WriteLine("1. 상태 보기");
        Console.WriteLine("2. 인벤토리");
        Console.WriteLine("3. 상점");
        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 입력해주세요.");

        select = int.Parse(Console.ReadLine());

    }
    if (select == 1)
    {
        Console.WriteLine("상태 보기");
        Console.WriteLine("캐릭터의 정보가 표시됩니다.");
        Console.WriteLine("");
        Console.WriteLine("Lv. " + level);
        Console.WriteLine("직  업 " + job);
        Console.WriteLine("공격력 : " + atk);
        Console.WriteLine("방어력 : " + dfn);
        Console.WriteLine("체  력 : " + hp);
        Console.WriteLine("Gold : " + gold);
        Console.WriteLine();
        Console.WriteLine("0. 나가기");
        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 입력해주세요.");

        select = int.Parse(Console.ReadLine());

        if (select == 0)
        {
            Console.WriteLine(lobby);
        }

        else
        {
            Console.WriteLine("잘못된 입력입니다.");
        }
    }

    else if (select == 2)
    {

    }
}

Console.WriteLine(lobby);








