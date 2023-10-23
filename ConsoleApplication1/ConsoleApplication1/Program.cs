using System;
using System.Threading;

namespace ConsoleApplication1
{
    internal class Program
    {

        //เมธ็ดแสดงโลโก้
        static void Logo()
        {
            string text = @"
 /$$      /$$                     /$$                                            /$$$$$$   /$$$$$$        /$$ /$$
| $$$    /$$$                    | $$                                           /$$__  $$ /$$__  $$      | $$| $$
| $$$$  /$$$$  /$$$$$$  /$$$$$$$ | $$   /$$  /$$$$$$   /$$$$$$   /$$$$$$       | $$  \__/| $$  \ $$      | $$| $$
| $$ $$/$$ $$ /$$__  $$| $$__  $$| $$  /$$/ /$$__  $$ /$$__  $$ /$$__  $$      | $$ /$$$$| $$  | $$      | $$| $$
| $$  $$$| $$| $$  \ $$| $$  \ $$| $$$$$$/ | $$$$$$$$| $$  \ $$| $$  \ $$      | $$|_  $$| $$  | $$      |__/|__/
| $$\  $ | $$| $$  | $$| $$  | $$| $$_  $$ | $$_____/| $$  | $$| $$  | $$      | $$  \ $$| $$  | $$              
| $$ \/  | $$|  $$$$$$/| $$  | $$| $$ \  $$|  $$$$$$$| $$$$$$$/|  $$$$$$/      |  $$$$$$/|  $$$$$$/       /$$ /$$
|__/     |__/ \______/ |__/  |__/|__/  \__/ \_______/| $$____/  \______/        \______/  \______/       |__/|__/
                                                     | $$                                                        
                                                     | $$                                                        
                                                     |__/                                                        
";
            Console.WriteLine(
                "===================================================================================================================");
            Console.WriteLine(text);
            Console.WriteLine(
                "===================================================================================================================");

        }

        //เมธ็อดโชว์ตัวข้อความทีละตัว
        static void ShowText(string text)
        {
            foreach (var letters in text)
            {
                Console.Write(letters);
                Thread.Sleep(75);
            }
        }
        //class มอนสเตอร์ของผู้เล่น
        public  class Player
        {
            public string NameMonster { get; set; }
            public int Hp { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int Speed { get; set; }
            public int SpAttack { get; set; }
            public int SpDefense { get; set; }

            public  Player(string namemonster, int hp, int attack, int defense, int speed, int spattack, int spdefense)
            {
                NameMonster = namemonster;
                Hp = hp;
                Attack = attack;
                Defense = defense;
                Speed = speed;
                SpAttack = spattack;
                SpDefense = spdefense;
            }

            public static Player[] playerMonster = new Player[4];
        }

        //คลาสสำหรับมอนเตอร์ในเกม
        public class Monster
        {
            public string NameMonster { get; set; }
            public int IVhp { get; set; }
            public int IVatk { get; set; }
            public int IVdef { get; set; }
            public int IVspATK { get; set; }
            public int IVspDef { get; set; }
            public int IVspeed { get; set; }

            public int Hp { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int Speed { get; set; }
            public int SpAttack { get; set; }
            public int SpDefense { get; set; }

            public Monster(string namemonster, int hp, int attack, int defense, int spattack, int spdefense, int speed,
                int ivhp, int ivatk, int ivdef, int ivspAtk, int ivspDef, int ivspeed)
            {
                NameMonster = namemonster;
                IVhp = ivhp;
                IVatk = ivatk;
                IVdef = ivdef;
                IVspATK = ivspAtk;
                IVspDef = ivspDef;
                IVspeed = ivspeed;
                Hp = hp;
                Attack = attack;
                Defense = defense;
                Speed = speed;
                SpAttack = spattack;
                SpDefense = spdefense;
            }

            public Monster(string namemonster, int hp, int attack, int defense, int spattack, int spdefense,int speed)
            {
                NameMonster = namemonster;
                Hp = hp;
                Attack = attack;
                Defense = defense;
                Speed = speed;
                SpAttack = spattack;
                SpDefense = spdefense;
            }
            
            //ตั้งค่าสเตตัสมอนสเตอร์
            
            public static Monster[] monster =
            {
                
                //standard monster
                new Monster("Teloth", 40,50,10,5,20,25, 25,30,20,15,15	,20),//00
                new Monster("Dorran", 60,10,30,10,	30,10,30,10,25,10,30,20),//01
                new Monster("Delphifire",40,10,30,50,10,10,20,25,10,30,20,20),//02
                
                //monster forest1
                new Monster("Zephyrak",30,55,20,15,10,20,20,30,10,30,20,15),//03
                new Monster("Gravoloth",30,60,20,10,20,10,25,30,10,30,10,20),//04
                new Monster("Venomyth",20	,10,20,60,30,10,20,20,20,30,15,20),//05
                new Monster("Doomfang",60,20,30,10,20,10,35,20,30,10,20,10),//06
                new Monster("Blazebane",50,40,35,10,20,5,25,30,30,10,10,20),//07
                new Monster("Frostbite",30,50,20,40,10,10,20,35,20,30,10,10),//08
                new Monster("Duskrage",70,20,30,40,15,5,30,10,30,35,10,10),//09
                new Monster("Scaledra",70,120,30,30,30,20,20,30,15,20,10,30),//10
                new Monster("Emberclaw",120,30,60,20,60,10,30,10,30,10,30,15),//11
                new Monster("Impolyos",120,200,40,30,30,10,20,30,20,20,30,30),//12
                    
                //monster forest2
                new Monster("Abyssion",50	,30,20,70,10,20 ,30,20,10,30,5,10),//13
                new Monster("Voidflam",90,20,30,10,30,20,30,20,30,10,30,5),//14
                new Monster("Vortexus",50,25,20,75,20,10,10,30,30,30,30,25),//15
                new Monster("Howlgrim",50,60,30,20,10,30,30,30,20,30,30,10),//16
                new Monster("Thundermaw",110,20,30,10,30,20,20,30,30,15,30,30),//17
                new Monster("Nightshade",60,35,20,80,15,10,30,30,30,30,15,15),//18
                new Monster("Scorchwing",90,10,50,50,40,10,30,20,30,30,30,15),//19
                new Monster("Dreadmire",70,120,50,30,30,50,30,30,20,30,20,25),//20
                new Monster("Raventhor",80,50,40,100,40,40,30,30,30,30,20,15),//21
                new Monster("Quantex",170,40,100,120,70,50,30,30,30,30,30,5),//22
                
                //monster forest3
                new Monster("Darknova",70,90,20,20,20,30,31,31,31,31,31,31),//23
                new Monster("Infernus",120,20,50,10,30,20,31,31,31,31,31,31),//24
                new Monster("Shadowclaw",60,45,20,90,15,10,31,31,31,31,31,31),//25
                new Monster("Stormscale",70,90,30,10,20,30,31,31,31,31,31,31),//26
                new Monster("Cyclonus",90,110,30,20,20,10,31,31,31,31,31,31),//27
                new Monster("Vipervenom",75,50,20,100,15,20,31,31,31,31,31,31),//28
                new Monster("Thundersoul",70,20,40,80,50,40,31,31,31,31,31,31),//29
                new Monster("Scaldrax",150,40,70,40,60,40,31,31,31,31,31,31),//30
                new Monster("Frostree",120,100,40,60,20,60,31,31,31,31,31,31),//31
                new Monster("Infynit",200,150,80,100,60,10,31,31,31,31,31,31),//33
                
            };

            public static Monster[] CloneMonsters()
            {
                Monster[] clonedMonsters = new Monster[monster.Length];

                for (int i = 0; i < monster.Length; i++)
                {
                    Monster originalMonster = monster[i];
                    clonedMonsters[i] = new Monster(originalMonster.NameMonster, originalMonster.Hp,
                        originalMonster.Attack, originalMonster.Defense, originalMonster.Speed,
                        originalMonster.SpAttack, originalMonster.SpDefense, originalMonster.IVhp,
                        originalMonster.IVatk, originalMonster.IVdef, originalMonster.IVspATK, originalMonster.IVspDef,
                        originalMonster.IVspeed);
                }

                return clonedMonsters;
            }

            public static Monster CaculateStat(int level, int intdex)
            {
                Monster[] clonedMonsters = CloneMonsters();
                int hpresult = (4 * clonedMonsters[intdex].Hp + clonedMonsters[intdex].IVhp) * level / 100 + level +
                               10;
                int atkresult =
                    Convert.ToInt32((4 * clonedMonsters[intdex].Attack + clonedMonsters[intdex].IVatk) * level / 100+
                                    5 * 1.1);
                int defresult =
                    Convert.ToInt32(
                        (4 * clonedMonsters[intdex].Defense + clonedMonsters[intdex].IVdef) * level / 100 + 5 * 1.1);
                int spatkresult =
                    Convert.ToInt32((4 * clonedMonsters[intdex].SpAttack + clonedMonsters[intdex].IVspATK) * level /
                                     100 + 5 * 1.1);
                int spdefresult =
                    Convert.ToInt32((4 * clonedMonsters[intdex].SpDefense + clonedMonsters[intdex].IVspDef) * level /
                                     100 + 5 * 1.1);
                int speedresult =
                    Convert.ToInt32(
                        (4 * clonedMonsters[intdex].Speed + clonedMonsters[intdex].IVspeed) * level / 100 + 5 * 1.1);

                clonedMonsters[intdex] = new Monster(clonedMonsters[intdex].NameMonster, hpresult, atkresult, defresult,
                    spatkresult, spdefresult, speedresult);

                return clonedMonsters[intdex];
            }

        }

        public static void Town1()
        {
            
        }

        public static void forest1()
        {
            ShowText("you\'re going to the first forest ");
            ShowText("!!! \n your find a monster");
            Random random = new Random();
            int num = random.Next(1, 101);
            Monster forestmonster;
            if (num<=70)
            {
                int rd = random.Next(1, 8);
                switch (rd)
                {
                    case 1 :  forestmonster = Monster.CaculateStat(5, 3);
                        Console.WriteLine();
                        break;
                    case 2 :  forestmonster = Monster.CaculateStat(5, 4);
                        break;
                    case 3 :  forestmonster = Monster.CaculateStat(5, 5);
                        break;
                    case 4 :  forestmonster = Monster.CaculateStat(5, 6);
                        break;
                    case 5 :  forestmonster = Monster.CaculateStat(5, 7);
                        break;
                    case 6 :  forestmonster = Monster.CaculateStat(5, 8);
                        break;
                    case 7 : forestmonster = Monster.CaculateStat(5, 9);
                        break;
                }
                
            }
            else if (num<=95)
            {
                int rd = random.Next(0, 1);
                switch (rd)
                {
                    case 0 :  forestmonster = Monster.CaculateStat(5, 10);
                        Console.WriteLine();
                        break;
                    case 1 :  forestmonster = Monster.CaculateStat(5, 11);
                        break;
                }
            }
            else
            {
                forestmonster = Monster.CaculateStat(5, 12);
            }
            
        }
        
        
        public static void Main(string[] args)
        {
            Monster updateMonsterA = Monster.CaculateStat(5, 0);
            Console.WriteLine($"Name: {updateMonsterA.NameMonster} \n Attack : {updateMonsterA.Attack}");
            Monster updateMonsterB = Monster.CaculateStat(5, 1);
            Console.WriteLine($"Name: {updateMonsterB.NameMonster} \n Attack :{updateMonsterB.Attack}");
            Monster updateMonsterC = Monster.CaculateStat(5, 2);
            Console.WriteLine($"Name: {updateMonsterB.NameMonster} \n Attack :{updateMonsterB.Attack}");
        
            string[] dialogueinto =
            {
                "Welcome Stranger to Monkepo World.... \n",
                "A world filled with many powerful monsters\n",
                "Catch those monsters!!",
                "Travel and become strong together\n",
                "Hmmmm..... ",
                "Come and say you name  "
            };

            Logo();
            Console.Clear();
            Logo();
            for (int i = 0; i < 6; i++)
                
            {
                ShowText(dialogueinto[i]);
                Console.ReadKey(true);
            }

            Console.Clear();
            Logo();
            Console.WriteLine("How can i call your name");
            string userName = Console.ReadLine();
            Console.Clear();
            string[] dialogueinto2 = new string[]
            {
                $"Ohhh {userName} ??",
                "I\'ll remember that\n ",
                "We've no have time Have a good luck\n  "
            };

            for (int i = 0; i < 3; i++)
            {
                ShowText(dialogueinto2[i]);
                Console.ReadKey(true);

            }

            Console.WriteLine("Chose your first monster");
            Console.WriteLine("===========================");
            Console.WriteLine("1.monsterA\n" +
                              "2.monsterB\n" +
                              "3.monsterC\n");
            Console.WriteLine("===========================");
            int chosenmonster = int.Parse(Console.ReadLine());

            switch (chosenmonster)
            {
                case 1:
                
                    Player.playerMonster[0] =new Player(updateMonsterA.NameMonster, updateMonsterA.Hp, updateMonsterA.Attack,
                        updateMonsterA.Defense, updateMonsterA.Speed, updateMonsterA.SpAttack,
                        updateMonsterA.SpDefense);
                    break;
                
                    
                case 2:
                
                    Player.playerMonster[0] =new Player(updateMonsterB.NameMonster, updateMonsterB.Hp, updateMonsterB.Attack,
                    updateMonsterB.Defense, updateMonsterB.Speed, updateMonsterB.SpAttack,
                    updateMonsterB.SpDefense);
                    break;
                
                case 3:
                
                    Player.playerMonster[0] = new Player(updateMonsterC.NameMonster, updateMonsterC.Hp, updateMonsterC.Attack,
                        updateMonsterC.Defense, updateMonsterC.Speed, updateMonsterC.SpAttack,
                        updateMonsterC.SpDefense);
                    break;
                
            }
            Console.WriteLine(Player.playerMonster[0].NameMonster);
            
 
        }
    }
}