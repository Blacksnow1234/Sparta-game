using System;

namespace Sparta_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mian = false;

            while (true)
            {
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태보기 \n2. 인벤토리 \n3. 상점");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입력해주세요: ");
                string choiceMenu = Console.ReadLine();

                if (choiceMenu == "1")
                {
                    Stats stats = new Stats();
                    ClearConsole();
                    Console.WriteLine();
                    Console.WriteLine("상태 보기\n캐릭터의 정보가 표시됩니다.");
                    Console.WriteLine("Lv: " + stats.playerStats[0]);
                    Console.WriteLine("Chad (전사)");
                    Console.WriteLine("공격력: " + stats.playerStats[1]);
                    Console.WriteLine("방어력: " + stats.playerStats[2]);
                    Console.WriteLine("체력: " + stats.playerStats[3]);
                    Console.WriteLine("Gold: " + stats.playerStats[4]);
                    Console.WriteLine();
                    Console.Write("0. 나가기");
                    Console.WriteLine();
                    string choicnew = Console.ReadLine();
                    if (choicnew == "0")
                    {
                        mian = true;
                    }
                }
                else if (choiceMenu == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("인벤토리\n보유 중인 아이템을 관리할 수 있습니다.");
                    Console.WriteLine();
                    Console.WriteLine("[아이템 목록]" + );
                    Console.WriteLine();
                    Console.WriteLine("1. 장착관리\n0. 나가기");
                    Console.WriteLine();
                    Console.Write("원하시는 행동을 입력해주세요: ");
                    string choicnew = Console.ReadLine();
                    if (choicnew == "1")
                    {

                    }
                    else if (choicnew == "0")
                    {
                        mian = true;
                    }
                }
                else if (choiceMenu == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("상점\n필요한 아이템을 얻을 수 있는 상점입니다.");
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다");
                }
            }
        }
    }
}

class Stats
{
    public int[] playerStats = new int[5]; // playerStats 배열은 public으로 변경하여 외부에서 접근 가능하도록 함

    public Stats()
    {
        playerStats[0] = 1;
        playerStats[1] = 10;
        playerStats[2] = 5;
        playerStats[3] = 100;
        playerStats[4] = 1500;
    }

}
// Item 클래스 정의
class Item
{
    // 필드 : Item 클래스가 어떤 데이터들을 포함하는지
    public string Name;
    public int Status;
    // Item의 생성자 : Item을 새로 생성할 때 기본값을 부여할 수 있음.
    public Item(string name, int status)
    {
        Name = name;
        Status = status;
    }
}
class Program
{
    // 아이템을 저장할 리스트
    List<Item> inventory;
    void Main()
    {
        // 인벤토리에 무쇠갑옷을 5원으로 추가, 위에서 정의한 생성자 호출
        foreach (string item in inventory)
        {
            inventory.Add(new Item("", ));
            inventory.Add(new Item("", ));
            inventory.Add(new Item("", ));
        }
    }
    List<Item> shop;
    void Main2()
    {
        shop.Add(new Item("수련자 갑옷", 5));
        shop.Add(new Item("무쇠갑옷", 9));
        shop.Add(new Item("스파르타 갑옷", 15));
        shop.Add(new Item("낡은 검", 2));
        shop.Add(new Item("청동 도끼", 5));
        inventory.Add(new Item("스파르타의 창", 7));
    }


}
