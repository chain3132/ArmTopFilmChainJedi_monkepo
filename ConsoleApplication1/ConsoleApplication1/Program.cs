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
            Console.WriteLine("===================================================================================================================");
            Console.WriteLine(text);
            Console.WriteLine("===================================================================================================================");

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
            
            public Monster(string namemonster, int hp, int attack, int defense,int speed,int spattack,int spdefense,int ivhp,int ivatk ,int ivdef,int ivspAtk,int ivspDef,int ivspeed)
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

             public Monster(string namemonster, int hp, int attack, int defense,int speed,int spattack,int spdefense)
            {
                NameMonster = namemonster;
                Hp = hp;
                Attack = attack;
                Defense = defense;
                Speed = speed;
                SpAttack = spattack;
                SpDefense = spdefense;
            }
            public static Monster[] monster = new Monster[]
            {
                new Monster("monsterA",40,50,10,25,5,20,25,30,20,15,15,20),
                new Monster("monsterB",60,10,30,10,10,30,30,10,25,10,30,10)
            };
            public static Monster[] CloneMonsters()
            {
                Monster[] clonedMonsters = new Monster[monster.Length];

                for (int i = 0; i < monster.Length; i++)
                {
                    Monster originalMonster = monster[i];
                    clonedMonsters[i] = new Monster(originalMonster.NameMonster, originalMonster.Hp, originalMonster.Attack, originalMonster.Defense, originalMonster.Speed, originalMonster.SpAttack, originalMonster.SpDefense, originalMonster.IVhp, originalMonster.IVatk, originalMonster.IVdef, originalMonster.IVspATK, originalMonster.IVspDef, originalMonster.IVspeed);
                }

                return clonedMonsters;
            }
            public static Monster caculateStat(int level,int intdex)
            {
                Monster[] clonedMonsters = CloneMonsters();
                int hpresult = ((4 * clonedMonsters[intdex].Hp + clonedMonsters[intdex].IVhp) * level / 100) + level + 10;
                int atkresult = Convert.ToInt32(((4 * clonedMonsters[intdex].Attack + clonedMonsters[intdex].IVatk)* level / 100) + 5 * 1.1);
                int defresult = Convert.ToInt32(((4 * clonedMonsters[intdex].Defense + clonedMonsters[intdex].IVdef)*level / 100) + 5 * 1.1);
                int spatkresult = Convert.ToInt32(((4 * clonedMonsters[intdex].SpAttack + clonedMonsters[intdex].IVspATK)*level / 100) + 5 * 1.1);
                int spdefresult = Convert.ToInt32(((4 * clonedMonsters[intdex].SpDefense + clonedMonsters[intdex].IVspDef)*level / 100) + 5 * 1.1);
                int speedresult = Convert.ToInt32(((4 * clonedMonsters[intdex].Speed + clonedMonsters[intdex].IVspeed)*level / 100) + 5 * 1.1);


                clonedMonsters[intdex] = new Monster(clonedMonsters[intdex].NameMonster,hpresult,atkresult,defresult,spatkresult,spdefresult,speedresult);
                
                return clonedMonsters[intdex];
            }
            
        }

        
        public static void Main(string[] args)
        {
            Monster updateMonsterA = Monster.caculateStat(5, 0);
            Console.WriteLine($"Name: {updateMonsterA.NameMonster} \n Attack : {updateMonsterA.Attack}");
            Monster updateMonsterB = Monster.caculateStat(5, 1);
            Console.WriteLine($"Name: {updateMonsterB.NameMonster} \n Attack :{updateMonsterB.Attack}");
            
            
            string[] dialogueinto = new string[]
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
                @"We've no have time Have a good luck  "
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






        }
        
    }
}
