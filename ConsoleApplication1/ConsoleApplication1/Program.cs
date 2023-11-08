using System;
using System.Threading;
using System.Windows.Input;

namespace ConsoleApplication1
{
    internal class Program
    {

        //เมธ็ดแสดงโลโก้
        public static void Logo()
        {
            Console.Clear();
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

        public static void ImgMonster1()
        {
            Console.Clear();

            string monsterA = @"                                                                                       
                                         @@                                            
                                       @@@                                             
                                      @%%@                                             
                                     @%%%                                              
                                    @%%%%                                              
                                  @%%%%%@                                              
                         @@      @%%%%%%    @%@       @@                               
                         %%@    %%%@@@@@   @%%      @%%@                               
                        @%%%@  @@%####%@  @%%@   @%%%%@                                
                        %%%@@%############%#%% @@%%%%%@                                
                    @@@ %@%*###%############%##%@@%%%@       @     @%%%                
                    @@@%#####################%%####%@     @%%@  @%%%%@                 
                     @%###########################%#%   %%%%%@%%%%%%@                  
                   %##########%**##%#################@%%@@@@%%%%%%%                    
                   ##%%###%##################%%###%##%%@@%%%%%%%%%                     
                  @###################%@@%###########%#%%%%%%%%%@                      
                   %%%#######%######%+*@@%%##%%#########%@%%%%%@                       
                   %@**##%##%##%%%@#+*%%%%%*--+%%%########@@%%@                        
                %@@##%@@%%%%###%%%%@@%######+=-+#########%%%@   @%%%@                  
                @@@*%#############%%%#######%#@#%#######%%%##%@%%%%%@                  
                @@+-#+++%#############%+*++##%###############%@%%%%@@                  
               @%%%%%#%##**##########*=+-+#####%#####%%########%%%%%%%%%%%@%@@         
              %#########%%*#=:=:=::=+#%+@####@%#%###%%#########%@%%%%%%%%%%%@          
            @###%######%%%#@@%+-++=*##%%%##%%##%#%#%###%#######%@%%%%%%%%%@            
            ##%###%%####%%%%##########%%#**+*%%#####@%#%#%%%###%@@%%%%@                
            %%###%*++***#@@%#####%%###**%+*#*+***###########%#%@@%@                    
            %####*++++*#*@##*+*###****+#%#*+++*###*#%######%#%%%                       
           @####%++++++*#%*+***##+*####*#*++++*###*##########%%@%%@@                   
          @#####%+++++++*+=*%%##%@@***++##++++*+++#######%%#####%@                     
          @*###%@#+**++**#*#%%%###++++++#*++++++*##%######%%###%%%%%@                  
          @###%%#*++++++#+*%%#####%%*****++++++*%##############@%%%%%%%%@              
          @######%#+++++*%*==#%##################%%###**######%@%%%%%%%%%%@            
          %#########*+*####**++**#%############%######+*###%%%%@@%%%%%%%%%%%%@         
          ###########%%###*++#*++++++###############%*+*%#####%@@%%%%%%%%%%%%@         
          %#########%%#####*++++++++++++##########%#*++*########@%%%%%%@@              
           #########%#####+=*++++++++++++++++++++++++++*#####%##%@%@                   
             @#####%%###*++*#++++++++++++++++++++++++++*######%##%@@@                  
                %#*++*++++++++++++++++++++++++++++++++*##########%@@@                  
                %##++++*+++++++++++++++++++++++++++++*##########%                      
               @###*#+++++++++++++++++++++++++++**++*##########%                       
               @####**#*+++++++++++++++++++++++++#***####%####%                        
               @%######**###+++++++++++++++++*##@  %%#######%%                         
                @%#########%@@@#*++++++**#%@     @%%%##%%@                             
                  %##########%%@%              @%#####%@                    
                     @@@%%@@%%###              %####%@                    
                            @####@              %#####%                   
                           @%####%              %#######%%@@                       
                       @%%%#####%                %##%%#####++**#@                    
                    @#++*######%@                 %####*##*+**+*%                    
                                                   @@%%%####%%                         
                                                                                       
                                                                                       
                                                                                       
                                                                                       
                                                                                       ";
            Console.WriteLine(monsterA);

        }

        public static void ImgMonster2()
        {
            string monsterB = @"                                                                                    
                                                                           
                                 =#*******#+.          -++                             
                               :#******#*****#.      .+==*                             
                      :.      .#*********#*%@@@=#*-:-++==*.                            
          .           *=      +**********%@@@%********##*+*-                           
         =-        ::=%=#*%%+=**+*#****#%@@#*%@@@%##*****%**=         .::              
        :*=     .=###*%+=#%@@*+*+******%@@@#*#-......+#***##*+      :+*.               
        :==+%@***##=...+==+@+=====++***@@@@@%...-+==@@-*****#*+    :*+:                
        -+===++**#::@@@#++==+*=====*+*##%****.%@@@@@@@%.##**##*    +=+                 
         +===++*#*.%@@@:+===========*##****#%..-=+#@@%.-%****#*=  :+=+:     ++===+*.   
          =+==+*##:-=:...++====+==+#********#*%-....:=#*%##**@@#.#@**+*   :*=+=*: :+   
            .-*****=..:*##*#*+==+#*************#%#**%#**###%@@@@#%@@#*#   ====*.       
            =******##*##********#*****#**********#*******#%*#--#@**@@%#   +===-        
           =**=....:#*****#**#**#*#**#*********#********###..#@=.-#*#@*  ====+-        
          +**..%@:.-*#*****#******#********************###%..=@@+.-#*#.  ++++=-        
          =+=.+@*.:##***********************************#*#-.:@@@:.#*#.-#*+++++        
            -.:..-#%*#**********************************@*#*=..-:.=##%#******+#        
             :=-***%%*******************************%@#:%%**#**::+#%***********        
        *:      +%@#*************************#*#*@@*:@@#@@****%#*##***********=        
       .*.    :#**@@@#*********************##*@#-@@@#@@@@@#****%******#*******:        
       .*+=--=**#*#@@@@+*#************#%*-%@+-*@@*==*@@#%*****#****#*********#         
        :===+******@@@@@+**#*+##**##==@@@-@@@@@+===*===:%*****#**#*****#*****          
          ++=++****%@@@@%#***+:#####=#@@@@@@#======*-==#**##**%@#*********#-           
            --=-.+######*=*##*##**##@#======*+=+-+=+-#+***#*-..=@#******#-             
                .-..*..*#**##*****#*+==**+==+-=##*#*@+****..-#@*=%******               
      =+      :#%..-%+..:##*:****#=##*+****##%***##**+#**:.*@@#:=%##*=.                
    .++        :*#:.=....##******#%#%%**#*****+*%#*#*#*#*.%@%+::%#***     +.           
   .+==          +#*******%*#**+@@@@*+++**+**#********#%#=..:+*#@****     ++           
   *==+        =**#@@@@@@@@@@%:.::::....#*+**#**:--:=-*%@@###%@@**#***#:++=+           
   *===+#:=%@%#****#@@#**@@@@@-........:#*%@*#.@@%%@%##%****@@@@*#**++#====+           
    *====+**********%###**%@@#**:..=***#@**##*#+++#**#*#*#**%@@%#***========           
     .*===++***#**#*#******@@@#*******##**#**@%%@%@%*@*#****#@++#*+*=======            
       .+*#+*+--************@@###****##****#*#@@@%*******#**+ =++.-*====+-             
                 .*#********%=:+===+++*++**#*%@@@******#*++===+=+.  --:                
        -###+-==#*********#:    =+#+===+=++#-     :#****++=+*===*: ++                  
       +==+*+***********#-       .*====+=#-         :*#*+======+. ++*++                
      -*==#.      ..:.              ...                 +====*=    +++*                
      .*=*:                                              .-:                      
                                                                                       ";
            Console.Write(monsterB);
        }

        public static void ImgMonster3()
        {
            string monsterC = @"                                                                                                    
                             ...                                      
         ?J?^.       ^5PGGPY^         .~!~        
        :JJJJ?7^.   5@B7~!7B@5      :~?JJJ        
        ?YYYY5G&G5^G@!      7@G  ^!?YJJJJJ!       
        ?5555GB&&@@@~        ~@BP#BP5YJYY5J       
        .BGBB##&&@@!          :#@&#BGP5PPG~       
         7#&&&&@@@G   !?JJJJ~. :B@@&###BB5        
          J@@@&B5Y.~JGBBB#&@#GP!:~YP&@@@#!.       
       !5#&B5?:. .7G#G!.J&@@@@@BJ   ::?Y#@BJ.     
      5@&5~.     !&&P. Y@@@@@@@&G:      .7&@Y     
     ^@@?        !@&Y  5@@@@@@@#G:.       B@G.    
     .#@G~       ~#&G^. !?B#G5&@P.    .:?B@#!     
      ^5&@GY!:.  .^5#BP?^:~JPB&Y~  .!JB&&G?:      
        :!PG&&B57^ .~5PPPPPPPY^. :PB#BY7:         
            ^~?PPGG!   .:^:     ^&7~.             
                 .B@~          7@5                
                   G@~        !@G                 
                    P@?      7@G                  
                     Y@#77!7#@5                   
                      :Y5GP55:                                                                   
                                                                                                    ";
            Console.Write(monsterC);
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
        public class Player
        {
            public string NameMonster { get; set; }
            public int LevelMonster { get; set; }
            public int RequirExp { get; set; }
            public int Hp { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int SpAttack { get; set; }
            public int SpDefense { get; set; }
            public int Speed { get; set; }
            public int Index { get; set; }

            public Player(string namemonster, int levelmonster, int requirexp, int hp, int attack, int defense,
                int spattack, int spdefense, int speed, int index)
            {
                NameMonster = namemonster;
                LevelMonster = levelmonster;
                RequirExp = requirexp;
                Hp = hp;
                Attack = attack;
                Defense = defense;
                Speed = speed;
                SpAttack = spattack;
                SpDefense = spdefense;
                Index = index;
            }

            public static Player[] playerMonster = new Player[4];
        }

        //คลาสสำหรับมอนเตอร์ในเกม
        public class Monster
        {
            public string NameMonster { get; set; }
            public int LevelMonster { get; set; }
            public int Exp { get; set; }
            public int Ivhp { get; set; }
            public int Ivatk { get; set; }
            public int Ivdef { get; set; }
            public int IvspAtk { get; set; }
            public int IvspDef { get; set; }
            public int Ivspeed { get; set; }

            public int Hp { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int Speed { get; set; }
            public int SpAttack { get; set; }
            public int SpDefense { get; set; }
            public int Index { get; set; }

            public Monster(string namemonster, int levelmonster, int exp, int hp, int attack, int defense, int spattack,
                int spdefense, int speed,
                int ivhp, int ivatk, int ivdef, int ivspAtk, int ivspDef, int ivspeed, int index)
            {
                NameMonster = namemonster;
                LevelMonster = levelmonster;
                Exp = exp;
                Ivhp = ivhp;
                Ivatk = ivatk;
                Ivdef = ivdef;
                IvspAtk = ivspAtk;
                IvspDef = ivspDef;
                Ivspeed = ivspeed;
                Hp = hp;
                Attack = attack;
                Defense = defense;
                Speed = speed;
                SpAttack = spattack;
                SpDefense = spdefense;
                Index = index;
            }

            public Monster(string namemonster, int levelmonster, int exp, int hp, int attack, int defense, int spattack,
                int spdefense, int speed, int index)
            {
                NameMonster = namemonster;
                LevelMonster = levelmonster;
                Exp = exp;
                Hp = hp;
                Attack = attack;
                Defense = defense;
                Speed = speed;
                SpAttack = spattack;
                SpDefense = spdefense;
                Index = index;
            }

            //ตั้งค่าสเตตัสมอนสเตอร์

            public static Monster[] Monsters =
            {

                //standard monster
                new Monster("Teloth", 0, 75, 40, 50, 10, 5, 20, 25, 25, 30, 20, 15, 15, 20, 0), //00
                new Monster("Dorran", 0, 70, 60, 10, 30, 10, 30, 10, 30, 10, 25, 10, 30, 20, 1), //01
                new Monster("Delphifire", 0, 65, 40, 10, 30, 50, 10, 10, 20, 25, 10, 30, 20, 20, 2), //02

                //monster forest1
                new Monster("Zephyrak", 0, 50, 30, 55, 20, 15, 10, 20, 20, 30, 10, 30, 20, 15, 3), //03
                new Monster("Gravoloth", 0, 65, 30, 60, 20, 10, 20, 10, 25, 30, 10, 30, 10, 20, 4), //04
                new Monster("Venomyth", 0, 75, 20, 10, 20, 60, 30, 10, 20, 20, 20, 30, 15, 20, 5), //05
                new Monster("Doomfang", 0, 55, 60, 20, 30, 10, 20, 10, 35, 20, 30, 10, 20, 10, 6), //06
                new Monster("Blazebane", 0, 75, 50, 40, 35, 10, 20, 5, 25, 30, 30, 10, 10, 20, 7), //07
                new Monster("Frostbite", 0, 60, 30, 50, 20, 40, 10, 10, 20, 35, 20, 30, 10, 10, 8), //08
                new Monster("Duskrage", 0, 70, 70, 20, 30, 40, 15, 5, 30, 10, 30, 35, 10, 10, 9), //09
                new Monster("Scaledra", 0, 75, 70, 120, 30, 30, 30, 20, 20, 30, 15, 20, 10, 30, 10), //10
                new Monster("Emberclaw", 0, 80, 120, 30, 60, 20, 60, 10, 30, 10, 30, 10, 30, 15, 11), //11
                new Monster("Impolyos", 0, 85, 120, 200, 40, 30, 30, 10, 20, 30, 20, 20, 30, 30, 12), //12

                //monster forest2
                new Monster("Abyssion", 0, 65, 50, 30, 20, 70, 10, 20, 30, 20, 10, 30, 5, 10, 13), //13
                new Monster("Voidflam", 0, 70, 90, 20, 30, 10, 30, 20, 30, 20, 30, 10, 30, 5, 14), //14
                new Monster("Vortexus", 0, 70, 50, 25, 20, 75, 20, 10, 10, 30, 30, 30, 30, 25, 15), //15
                new Monster("Howlgrim", 0, 80, 50, 60, 30, 20, 10, 30, 30, 30, 20, 30, 30, 10, 16), //16
                new Monster("Thundermaw", 0, 75, 110, 20, 30, 10, 30, 20, 20, 30, 30, 15, 30, 30, 17), //17
                new Monster("Nightshade", 0, 70, 60, 35, 20, 80, 15, 10, 30, 30, 30, 30, 15, 15, 18), //18
                new Monster("Scorchwing", 0, 65, 90, 10, 50, 50, 40, 10, 30, 20, 30, 30, 30, 15, 19), //19
                new Monster("Dreadmire", 0, 85, 70, 120, 50, 30, 30, 50, 30, 30, 20, 30, 20, 25, 20), //20
                new Monster("Raventhor", 0, 80, 80, 50, 40, 100, 40, 40, 30, 30, 30, 30, 20, 15, 21), //21
                new Monster("Quantex", 0, 80, 170, 40, 100, 120, 70, 50, 30, 30, 30, 30, 30, 5, 22), //22

                //monster forest3
                new Monster("Darknova", 0, 70, 70, 90, 20, 20, 20, 30, 31, 31, 31, 31, 31, 31, 23), //23
                new Monster("Infernus", 0, 60, 120, 20, 50, 10, 30, 20, 31, 31, 31, 31, 31, 31, 24), //24
                new Monster("Shadowclaw", 0, 55, 60, 45, 20, 90, 15, 10, 31, 31, 31, 31, 31, 31, 25), //25
                new Monster("Stormscale", 0, 65, 70, 90, 30, 10, 20, 30, 31, 31, 31, 31, 31, 31, 26), //26
                new Monster("Cyclonus", 0, 65, 90, 110, 30, 20, 20, 10, 31, 31, 31, 31, 31, 31, 27), //27
                new Monster("Vipervenom", 0, 70, 75, 50, 20, 100, 15, 20, 31, 31, 31, 31, 31, 31, 28), //28
                new Monster("Thundersoul", 0, 80, 70, 20, 40, 80, 50, 40, 31, 31, 31, 31, 31, 31, 29), //29
                new Monster("Scaldrax", 0, 85, 150, 40, 70, 40, 60, 40, 31, 31, 31, 31, 31, 31, 30), //30
                new Monster("Frostree", 0, 75, 120, 100, 40, 60, 20, 60, 31, 31, 31, 31, 31, 31, 31), //31
                new Monster("Infynit", 0, 85, 200, 150, 80, 100, 60, 10, 31, 31, 31, 31, 31, 31, 32), //33

            };

            public static Monster[] CloneMonsters()
            {
                Monster[] clonedMonsters = new Monster[Monsters.Length];

                for (int i = 0; i < Monsters.Length; i++)
                {
                    Monster originalMonster = Monsters[i];
                    clonedMonsters[i] = new Monster(originalMonster.NameMonster, originalMonster.LevelMonster,
                        originalMonster.Exp, originalMonster.Hp,
                        originalMonster.Attack, originalMonster.Defense,
                        originalMonster.SpAttack, originalMonster.SpDefense, originalMonster.Speed,
                        originalMonster.Ivhp,
                        originalMonster.Ivatk, originalMonster.Ivdef, originalMonster.IvspAtk, originalMonster.IvspDef,
                        originalMonster.Ivspeed, originalMonster.Index);
                }

                return clonedMonsters;
            }

            public static Monster CaculateStat(int level, int index)
            {
                Monster[] clonedMonsters = CloneMonsters();
                int hpResult = (4 * clonedMonsters[index].Hp + clonedMonsters[index].Ivhp) * level / 100 + level +
                               10;
                double atkResult = (4.0 * clonedMonsters[index].Attack + clonedMonsters[index].Ivatk) * level / 100 +
                                   5 * 1.1;
                double defResult = (4.0 * clonedMonsters[index].Defense + clonedMonsters[index].Ivdef) * level / 100 +
                                   5 * 1.1;
                double spAtkResult = (4.0 * clonedMonsters[index].SpAttack + clonedMonsters[index].IvspAtk) * level /
                    100 + 5 * 1.1;
                double spDefResult = (4.0 * clonedMonsters[index].SpDefense + clonedMonsters[index].IvspDef) * level /
                    100 + 5 * 1.1;
                double speedResult = (4.0 * clonedMonsters[index].Speed + clonedMonsters[index].Ivspeed) * level / 100 +
                                     5 * 1.1;


                int hpResultRounded = Convert.ToInt32(hpResult);
                int atkResultRounded = Convert.ToInt32(atkResult);
                int defResultRounded = Convert.ToInt32(defResult);
                int spAtkResultRounded = Convert.ToInt32(spAtkResult);
                int spDefResultRounded = Convert.ToInt32(spDefResult);
                int speedResultRounded = Convert.ToInt32(speedResult);

                clonedMonsters[index] = new Monster(clonedMonsters[index].NameMonster, level, clonedMonsters[index].Exp,
                    hpResultRounded, atkResultRounded, defResultRounded, spAtkResultRounded, spDefResultRounded,
                    speedResultRounded, index);

                return clonedMonsters[index];
            }

        }

        public class Level
        {
            public int LevelOrder { get; set; }
            public int ExpRequi { get; set; }

            public Level(int levelorder, int exprequi)
            {
                LevelOrder = levelorder;
                ExpRequi = exprequi;
            }

            public static Level[] Levels =
            {
                new Level(1, 6),
                new Level(2, 15),
                new Level(3, 30),
                new Level(4, 49),
                new Level(5, 72),
                new Level(6, 102),
                new Level(7, 135),
                new Level(8, 174),
                new Level(9, 217),
                new Level(10, 264),
                new Level(11, 318),
                new Level(12, 375),
                new Level(13, 438),
                new Level(14, 505),
                new Level(15, 576),
                new Level(16, 654),
                new Level(17, 735),
                new Level(18, 822),
                new Level(19, 913),
                new Level(20, 1008),
                new Level(21, 1110),
                new Level(22, 1215),
                new Level(23, 1326),
                new Level(24, 1441),
                new Level(25, 1560),
                new Level(26, 1686),
                new Level(27, 1815),
                new Level(28, 1950),
                new Level(29, 2089),
                new Level(30, 2232),
                new Level(31, 2382),
                new Level(32, 2535),
                new Level(33, 2694),
                new Level(34, 2857),
                new Level(35, 3024),
                new Level(36, 3198),
                new Level(37, 3375),
                new Level(38, 3558),
                new Level(39, 3745),
                new Level(40, 3936),
                new Level(41, 4134),
                new Level(42, 4335),
                new Level(43, 4542),
                new Level(44, 4753),
                new Level(45, 4968),
                new Level(46, 5190),
                new Level(47, 5415),
                new Level(48, 5646),
                new Level(49, 5881),
                new Level(50, 6120),
            };

        }

        
        // level = level ของมอนสเตอร์ที่ถูกโจมตี
        // attack = attackของมอนสเตอร์ที่โจมตี
        //defense = defenseพลังป้องกันของมอนสเตอร์ที่โจมตี
        //hpMonster = hpของมอนสเตอร์ที่ถูกโจมตี
        public static int CaculateDamage(int level, int attack, int defense, int hpMonster)
        {
            int damaged =
                Convert.ToInt32(attack * (1 - ((double)defense / (defense + 7))) * (1 + ((double)level / 12)));
            int hpEqual = hpMonster - damaged;
            return hpEqual;
        }

        public static int CaculateShowDamage(int level, int attack, int defense)
        {
            int damaged =
                Convert.ToInt32(
                    attack * (1 - ((double)defense / (defense + 7))) * (1 + (double)level / 12));

            return damaged;
        }

        //b = baseExp ของมอนสเตอร์ที่ถูกกำจัด
        //l = levelของมอนสเตอร์ที่ถูกกำจัด
        public static int CaculateExp(int b, int l)
        {
            int totalExp = Convert.ToInt32(b * l * 1.5 / 7);
            return totalExp;
        }

        public static void test()
        {

            Monster updateMonsterC = Monster.CaculateStat(5, 2);
            Player.playerMonster[0] = new Player(updateMonsterC.NameMonster,
                updateMonsterC.LevelMonster, 0,
                updateMonsterC.Hp, updateMonsterC.Attack,
                updateMonsterC.Defense, updateMonsterC.SpAttack,
                updateMonsterC.SpDefense, updateMonsterC.Speed, 2);
            Console.WriteLine(Player.playerMonster[0].RequirExp +=
                CaculateExp(34, 4));
            Console.WriteLine(Player.playerMonster[0].RequirExp +=
                CaculateExp(34, 4));
            Console.WriteLine(Player.playerMonster[0].RequirExp +=
                CaculateExp(34, 4));
            Console.WriteLine(Level.Levels[Player.playerMonster[0].LevelMonster].ExpRequi);

        }



        public static bool IsnotPass = true;
        public static bool IsGym1notPass = true;
        public static bool IsGym2notPass = true;

        public static void Town(int town, string username)
        {
            if (town == 1)
            {
                
                if (IsnotPass)
                {
                    ShowText("now I don't have any clue about that gym leader. \n" +
                             "This city may give me some information of that gym leader and this city maybe a great place to start");
                }
                
                IsnotPass = false;
                while (true)
                {
                    ShowText("\nYou already clear this town");
                    ShowText("\nNow Where you want to go ?\n");
                    Console.WriteLine(
                        "=======================================================================================================");
                    Console.WriteLine("1.Forest");
                    Console.WriteLine(
                        "=======================================================================================================");
                    bool isTypeCorract = int.TryParse(Console.ReadLine(), out int playerchooes);
                    if (isTypeCorract && playerchooes == 1)
                    {
                        Forest(1,username);
                        break;
                    }

                    if (!isTypeCorract || playerchooes != 1)
                    {
                        Console.WriteLine("Please Enter number 1");
                        Console.ReadKey(true);
                        Console.Clear();
                    }

                }
            }

            if (town == 2)
            {
                
                if (IsnotPass)
                {
                    ShowText("I heard someone who knows that gyn leader lives in this city \n" +
                             "I have to find that guy and ask him.");
                }
                
                IsnotPass = false;
                while (true)
                {
                    ShowText("\nYou already clear this town");
                    ShowText("\nNow Where you want to go ?\n");
                    Console.WriteLine(
                        "=======================================================================================================");
                    Console.WriteLine("1.Forest 1");
                    
                    Console.WriteLine("2.Gym leader");
                    
                    Console.WriteLine("3.Forest 2");
                    
                    Console.WriteLine(
                        "=======================================================================================================");
                    bool isTypeCorract = int.TryParse(Console.ReadLine(), out int playerchooes);
                    if (isTypeCorract && playerchooes == 1)
                    {
                        Forest(1,username);
                        break;
                    }
                    if (isTypeCorract && playerchooes == 2 && IsGym1notPass )
                    {
                        GymLeader(1,username);
                        break;
                    }
                    if (isTypeCorract && playerchooes == 3  )
                    {
                        Forest(2,username);
                        
                        
                        break;
                    }

                    if (!isTypeCorract || playerchooes != 1 && playerchooes != 2 && playerchooes != 3 )
                    {
                        Console.WriteLine("Please Enter number 1 2 or 3");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                    if (isTypeCorract && playerchooes == 2  && IsGym1notPass == false )
                    {
                        Console.WriteLine("you already clear Gym Leader");
                        Console.ReadKey(true);
                        Console.Clear();
                    }

                }

            }
            
            if (town == 3)
            {
                
                if (IsnotPass)
                {
                    ShowText("The clue I have now is he went to city 3 a few days ago. I'm going to ask someone if they know or saw him.");

                }
                
                IsnotPass = false;
                while (true)
                {
                    ShowText("\nYou already clear this town");
                    ShowText("\nNow Where you want to go ?\n");
                    Console.WriteLine(
                        "=======================================================================================================");
                    Console.WriteLine("1.Forest 2");
                    if (IsGym2notPass)
                    {
                        Console.WriteLine("2.Gym leader");
                    }
                    Console.WriteLine(
                        "=======================================================================================================");
                    bool isTypeCorract = int.TryParse(Console.ReadLine(), out int playerchooes);
                    if (isTypeCorract && playerchooes == 1)
                    {
                        Forest(2,username);
                        break;
                    }
                    if (isTypeCorract && playerchooes == 2 && IsGym2notPass)
                    {
                        GymLeader(2,username);
                        IsGym1notPass = false;
                        break;
                    }

                    if (!isTypeCorract || playerchooes != 1 && playerchooes != 2)
                    {
                        Console.WriteLine("Please Enter number 1 or 2");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                    if (isTypeCorract && playerchooes == 2 && IsGym2notPass == false)
                    {
                        Console.WriteLine("you already clear gym leader");
                        Console.ReadKey(true);
                        Console.Clear();
                    }

                }
            }
        }

        public static void Forest(int forest,string username)
                {
                    Monster forestmonster = null;
                    int currentHpMonsterForest;
                    int currentHpMonsterPlayer;
                    int currentDefMonsterPlayer = 0;


                    int passturn = 4;

                    while (passturn > 0)
                    {
                        ShowText("you\'re going to the first forest\n ");
                        ShowText("!!! \nyour found a monster");
                        Random random = new Random();
                        int num = random.Next(1, 101);
                        //set random monster forest1
                        if (forest == 1)
                        {
                            if (num <= 85)
                            {
                                int rd = random.Next(1, 8);
                                switch (rd)
                                {
                                    case 1:
                                        forestmonster = Monster.CaculateStat(3, 3);
                                        break;
                                    case 2:
                                        forestmonster = Monster.CaculateStat(4, 4);
                                        break;
                                    case 3:
                                        forestmonster = Monster.CaculateStat(4, 5);
                                        break;
                                    case 4:
                                        forestmonster = Monster.CaculateStat(4, 6);
                                        break;
                                    case 5:
                                        forestmonster = Monster.CaculateStat(4, 7);
                                        break;
                                    case 6:
                                        forestmonster = Monster.CaculateStat(3, 8);
                                        break;
                                    case 7:
                                        forestmonster = Monster.CaculateStat(2, 9);
                                        break;
                                }
                            }
                            else if (num <= 95)
                            {
                                int rd = random.Next(0, 2);
                                switch (rd)
                                {
                                    case 0:
                                        forestmonster = Monster.CaculateStat(4, 10);
                                        break;
                                    case 1:
                                        forestmonster = Monster.CaculateStat(3, 11);
                                        break;
                                }
                            }
                            else
                            {
                                forestmonster = Monster.CaculateStat(6, 12);
                            }
                        }

                        //set random monster forest2
                        if (forest == 2)
                        {
                            if (num <= 85)
                            {
                                int rd = random.Next(1, 8);
                                switch (rd)
                                {
                                    case 1:
                                        forestmonster = Monster.CaculateStat(10, 13);
                                        break;
                                    case 2:
                                        forestmonster = Monster.CaculateStat(10, 14);
                                        break;
                                    case 3:
                                        forestmonster = Monster.CaculateStat(10, 15);
                                        break;
                                    case 4:
                                        forestmonster = Monster.CaculateStat(10, 16);
                                        break;
                                    case 5:
                                        forestmonster = Monster.CaculateStat(10, 17);
                                        break;
                                    case 6:
                                        forestmonster = Monster.CaculateStat(11, 18);
                                        break;
                                    case 7:
                                        forestmonster = Monster.CaculateStat(11, 19);
                                        break;
                                }
                            }
                            else if (num <= 95)
                            {
                                int rd = random.Next(0, 2);
                                switch (rd)
                                {
                                    case 0:
                                        forestmonster = Monster.CaculateStat(12, 20);
                                        break;
                                    case 1:
                                        forestmonster = Monster.CaculateStat(12, 21);
                                        break;
                                }
                            }
                            else
                            {
                                forestmonster = Monster.CaculateStat(13, 22);
                            }
                        }


                        ShowText($" {forestmonster.NameMonster} appear!!\n");
                        int playerOrder;
                        currentHpMonsterForest = forestmonster.Hp;
                        currentHpMonsterPlayer = Player.playerMonster[0].Hp;

                        //show monsterForestStatus
                        Console.WriteLine($"{forestmonster.NameMonster}  has {forestmonster.LevelMonster} Level .");
                        if (forestmonster.Attack > forestmonster.SpAttack)
                        {
                            Console.WriteLine($"HP: {currentHpMonsterForest} ATK: {forestmonster.Attack}");
                        }

                        if (forestmonster.Attack < forestmonster.SpAttack)
                        {
                            Console.WriteLine($"HP: {currentHpMonsterForest} Sp ATK: {forestmonster.SpAttack}");
                        }

                        if (forestmonster.SpAttack == forestmonster.Attack)
                        {
                            int randomdef = random.Next(0, 2);
                            if (randomdef == 0)
                            {
                                Console.WriteLine($"HP: {currentHpMonsterForest} ATK: {forestmonster.Attack}");
                            }

                            if (randomdef == 1)
                            {
                                Console.WriteLine($"HP: {currentHpMonsterForest} Sp ATK: {forestmonster.SpAttack}");
                            }
                        }

                        if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                        {
                            Console.WriteLine($"Def: {forestmonster.Defense} Speed: {forestmonster.Speed}");
                        }

                        if (Player.playerMonster[0].Attack < Player.playerMonster[0].SpAttack)
                        {
                            Console.WriteLine($"SpDef: {forestmonster.SpDefense} Speed: {forestmonster.Speed}");
                        }
                        if (Player.playerMonster[0].Attack == Player.playerMonster[0].SpAttack)
                        {
                            int randomdef = random.Next(0, 2);
                            if (randomdef == 0)
                            {
                                Console.WriteLine($"SpDef: {forestmonster.SpDefense} Speed: {forestmonster.Speed}");
                            }

                            if (randomdef == 1)
                            {
                                Console.WriteLine($"Def: {forestmonster.Defense} Speed: {forestmonster.Speed}");
                            }
                        }


                        //show monsterPlayerStatus
                        Console.WriteLine(
                            $"{Player.playerMonster[0].NameMonster}  has {Player.playerMonster[0].LevelMonster} Level .");
                        if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                        {
                            Console.WriteLine(
                                $"HP: {Player.playerMonster[0].Hp} ATK: {Player.playerMonster[0].Attack}");
                        }

                        if (Player.playerMonster[0].Attack < Player.playerMonster[0].SpAttack)
                        {
                            Console.WriteLine(
                                $"HP: {Player.playerMonster[0].Hp} SpATK: {Player.playerMonster[0].SpAttack}");
                        }

                        if (Player.playerMonster[0].SpAttack == Player.playerMonster[0].Attack)
                        {
                            int randomdef = random.Next(0, 2);
                            if (randomdef == 0)
                            {
                                Console.WriteLine(
                                    $"HP: {currentHpMonsterPlayer} ATK: {Player.playerMonster[0].Attack}");
                            }

                            if (randomdef == 1)
                            {
                                Console.WriteLine(
                                    $"HP: {currentHpMonsterPlayer} Sp ATK: {Player.playerMonster[0].SpAttack}");
                            }
                        }


                        //set typeDefMonsterPlayer
                        if (forestmonster.Attack > forestmonster.SpAttack)
                        {

                            currentDefMonsterPlayer = Player.playerMonster[0].Defense;
                        }

                        if (forestmonster.SpAttack > forestmonster.Attack)
                        {
                            currentDefMonsterPlayer = Player.playerMonster[0].SpDefense;
                        }

                        if (forestmonster.SpAttack == forestmonster.Attack)
                        {
                            int randomdef = random.Next(0, 2);
                            if (randomdef == 0)
                            {
                                currentDefMonsterPlayer = Player.playerMonster[0].Defense;
                            }

                            if (randomdef == 1)
                            {
                                currentDefMonsterPlayer = Player.playerMonster[0].SpDefense;
                            }
                        }

                        //show monsterPlayerStatus
                        if (forestmonster.Attack > forestmonster.SpAttack)
                        {
                            Console.WriteLine($"Def: {currentDefMonsterPlayer} Speed: {Player.playerMonster[0].Speed}");
                        }

                        if (forestmonster.Attack < forestmonster.SpAttack)
                        {
                            Console.WriteLine(
                                $"SpDef: {currentDefMonsterPlayer} Speed: {Player.playerMonster[0].Speed}");
                        }

                        //battle
                        while (true)
                        {
                            int showdamage = 0;

                            ShowText("Please choose your order\n");
                            Console.WriteLine("1. Attack \n 2.Defense");
                            bool isTypeCorract = int.TryParse(Console.ReadLine(), out playerOrder);
                            if (isTypeCorract && playerOrder == 1 || isTypeCorract && playerOrder == 2)
                            {
                                if (playerOrder == 1)
                                {
                                    //mps > mfs?
                                    //yes
                                    if (Player.playerMonster[0].Speed > forestmonster.Speed)
                                    {
                                        //mp atk mf
                                        // mp attack > mp spAttack?
                                        if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                                        {
                                            currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                Player.playerMonster[0].Attack, forestmonster.Defense,
                                                currentHpMonsterForest);
                                            showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                Player.playerMonster[0].Attack, forestmonster.Defense);
                                        }
                                        // mp attack < mp spAttack?
                                        else if (Player.playerMonster[0].Attack < Player.playerMonster[0].SpAttack)
                                        {
                                            currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                currentHpMonsterForest);
                                            showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                        }
                                        // mp attack == mp spAttack?
                                        else if (Player.playerMonster[0].Attack == Player.playerMonster[0].SpAttack)
                                        {
                                            int order = random.Next(0, 2);
                                            if (order == 0)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                            }
                                            else if (order == 1)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense);
                                            }


                                        }

                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} Attack {forestmonster.NameMonster}");
                                        Console.WriteLine($"{forestmonster.NameMonster} takes {showdamage} damaged.");
                                        Console.WriteLine(
                                            $"{forestmonster.NameMonster}  has {currentHpMonsterForest} HP remaining.");
                                        //is mf die?
                                        //yes 
                                        if (currentHpMonsterForest <= 0)
                                        {

                                            //mp gain Exp
                                            Player.playerMonster[0].RequirExp +=
                                                CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                            int gainExp = CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} gain exp {gainExp} exp");
                                            //if mp exp >= expTarget?
                                            //yes
                                            if (Player.playerMonster[0].RequirExp >=
                                                Level.Levels[Player.playerMonster[0].LevelMonster].ExpRequi)
                                            {
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} Monster is Level up");
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} Level up to Level {Player.playerMonster[0].LevelMonster + 1} ");
                                                Monster updateMonster =
                                                    Monster.CaculateStat(Player.playerMonster[0].LevelMonster + 1,
                                                        Player.playerMonster[0].Index);
                                                Player.playerMonster[0] = new Player(updateMonster.NameMonster,
                                                    updateMonster.LevelMonster, 0, updateMonster.Hp,
                                                    updateMonster.Attack,
                                                    updateMonster.Defense, updateMonster.SpAttack,
                                                    updateMonster.SpDefense, updateMonster.Speed, updateMonster.Index);
                                                passturn--;
                                                Player.playerMonster[0].RequirExp = 0;
                                                break;

                                            }

                                            //if mp exp >= expTarget?
                                            //no
                                            passturn--;
                                            break;




                                        }

                                        //is mf die?
                                        //no
                                        else
                                        {

                                            //mf atk mp
                                            if (forestmonster.Attack > forestmonster.SpAttack)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer);
                                            }
                                            else if (forestmonster.Attack < forestmonster.SpAttack)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer);
                                            }
                                            else if (forestmonster.Attack == forestmonster.SpAttack)
                                            {
                                                int order = random.Next(0, 2);
                                                if (order == 0)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer);
                                                }
                                                else if (order == 1)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer);
                                                }

                                            }

                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");
                                            //is mp die?
                                            //yes
                                            if (currentHpMonsterPlayer <= 0)
                                            {
                                                ShowText("you died");
                                                if (forest ==1)
                                                {
                                                    Town(1 ,username);
                                                }
                                                if (forest == 2)
                                                {
                                                    Town(2,username);
                                                }
                                                
                                            }

                                            //is mp die?
                                            //no
                                            if (currentHpMonsterPlayer > 0)
                                            {
                                                continue;
                                            }



                                        }

                                    }
                                    //mps == mfs?
                                    else if (Player.playerMonster[0].Speed == forestmonster.Speed)
                                    {
                                        int randommonster = random.Next(0, 2);
                                        if (randommonster == 0)
                                        {
                                            //mp atk mf
                                            if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense);
                                            }
                                            else if (Player.playerMonster[0].Attack < Player.playerMonster[0].SpAttack)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                            }
                                            else if (Player.playerMonster[0].Attack == Player.playerMonster[0].SpAttack)
                                            {
                                                int order = random.Next(0, 2);
                                                if (order == 0)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                                }
                                                else if (order == 1)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense);
                                                }

                                            }

                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} Attack {forestmonster.NameMonster}");
                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster} takes {showdamage} damaged.");
                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster}  has {currentHpMonsterForest} HP remaining.");
                                            //is mf die?
                                            //yes 
                                            if (currentHpMonsterForest <= 0)
                                            {

                                                //mp gain Exp
                                                Player.playerMonster[0].RequirExp +=
                                                    CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                                int gainExp = CaculateExp(forestmonster.Exp,
                                                    forestmonster.LevelMonster);
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} gain exp {gainExp} exp");
                                                //if mp exp >= expTarget?
                                                //yes
                                                if (Player.playerMonster[0].RequirExp >=
                                                    Level.Levels[Player.playerMonster[0].LevelMonster].ExpRequi)
                                                {
                                                    Console.WriteLine(
                                                        $"{Player.playerMonster[0].NameMonster} Monster is Level up");
                                                    Console.WriteLine(
                                                        $"{Player.playerMonster[0].NameMonster} Level up to Level {Player.playerMonster[0].LevelMonster + 1} ");
                                                    Monster updateMonster =
                                                        Monster.CaculateStat(Player.playerMonster[0].LevelMonster + 1,
                                                            Player.playerMonster[0].Index);
                                                    Player.playerMonster[0] = new Player(updateMonster.NameMonster,
                                                        updateMonster.LevelMonster, 0, updateMonster.Hp,
                                                        updateMonster.Attack,
                                                        updateMonster.Defense, updateMonster.SpAttack,
                                                        updateMonster.SpDefense, updateMonster.Speed,
                                                        updateMonster.Index);
                                                    passturn--;
                                                    Player.playerMonster[0].RequirExp = 0;
                                                    break;

                                                }

                                                //if mp exp >= expTarget?
                                                //no
                                                passturn--;
                                                break;

                                            }

                                            //is mf die?
                                            //no
                                            else
                                            {

                                                //mf atk mp
                                                if (forestmonster.Attack > forestmonster.SpAttack)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer);
                                                }
                                                else if (forestmonster.Attack < forestmonster.SpAttack)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer);
                                                }
                                                else if (forestmonster.Attack == forestmonster.SpAttack)
                                                {
                                                    int order = random.Next(0, 2);
                                                    if (order == 0)
                                                    {
                                                        currentHpMonsterPlayer = CaculateDamage(
                                                            Player.playerMonster[0].LevelMonster,
                                                            forestmonster.SpAttack, currentDefMonsterPlayer,
                                                            currentHpMonsterPlayer);
                                                        showdamage = CaculateShowDamage(
                                                            Player.playerMonster[0].LevelMonster,
                                                            forestmonster.SpAttack, currentDefMonsterPlayer);
                                                    }
                                                    else if (order == 1)
                                                    {
                                                        currentHpMonsterPlayer = CaculateDamage(
                                                            Player.playerMonster[0].LevelMonster,
                                                            forestmonster.Attack, currentDefMonsterPlayer,
                                                            currentHpMonsterPlayer);
                                                        showdamage = CaculateShowDamage(
                                                            Player.playerMonster[0].LevelMonster,
                                                            forestmonster.Attack, currentDefMonsterPlayer);
                                                    }

                                                }

                                                Console.WriteLine(
                                                    $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");
                                                //is mp die?
                                                //yes
                                                if (currentHpMonsterPlayer <= 0)
                                                {
                                                    ShowText("you died");
                                                    if (forest ==1)
                                                    {
                                                        Town(1,username);
                                                    }
                                                    if (forest == 2)
                                                    {
                                                        Town(2,username);
                                                    }
                                                    
                                                }

                                                //is mp die?
                                                //no
                                                if (currentHpMonsterPlayer > 0)
                                                {
                                                    continue;
                                                }



                                            }
                                        }

                                        if (randommonster == 1)
                                        {

                                            //mf atk mp
                                            if (forestmonster.Attack > forestmonster.SpAttack)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer);
                                            }
                                            else if (forestmonster.Attack < forestmonster.SpAttack)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer);
                                            }
                                            else if (forestmonster.Attack == forestmonster.SpAttack)
                                            {
                                                int order = random.Next(0, 2);
                                                if (order == 0)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer);
                                                }
                                                else if (order == 1)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer);
                                                }

                                            }

                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");

                                            //is mp die?
                                            //yes
                                            if (currentHpMonsterPlayer <= 0)
                                            {
                                                ShowText("you died");
                                                if (forest ==1)
                                                {
                                                    Town(1,username);
                                                }
                                                if (forest == 2)
                                                {
                                                    Town(2,username);
                                                }
                                            }

                                            //is mp die?
                                            //no
                                            else
                                            {

                                                //mp atk mf
                                                if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense);
                                                }
                                                else if (Player.playerMonster[0].Attack <
                                                         Player.playerMonster[0].SpAttack)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                                }
                                                else if (Player.playerMonster[0].Attack ==
                                                         Player.playerMonster[0].SpAttack)
                                                {
                                                    int order = random.Next(0, 2);
                                                    if (order == 0)
                                                    {
                                                        currentHpMonsterForest = CaculateDamage(
                                                            forestmonster.LevelMonster,
                                                            Player.playerMonster[0].SpAttack, forestmonster.Defense,
                                                            currentHpMonsterForest);
                                                        showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                            Player.playerMonster[0].SpAttack, forestmonster.Defense);
                                                    }
                                                    else if (order == 1)
                                                    {
                                                        currentHpMonsterForest = CaculateDamage(
                                                            forestmonster.LevelMonster,
                                                            Player.playerMonster[0].Attack, forestmonster.Defense,
                                                            currentHpMonsterForest);
                                                        showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                            Player.playerMonster[0].Attack, forestmonster.Defense);
                                                    }

                                                }

                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} Attack {forestmonster.NameMonster}");
                                                Console.WriteLine(
                                                    $"{forestmonster.NameMonster} takes {showdamage} damaged.");
                                                Console.WriteLine(
                                                    $"{forestmonster.NameMonster}  has {currentHpMonsterForest} HP remaining.");
                                                //is mfs die?
                                                //yes
                                                if (currentHpMonsterForest <= 0)
                                                {
                                                    //mp gain Exp
                                                    int gainExp = CaculateExp(forestmonster.Exp,
                                                        forestmonster.LevelMonster);
                                                    Console.WriteLine(
                                                        $"{Player.playerMonster[0].NameMonster} gain exp {gainExp} exp");
                                                    Player.playerMonster[0].RequirExp +=
                                                        CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                                    //if mp exp >= expTarget?
                                                    //yes
                                                    if (Player.playerMonster[0].RequirExp >= Level
                                                            .Levels[Player.playerMonster[0].LevelMonster].ExpRequi)
                                                    {
                                                        Console.WriteLine(
                                                            $"{Player.playerMonster[0].NameMonster} Monster is Level up");
                                                        Console.WriteLine(
                                                            $"{Player.playerMonster[0].NameMonster} Level up to Level {Player.playerMonster[0].LevelMonster + 1} ");
                                                        Monster updateMonster =
                                                            Monster.CaculateStat(
                                                                Player.playerMonster[0].LevelMonster + 1,
                                                                Player.playerMonster[0].Index);
                                                        Player.playerMonster[0] = new Player(updateMonster.NameMonster,
                                                            updateMonster.LevelMonster, 0, updateMonster.Hp,
                                                            updateMonster.Attack,
                                                            updateMonster.Defense, updateMonster.SpAttack,
                                                            updateMonster.SpDefense, updateMonster.Speed,
                                                            updateMonster.Index);
                                                        passturn--;
                                                        Player.playerMonster[0].RequirExp = 0;
                                                        break;

                                                    }

                                                    //if mp exp >= expTarget?
                                                    //no
                                                    passturn--;
                                                    Console.ReadKey(true);
                                                    break;

                                                }
                                            }

                                        }
                                    }

                                    //mps > mfs?
                                    //no
                                    if (Player.playerMonster[0].Speed < forestmonster.Speed)
                                    {

                                        //mf atk mp
                                        if (forestmonster.Attack > forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer);
                                        }
                                        else if (forestmonster.Attack < forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer,
                                                currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer);
                                        }
                                        else if (forestmonster.Attack == forestmonster.SpAttack)
                                        {
                                            int order = random.Next(0, 2);
                                            if (order == 0)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer);
                                            }
                                            else if (order == 1)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer);
                                            }

                                        }

                                        Console.WriteLine(
                                            $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");

                                        //is mp die?
                                        //yes
                                        if (currentHpMonsterPlayer <= 0)
                                        {
                                            ShowText("you died");
                                            if (forest ==1)
                                            {
                                                Town(1,username);
                                            }
                                            if (forest == 2)
                                            {
                                                Town(2,username);
                                            }
                                        }

                                        //is mp die?
                                        //no
                                        else
                                        {

                                            //mp atk mf
                                            if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense);
                                            }
                                            else if (Player.playerMonster[0].Attack < Player.playerMonster[0].SpAttack)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                            }
                                            else if (Player.playerMonster[0].Attack == Player.playerMonster[0].SpAttack)
                                            {
                                                int order = random.Next(0, 2);
                                                if (order == 0)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                                }
                                                else if (order == 1)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense);
                                                }

                                            }

                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} Attack {forestmonster.NameMonster}");
                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster} takes {showdamage} damaged.");
                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster}  has {currentHpMonsterForest} HP remaining.");
                                            //is mfs die?
                                            //yes
                                            if (currentHpMonsterForest <= 0)
                                            {
                                                //mp gain Exp
                                                int gainExp = CaculateExp(forestmonster.Exp,
                                                    forestmonster.LevelMonster);
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} gain exp {gainExp} exp");
                                                Player.playerMonster[0].RequirExp +=
                                                    CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                                //if mp exp >= expTarget?
                                                //yes
                                                if (Player.playerMonster[0].RequirExp >=
                                                    Level.Levels[Player.playerMonster[0].LevelMonster].ExpRequi)
                                                {
                                                    Console.WriteLine(
                                                        $"{Player.playerMonster[0].NameMonster} Monster is Level up");
                                                    Console.WriteLine(
                                                        $"{Player.playerMonster[0].NameMonster} Level up to Level {Player.playerMonster[0].LevelMonster + 1} ");
                                                    Monster updateMonster =
                                                        Monster.CaculateStat(Player.playerMonster[0].LevelMonster + 1,
                                                            Player.playerMonster[0].Index);
                                                    Player.playerMonster[0] = new Player(updateMonster.NameMonster,
                                                        updateMonster.LevelMonster, 0, updateMonster.Hp,
                                                        updateMonster.Attack,
                                                        updateMonster.Defense, updateMonster.SpAttack,
                                                        updateMonster.SpDefense, updateMonster.Speed,
                                                        updateMonster.Index);
                                                    passturn--;
                                                    Player.playerMonster[0].RequirExp = 0;
                                                    break;

                                                }

                                                //if mp exp >= expTarget?
                                                //no
                                                passturn--;
                                                Console.ReadKey(true);
                                                break;

                                            }
                                            
                                        }
            
                                    }
                                }




                            }

                            // playerOrder == 2
                            if (playerOrder == 2)
                            {
                                //mps > mfs?
                                //yes
                                if (Player.playerMonster[0].Speed > forestmonster.Speed)
                                {
                                    //mp def status +20%
                                    currentDefMonsterPlayer +=
                                        Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100);
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster} gains {Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100)} defense.");
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster} have {currentDefMonsterPlayer} defense now.");
                                    //mf atk mp
                                    if (forestmonster.Attack > forestmonster.SpAttack)
                                    {
                                        currentHpMonsterPlayer = CaculateDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                        showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.Attack, currentDefMonsterPlayer);
                                    }
                                    else if (forestmonster.Attack < forestmonster.SpAttack)
                                    {
                                        currentHpMonsterPlayer = CaculateDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.SpAttack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                        showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.SpAttack, currentDefMonsterPlayer);
                                    }
                                    else if (forestmonster.Attack == forestmonster.SpAttack)
                                    {
                                        int order = random.Next(0, 2);
                                        if (order == 0)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer,
                                                currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer);
                                        }
                                        else if (order == 1)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer);
                                        }

                                    }

                                    Console.WriteLine(
                                        $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");
                                    //is mp die?
                                    //yes
                                    if (currentHpMonsterPlayer <= 0)
                                    {
                                        ShowText("you died");
                                        if (forest ==1)
                                        {
                                            Town(1,username);
                                        }
                                        if (forest == 2)
                                        {
                                            Town(2,username);
                                        }
                                    }

                                    //is mp die?
                                    //no
                                    
                                    continue;
                                }

                                // mps == mfs
                                if (Player.playerMonster[0].Speed == forestmonster.Speed)
                                {
                                    int randommonster = random.Next(0, 2);
                                    if (randommonster == 0)
                                    {
                                        //mp def status +20%
                                        currentDefMonsterPlayer +=
                                            Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100);
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} gains {Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100)} defense.");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} have {currentDefMonsterPlayer} defense now.");
                                        //mf atk mp

                                        //check if mf has status attack > spAttack
                                        if (forestmonster.Attack > forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer);
                                        }
                                        //check if mf has status attack < spAttack
                                        else if (forestmonster.Attack < forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer,
                                                currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer);
                                        }
                                        //check if mf has status attack = spAttack
                                        else if (forestmonster.Attack == forestmonster.SpAttack)
                                        {
                                            int order = random.Next(0, 2);
                                            if (order == 0)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer);
                                            }
                                            else if (order == 1)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer);
                                            }

                                        }

                                        Console.WriteLine(
                                            $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");
                                        //is mp die?
                                        //yes
                                        if (currentHpMonsterPlayer <= 0)
                                        {
                                            ShowText("you died");
                                            if (forest ==1)
                                            {
                                                Town(1,username);
                                            }
                                            if (forest == 2)
                                            {
                                                Town(2,username);
                                            }
                                        }

                                        //is mp die?
                                        //no
                                        continue;
                                    }

                                    if (randommonster == 1)
                                    {

                                        //mf atk mp
                                        if (forestmonster.Attack > forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer);
                                        }
                                        else if (forestmonster.Attack < forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer,
                                                currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer);
                                        }
                                        else if (forestmonster.Attack == forestmonster.SpAttack)
                                        {
                                            int order = random.Next(0, 2);
                                            if (order == 0)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer);
                                            }
                                            else if (order == 1)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer);
                                            }

                                        }

                                        Console.WriteLine(
                                            $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");

                                        //is mp die?
                                        //yes
                                        if (currentHpMonsterPlayer <= 0)
                                        {
                                            ShowText("you died");
                                            if (forest ==1)
                                            {
                                                Town(1,username);
                                            }
                                            if (forest == 2)
                                            {
                                                Town(2,username);
                                            }
                                        }

                                        //is mp die?
                                        //no
                                        else
                                        {

                                            //mp def status +20%
                                            currentDefMonsterPlayer +=
                                                Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100);
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} gains {Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100)} defense.");
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} have {currentDefMonsterPlayer} defense now.");
                                            continue;

                                        }
                                    }

                                }

                                //mps > mfs?
                                //no
                                if (Player.playerMonster[0].Speed < forestmonster.Speed)
                                {
                                    //mf atk mp
                                    if (forestmonster.Attack > forestmonster.SpAttack)
                                    {
                                        currentHpMonsterPlayer = CaculateDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                        showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.Attack, currentDefMonsterPlayer);
                                    }
                                    else if (forestmonster.Attack < forestmonster.SpAttack)
                                    {
                                        currentHpMonsterPlayer = CaculateDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.SpAttack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                        showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.SpAttack, currentDefMonsterPlayer);
                                    }
                                    else if (forestmonster.Attack == forestmonster.SpAttack)
                                    {
                                        int order = random.Next(0, 2);
                                        if (order == 0)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer,
                                                currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer);
                                        }
                                        else if (order == 1)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer);
                                        }

                                    }

                                    Console.WriteLine(
                                        $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");

                                    //is mp die?
                                    //yes
                                    if (currentHpMonsterPlayer <= 0)
                                    {
                                        ShowText("you died");
                                        if (forest ==1)
                                        {
                                            Town(1,username);
                                        }
                                        if (forest == 2)
                                        {
                                            Town(2,username);
                                        }
                                    }

                                    //is mp die?
                                    //no
                                    else
                                    {
                                        //mp def status +20%
                                        currentDefMonsterPlayer +=
                                            Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100);
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} gains {Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100)} defense.");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} have {currentDefMonsterPlayer} defense now.");
                                        continue;

                                    }
                                }
                            }


                            if (!isTypeCorract || playerOrder < 1 || playerOrder > 2)
                            {
                                Console.WriteLine("Please Enter number 1 or 2");
                                Console.ReadKey(true);
                            }
                        }

                    }

                    if (forest == 1)
                    {
                        Town(2,username);
                    }
                    if (forest == 2)
                    {
                        Town(3,username);
                    }
                    
                    
                }
        public static void GymLeader(int gym , string username)
                {
                    Monster forestmonster = null;
                    int currentHpMonsterForest;
                    int currentHpMonsterPlayer;
                    int currentDefMonsterPlayer = 0;


                    int passturn = 2;
                    if (gym ==1)
                    {
                        Console.WriteLine($"{username} : Hey! are you a Gym leader? I need to ask you something.");
                        Console.WriteLine($"Gym leader : I'll tell you everything if you can win my monster! Come on!!!!!!!!!");
                    }
                    if (gym ==2)
                    {
                        Console.WriteLine($"{username} : You are a gym leader, right? I want to ask you something.");
                        Console.WriteLine($"Gym leader :  Of course, I can tell you, but you know what to do to make me speak, right? Get in!!!!!");
                    }
                    
                    
                    while (passturn > 0)
                    {
                        Random random = new Random();
                        int num = random.Next(1, 101);
                        
                        //set random  GymLeader1
                        if (gym == 1)
                        {
                                int rd = random.Next(0, 2);
                                switch (rd)
                                {
                                    case 0:
                                        forestmonster = Monster.CaculateStat(7, 23);
                                        break;
                                    case 1:
                                        forestmonster = Monster.CaculateStat(8, 24);
                                        break;
                                }
                            
                            
                        }

                        //set random  GymLeader2
                        if (gym == 2)
                        {
                            int rd = random.Next(0, 2);
                            switch (rd)
                            {
                                case 0:
                                    forestmonster = Monster.CaculateStat(12, 25);
                                    break;
                                case 1:
                                    forestmonster = Monster.CaculateStat(13, 26);
                                    break;
                            }
                        }


                        ShowText($" {forestmonster.NameMonster} appear!!\n");
                        int playerOrder;
                        currentHpMonsterForest = forestmonster.Hp;
                        currentHpMonsterPlayer = Player.playerMonster[0].Hp;

                        //show monsterForestStatus
                        Console.WriteLine($"{forestmonster.NameMonster}  has {forestmonster.LevelMonster} Level .");
                        if (forestmonster.Attack > forestmonster.SpAttack)
                        {
                            Console.WriteLine($"HP: {currentHpMonsterForest} ATK: {forestmonster.Attack}");
                        }

                        if (forestmonster.Attack < forestmonster.SpAttack)
                        {
                            Console.WriteLine($"HP: {currentHpMonsterForest} Sp ATK: {forestmonster.SpAttack}");
                        }

                        if (forestmonster.SpAttack == forestmonster.Attack)
                        {
                            int randomdef = random.Next(0, 2);
                            if (randomdef == 0)
                            {
                                Console.WriteLine($"HP: {currentHpMonsterForest} ATK: {forestmonster.Attack}");
                            }

                            if (randomdef == 1)
                            {
                                Console.WriteLine($"HP: {currentHpMonsterForest} Sp ATK: {forestmonster.SpAttack}");
                            }
                        }

                        if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                        {
                            Console.WriteLine($"Def: {forestmonster.Defense} Speed: {forestmonster.Speed}");
                        }

                        if (Player.playerMonster[0].Attack < Player.playerMonster[0].SpAttack)
                        {
                            Console.WriteLine($"SpDef: {forestmonster.SpDefense} Speed: {forestmonster.Speed}");
                        }


                        //show monsterPlayerStatus
                        Console.WriteLine(
                            $"{Player.playerMonster[0].NameMonster}  has {Player.playerMonster[0].LevelMonster} Level .");
                        if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                        {
                            Console.WriteLine(
                                $"HP: {Player.playerMonster[0].Hp} ATK: {Player.playerMonster[0].Attack}");
                        }

                        if (Player.playerMonster[0].Attack < Player.playerMonster[0].SpAttack)
                        {
                            Console.WriteLine(
                                $"HP: {Player.playerMonster[0].Hp} SpATK: {Player.playerMonster[0].SpAttack}");
                        }

                        if (Player.playerMonster[0].SpAttack == Player.playerMonster[0].Attack)
                        {
                            int randomdef = random.Next(0, 2);
                            if (randomdef == 0)
                            {
                                Console.WriteLine(
                                    $"HP: {currentHpMonsterPlayer} ATK: {Player.playerMonster[0].Attack}");
                            }

                            if (randomdef == 1)
                            {
                                Console.WriteLine(
                                    $"HP: {currentHpMonsterPlayer} Sp ATK: {Player.playerMonster[0].SpAttack}");
                            }
                        }


                        //set typeDefMonsterPlayer
                        if (forestmonster.Attack > forestmonster.SpAttack)
                        {

                            currentDefMonsterPlayer = Player.playerMonster[0].Defense;
                        }

                        if (forestmonster.SpAttack > forestmonster.Attack)
                        {
                            currentDefMonsterPlayer = Player.playerMonster[0].SpDefense;
                        }

                        if (forestmonster.SpAttack == forestmonster.Attack)
                        {
                            int randomdef = random.Next(0, 2);
                            if (randomdef == 0)
                            {
                                currentDefMonsterPlayer = Player.playerMonster[0].Defense;
                            }

                            if (randomdef == 1)
                            {
                                currentDefMonsterPlayer = Player.playerMonster[0].SpDefense;
                            }
                        }

                        //show monsterPlayerStatus
                        if (forestmonster.Attack > forestmonster.SpAttack)
                        {
                            Console.WriteLine($"Def: {currentDefMonsterPlayer} Speed: {Player.playerMonster[0].Speed}");
                        }

                        if (forestmonster.Attack < forestmonster.SpAttack)
                        {
                            Console.WriteLine(
                                $"SpDef: {currentDefMonsterPlayer} Speed: {Player.playerMonster[0].Speed}");
                        }

                        //battle
                        while (true)
                        {
                            int showdamage = 0;

                            ShowText("Please choose your order\n");
                            Console.WriteLine("1. Attack \n 2.Defense");
                            bool isTypeCorract = int.TryParse(Console.ReadLine(), out playerOrder);
                            if (isTypeCorract && playerOrder == 1 || isTypeCorract && playerOrder == 2)
                            {
                                if (playerOrder == 1)
                                {
                                    //mps > mfs?
                                    //yes
                                    if (Player.playerMonster[0].Speed > forestmonster.Speed)
                                    {
                                        //mp atk mf
                                        // mp attack > mp spAttack?
                                        if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                                        {
                                            currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                Player.playerMonster[0].Attack, forestmonster.Defense,
                                                currentHpMonsterForest);
                                            showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                Player.playerMonster[0].Attack, forestmonster.Defense);
                                        }
                                        // mp attack < mp spAttack?
                                        else if (Player.playerMonster[0].Attack < Player.playerMonster[0].SpAttack)
                                        {
                                            currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                currentHpMonsterForest);
                                            showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                        }
                                        // mp attack == mp spAttack?
                                        else if (Player.playerMonster[0].Attack == Player.playerMonster[0].SpAttack)
                                        {
                                            int order = random.Next(0, 2);
                                            if (order == 0)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                            }
                                            else if (order == 1)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense);
                                            }


                                        }

                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} Attack {forestmonster.NameMonster}");
                                        Console.WriteLine($"{forestmonster.NameMonster} takes {showdamage} damaged.");
                                        Console.WriteLine(
                                            $"{forestmonster.NameMonster}  has {currentHpMonsterForest} HP remaining.");
                                        //is mf die?
                                        //yes 
                                        if (currentHpMonsterForest <= 0)
                                        {

                                            //mp gain Exp
                                            Player.playerMonster[0].RequirExp +=
                                                CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                            int gainExp = CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} gain exp {gainExp} exp");
                                            //if mp exp >= expTarget?
                                            //yes
                                            if (Player.playerMonster[0].RequirExp >=
                                                Level.Levels[Player.playerMonster[0].LevelMonster].ExpRequi)
                                            {
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} Monster is Level up");
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} Level up to Level {Player.playerMonster[0].LevelMonster + 1} ");
                                                Monster updateMonster =
                                                    Monster.CaculateStat(Player.playerMonster[0].LevelMonster + 1,
                                                        Player.playerMonster[0].Index);
                                                Player.playerMonster[0] = new Player(updateMonster.NameMonster,
                                                    updateMonster.LevelMonster, 0, updateMonster.Hp,
                                                    updateMonster.Attack,
                                                    updateMonster.Defense, updateMonster.SpAttack,
                                                    updateMonster.SpDefense, updateMonster.Speed, updateMonster.Index);
                                                passturn--;
                                                Player.playerMonster[0].RequirExp = 0;
                                                break;

                                            }

                                            //if mp exp >= expTarget?
                                            //no
                                            passturn--;
                                            break;




                                        }

                                        //is mf die?
                                        //no
                                        else
                                        {

                                            //mf atk mp
                                            if (forestmonster.Attack > forestmonster.SpAttack)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer);
                                            }
                                            else if (forestmonster.Attack < forestmonster.SpAttack)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer);
                                            }
                                            else if (forestmonster.Attack == forestmonster.SpAttack)
                                            {
                                                int order = random.Next(0, 2);
                                                if (order == 0)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer);
                                                }
                                                else if (order == 1)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer);
                                                }

                                            }

                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");
                                            //is mp die?
                                            //yes
                                            if (currentHpMonsterPlayer <= 0)
                                            {
                                                ShowText("you died");
                                                if (gym == 1)
                                                {
                                                    Town(2,username);
                                                }
                                                if (gym == 2)
                                                {
                                                    Town(3,username);
                                                }
                                                
                                            }

                                            //is mp die?
                                            //no
                                            if (currentHpMonsterPlayer > 0)
                                            {
                                                continue;
                                            }



                                        }

                                    }
                                    //mps == mfs?
                                    else if (Player.playerMonster[0].Speed == forestmonster.Speed)
                                    {
                                        int randommonster = random.Next(0, 2);
                                        if (randommonster == 0)
                                        {
                                            //mp atk mf
                                            if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense);
                                            }
                                            else if (Player.playerMonster[0].Attack < Player.playerMonster[0].SpAttack)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                            }
                                            else if (Player.playerMonster[0].Attack == Player.playerMonster[0].SpAttack)
                                            {
                                                int order = random.Next(0, 2);
                                                if (order == 0)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                                }
                                                else if (order == 1)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense);
                                                }

                                            }

                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} Attack {forestmonster.NameMonster}");
                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster} takes {showdamage} damaged.");
                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster}  has {currentHpMonsterForest} HP remaining.");
                                            //is mf die?
                                            //yes 
                                            if (currentHpMonsterForest <= 0)
                                            {

                                                //mp gain Exp
                                                Player.playerMonster[0].RequirExp +=
                                                    CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                                int gainExp = CaculateExp(forestmonster.Exp,
                                                    forestmonster.LevelMonster);
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} gain exp {gainExp} exp");
                                                //if mp exp >= expTarget?
                                                //yes
                                                if (Player.playerMonster[0].RequirExp >=
                                                    Level.Levels[Player.playerMonster[0].LevelMonster].ExpRequi)
                                                {
                                                    Console.WriteLine(
                                                        $"{Player.playerMonster[0].NameMonster} Monster is Level up");
                                                    Console.WriteLine(
                                                        $"{Player.playerMonster[0].NameMonster} Level up to Level {Player.playerMonster[0].LevelMonster + 1} ");
                                                    Monster updateMonster =
                                                        Monster.CaculateStat(Player.playerMonster[0].LevelMonster + 1,
                                                            Player.playerMonster[0].Index);
                                                    Player.playerMonster[0] = new Player(updateMonster.NameMonster,
                                                        updateMonster.LevelMonster, 0, updateMonster.Hp,
                                                        updateMonster.Attack,
                                                        updateMonster.Defense, updateMonster.SpAttack,
                                                        updateMonster.SpDefense, updateMonster.Speed,
                                                        updateMonster.Index);
                                                    passturn--;
                                                    Player.playerMonster[0].RequirExp = 0;
                                                    break;

                                                }

                                                //if mp exp >= expTarget?
                                                //no
                                                passturn--;
                                                break;

                                            }

                                            //is mf die?
                                            //no
                                            else
                                            {

                                                //mf atk mp
                                                if (forestmonster.Attack > forestmonster.SpAttack)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer);
                                                }
                                                else if (forestmonster.Attack < forestmonster.SpAttack)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer);
                                                }
                                                else if (forestmonster.Attack == forestmonster.SpAttack)
                                                {
                                                    int order = random.Next(0, 2);
                                                    if (order == 0)
                                                    {
                                                        currentHpMonsterPlayer = CaculateDamage(
                                                            Player.playerMonster[0].LevelMonster,
                                                            forestmonster.SpAttack, currentDefMonsterPlayer,
                                                            currentHpMonsterPlayer);
                                                        showdamage = CaculateShowDamage(
                                                            Player.playerMonster[0].LevelMonster,
                                                            forestmonster.SpAttack, currentDefMonsterPlayer);
                                                    }
                                                    else if (order == 1)
                                                    {
                                                        currentHpMonsterPlayer = CaculateDamage(
                                                            Player.playerMonster[0].LevelMonster,
                                                            forestmonster.Attack, currentDefMonsterPlayer,
                                                            currentHpMonsterPlayer);
                                                        showdamage = CaculateShowDamage(
                                                            Player.playerMonster[0].LevelMonster,
                                                            forestmonster.Attack, currentDefMonsterPlayer);
                                                    }

                                                }

                                                Console.WriteLine(
                                                    $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");
                                                //is mp die?
                                                //yes
                                                if (currentHpMonsterPlayer <= 0)
                                                {
                                                    ShowText("you died");
                                                    if (gym == 1)
                                                    {
                                                        Town(2,username);
                                                    }
                                                    if (gym == 2)
                                                    {
                                                        Town(3,username);
                                                    }
                                                }

                                                //is mp die?
                                                //no
                                                if (currentHpMonsterPlayer > 0)
                                                {
                                                    continue;
                                                }



                                            }
                                        }

                                        if (randommonster == 1)
                                        {

                                            //mf atk mp
                                            if (forestmonster.Attack > forestmonster.SpAttack)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer);
                                            }
                                            else if (forestmonster.Attack < forestmonster.SpAttack)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer);
                                            }
                                            else if (forestmonster.Attack == forestmonster.SpAttack)
                                            {
                                                int order = random.Next(0, 2);
                                                if (order == 0)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.SpAttack, currentDefMonsterPlayer);
                                                }
                                                else if (order == 1)
                                                {
                                                    currentHpMonsterPlayer = CaculateDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer,
                                                        currentHpMonsterPlayer);
                                                    showdamage = CaculateShowDamage(
                                                        Player.playerMonster[0].LevelMonster,
                                                        forestmonster.Attack, currentDefMonsterPlayer);
                                                }

                                            }

                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");

                                            //is mp die?
                                            //yes
                                            if (currentHpMonsterPlayer <= 0)
                                            {
                                                ShowText("you died");
                                                if (gym == 1)
                                                {
                                                    Town(2,username);
                                                }
                                                if (gym == 2)
                                                {
                                                    Town(3,username);
                                                }
                                            }

                                            //is mp die?
                                            //no
                                            else
                                            {

                                                //mp atk mf
                                                if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense);
                                                }
                                                else if (Player.playerMonster[0].Attack <
                                                         Player.playerMonster[0].SpAttack)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                                }
                                                else if (Player.playerMonster[0].Attack ==
                                                         Player.playerMonster[0].SpAttack)
                                                {
                                                    int order = random.Next(0, 2);
                                                    if (order == 0)
                                                    {
                                                        currentHpMonsterForest = CaculateDamage(
                                                            forestmonster.LevelMonster,
                                                            Player.playerMonster[0].SpAttack, forestmonster.Defense,
                                                            currentHpMonsterForest);
                                                        showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                            Player.playerMonster[0].SpAttack, forestmonster.Defense);
                                                    }
                                                    else if (order == 1)
                                                    {
                                                        currentHpMonsterForest = CaculateDamage(
                                                            forestmonster.LevelMonster,
                                                            Player.playerMonster[0].Attack, forestmonster.Defense,
                                                            currentHpMonsterForest);
                                                        showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                            Player.playerMonster[0].Attack, forestmonster.Defense);
                                                    }

                                                }

                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} Attack {forestmonster.NameMonster}");
                                                Console.WriteLine(
                                                    $"{forestmonster.NameMonster} takes {showdamage} damaged.");
                                                Console.WriteLine(
                                                    $"{forestmonster.NameMonster}  has {currentHpMonsterForest} HP remaining.");
                                                //is mfs die?
                                                //yes
                                                if (currentHpMonsterForest <= 0)
                                                {
                                                    //mp gain Exp
                                                    int gainExp = CaculateExp(forestmonster.Exp,
                                                        forestmonster.LevelMonster);
                                                    Console.WriteLine(
                                                        $"{Player.playerMonster[0].NameMonster} gain exp {gainExp} exp");
                                                    Player.playerMonster[0].RequirExp +=
                                                        CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                                    //if mp exp >= expTarget?
                                                    //yes
                                                    if (Player.playerMonster[0].RequirExp >= Level
                                                            .Levels[Player.playerMonster[0].LevelMonster].ExpRequi)
                                                    {
                                                        Console.WriteLine(
                                                            $"{Player.playerMonster[0].NameMonster} Monster is Level up");
                                                        Console.WriteLine(
                                                            $"{Player.playerMonster[0].NameMonster} Level up to Level {Player.playerMonster[0].LevelMonster + 1} ");
                                                        Monster updateMonster =
                                                            Monster.CaculateStat(
                                                                Player.playerMonster[0].LevelMonster + 1,
                                                                Player.playerMonster[0].Index);
                                                        Player.playerMonster[0] = new Player(updateMonster.NameMonster,
                                                            updateMonster.LevelMonster, 0, updateMonster.Hp,
                                                            updateMonster.Attack,
                                                            updateMonster.Defense, updateMonster.SpAttack,
                                                            updateMonster.SpDefense, updateMonster.Speed,
                                                            updateMonster.Index);
                                                        passturn--;
                                                        Player.playerMonster[0].RequirExp = 0;
                                                        break;

                                                    }

                                                    //if mp exp >= expTarget?
                                                    //no
                                                    passturn--;
                                                    Console.ReadKey(true);
                                                    break;

                                                }
                                            }

                                        }
                                    }

                                    //mps > mfs?
                                    //no
                                    if (Player.playerMonster[0].Speed < forestmonster.Speed)
                                    {

                                        //mf atk mp
                                        if (forestmonster.Attack > forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer);
                                        }
                                        else if (forestmonster.Attack < forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer,
                                                currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer);
                                        }
                                        else if (forestmonster.Attack == forestmonster.SpAttack)
                                        {
                                            int order = random.Next(0, 2);
                                            if (order == 0)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer);
                                            }
                                            else if (order == 1)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer);
                                            }

                                        }

                                        Console.WriteLine(
                                            $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");

                                        //is mp die?
                                        //yes
                                        if (currentHpMonsterPlayer <= 0)
                                        {
                                            ShowText("you died");
                                            if (gym == 1)
                                            {
                                                Town(2,username);
                                            }
                                            if (gym == 2)
                                            {
                                                Town(3,username);
                                            }
                                        }

                                        //is mp die?
                                        //no
                                        else
                                        {

                                            //mp atk mf
                                            if (Player.playerMonster[0].Attack > Player.playerMonster[0].SpAttack)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].Attack, forestmonster.Defense);
                                            }
                                            else if (Player.playerMonster[0].Attack < Player.playerMonster[0].SpAttack)
                                            {
                                                currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                    currentHpMonsterForest);
                                                showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                    Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                            }
                                            else if (Player.playerMonster[0].Attack == Player.playerMonster[0].SpAttack)
                                            {
                                                int order = random.Next(0, 2);
                                                if (order == 0)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].SpAttack, forestmonster.SpDefense);
                                                }
                                                else if (order == 1)
                                                {
                                                    currentHpMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense,
                                                        currentHpMonsterForest);
                                                    showdamage = CaculateShowDamage(forestmonster.LevelMonster,
                                                        Player.playerMonster[0].Attack, forestmonster.Defense);
                                                }

                                            }

                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} Attack {forestmonster.NameMonster}");
                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster} takes {showdamage} damaged.");
                                            Console.WriteLine(
                                                $"{forestmonster.NameMonster}  has {currentHpMonsterForest} HP remaining.");
                                            //is mfs die?
                                            //yes
                                            if (currentHpMonsterForest <= 0)
                                            {
                                                //mp gain Exp
                                                int gainExp = CaculateExp(forestmonster.Exp,
                                                    forestmonster.LevelMonster);
                                                Console.WriteLine(
                                                    $"{Player.playerMonster[0].NameMonster} gain exp {gainExp} exp");
                                                Player.playerMonster[0].RequirExp +=
                                                    CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                                //if mp exp >= expTarget?
                                                //yes
                                                if (Player.playerMonster[0].RequirExp >=
                                                    Level.Levels[Player.playerMonster[0].LevelMonster].ExpRequi)
                                                {
                                                    Console.WriteLine(
                                                        $"{Player.playerMonster[0].NameMonster} Monster is Level up");
                                                    Console.WriteLine(
                                                        $"{Player.playerMonster[0].NameMonster} Level up to Level {Player.playerMonster[0].LevelMonster + 1} ");
                                                    Monster updateMonster =
                                                        Monster.CaculateStat(Player.playerMonster[0].LevelMonster + 1,
                                                            Player.playerMonster[0].Index);
                                                    Player.playerMonster[0] = new Player(updateMonster.NameMonster,
                                                        updateMonster.LevelMonster, 0, updateMonster.Hp,
                                                        updateMonster.Attack,
                                                        updateMonster.Defense, updateMonster.SpAttack,
                                                        updateMonster.SpDefense, updateMonster.Speed,
                                                        updateMonster.Index);
                                                    passturn--;
                                                    Player.playerMonster[0].RequirExp = 0;
                                                    break;

                                                }

                                                //if mp exp >= expTarget?
                                                //no
                                                passturn--;
                                                Console.ReadKey(true);
                                                break;

                                            }
                                            
                                        }
            
                                    }
                                }




                            }

                            // playerOrder == 2
                            if (playerOrder == 2)
                            {
                                //mps > mfs?
                                //yes
                                if (Player.playerMonster[0].Speed > forestmonster.Speed)
                                {
                                    //mp def status +20%
                                    currentDefMonsterPlayer +=
                                        Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100);
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster} gains {Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100)} defense.");
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster} have {currentDefMonsterPlayer} defense now.");
                                    //mf atk mp
                                    if (forestmonster.Attack > forestmonster.SpAttack)
                                    {
                                        currentHpMonsterPlayer = CaculateDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                        showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.Attack, currentDefMonsterPlayer);
                                    }
                                    else if (forestmonster.Attack < forestmonster.SpAttack)
                                    {
                                        currentHpMonsterPlayer = CaculateDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.SpAttack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                        showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.SpAttack, currentDefMonsterPlayer);
                                    }
                                    else if (forestmonster.Attack == forestmonster.SpAttack)
                                    {
                                        int order = random.Next(0, 2);
                                        if (order == 0)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer,
                                                currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer);
                                        }
                                        else if (order == 1)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer);
                                        }

                                    }

                                    Console.WriteLine(
                                        $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");
                                    //is mp die?
                                    //yes
                                    if (currentHpMonsterPlayer <= 0)
                                    {
                                        ShowText("you died");
                                        if (gym == 1)
                                        {
                                            Town(2,username);
                                        }
                                        if (gym == 2)
                                        {
                                            Town(3,username);
                                        }
                                    }

                                    //is mp die?
                                    //no
                                    Console.ReadKey(true);
                                    continue;
                                }

                                // mps == mfs
                                if (Player.playerMonster[0].Speed == forestmonster.Speed)
                                {
                                    int randommonster = random.Next(0, 2);
                                    if (randommonster == 0)
                                    {
                                        //mp def status +20%
                                        currentDefMonsterPlayer +=
                                            Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100);
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} gains {Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100)} defense.");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} have {currentDefMonsterPlayer} defense now.");
                                        //mf atk mp

                                        //check if mf has status attack > spAttack
                                        if (forestmonster.Attack > forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer);
                                        }
                                        //check if mf has status attack < spAttack
                                        else if (forestmonster.Attack < forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer,
                                                currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer);
                                        }
                                        //check if mf has status attack = spAttack
                                        else if (forestmonster.Attack == forestmonster.SpAttack)
                                        {
                                            int order = random.Next(0, 2);
                                            if (order == 0)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer);
                                            }
                                            else if (order == 1)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer);
                                            }

                                        }

                                        Console.WriteLine(
                                            $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");
                                        //is mp die?
                                        //yes
                                        if (currentHpMonsterPlayer <= 0)
                                        {
                                            ShowText("you died");
                                            if (gym == 1)
                                            {
                                                Town(2,username);
                                            }
                                            if (gym == 2)
                                            {
                                                Town(3,username);
                                            }
                                        }

                                        //is mp die?
                                        //no
                                        continue;
                                    }

                                    if (randommonster == 1)
                                    {

                                        //mf atk mp
                                        if (forestmonster.Attack > forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer);
                                        }
                                        else if (forestmonster.Attack < forestmonster.SpAttack)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer,
                                                currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer);
                                        }
                                        else if (forestmonster.Attack == forestmonster.SpAttack)
                                        {
                                            int order = random.Next(0, 2);
                                            if (order == 0)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.SpAttack, currentDefMonsterPlayer);
                                            }
                                            else if (order == 1)
                                            {
                                                currentHpMonsterPlayer = CaculateDamage(
                                                    Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer,
                                                    currentHpMonsterPlayer);
                                                showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                    forestmonster.Attack, currentDefMonsterPlayer);
                                            }

                                        }

                                        Console.WriteLine(
                                            $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");

                                        //is mp die?
                                        //yes
                                        if (currentHpMonsterPlayer <= 0)
                                        {
                                            ShowText("you died");
                                            if (gym == 1)
                                            {
                                                Town(2,username);
                                            }
                                            if (gym == 2)
                                            {
                                                Town(3,username);
                                            }
                                        }

                                        //is mp die?
                                        //no
                                        else
                                        {

                                            //mp def status +20%
                                            currentDefMonsterPlayer +=
                                                Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100);
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} gains {Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100)} defense.");
                                            Console.WriteLine(
                                                $"{Player.playerMonster[0].NameMonster} have {currentDefMonsterPlayer} defense now.");
                                            continue;

                                        }
                                    }

                                }

                                //mps > mfs?
                                //no
                                if (Player.playerMonster[0].Speed < forestmonster.Speed)
                                {
                                    //mf atk mp
                                    if (forestmonster.Attack > forestmonster.SpAttack)
                                    {
                                        currentHpMonsterPlayer = CaculateDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                        showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.Attack, currentDefMonsterPlayer);
                                    }
                                    else if (forestmonster.Attack < forestmonster.SpAttack)
                                    {
                                        currentHpMonsterPlayer = CaculateDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.SpAttack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                        showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                            forestmonster.SpAttack, currentDefMonsterPlayer);
                                    }
                                    else if (forestmonster.Attack == forestmonster.SpAttack)
                                    {
                                        int order = random.Next(0, 2);
                                        if (order == 0)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer,
                                                currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.SpAttack, currentDefMonsterPlayer);
                                        }
                                        else if (order == 1)
                                        {
                                            currentHpMonsterPlayer = CaculateDamage(
                                                Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer, currentHpMonsterPlayer);
                                            showdamage = CaculateShowDamage(Player.playerMonster[0].LevelMonster,
                                                forestmonster.Attack, currentDefMonsterPlayer);
                                        }

                                    }

                                    Console.WriteLine(
                                        $"{forestmonster.NameMonster} Attack {Player.playerMonster[0].NameMonster} ");
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster} takes {showdamage} damaged.");
                                    Console.WriteLine(
                                        $"{Player.playerMonster[0].NameMonster}  has {currentHpMonsterPlayer} HP remaining.");

                                    //is mp die?
                                    //yes
                                    if (currentHpMonsterPlayer <= 0)
                                    {
                                        ShowText("you died");
                                        if (gym == 1)
                                        {
                                            Town(2,username);
                                        }
                                        if (gym == 2)
                                        {
                                            Town(3,username);
                                        }
                                    }

                                    //is mp die?
                                    //no
                                    else
                                    {
                                        //mp def status +20%
                                        currentDefMonsterPlayer +=
                                            Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100);
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} gains {Convert.ToInt32(Player.playerMonster[0].Defense * (double)35 / 100)} defense.");
                                        Console.WriteLine(
                                            $"{Player.playerMonster[0].NameMonster} have {currentDefMonsterPlayer} defense now.");
                                        continue;

                                    }
                                }
                            }


                            if (!isTypeCorract || playerOrder < 1 || playerOrder > 2)
                            {
                                Console.WriteLine("Please Enter number 1 or 2");
                                Console.ReadKey(true);
                            }
                        }

                    }
                    Console.Clear();
                    if (gym == 1)
                    {
                        Console.WriteLine("Gym leader 2 : Okay I lost.");
                        Console.WriteLine($"{username} : Do you know someone with a Red sun badge?");
                        Console.WriteLine("Gym leader 2 : Why? Did you have any problem?");
                        Console.WriteLine($"{username} : That guy stole my monster and I have to find him back.");
                        Console.WriteLine("Arghhh! why did he did this? His name is ... (Gym leader 10) But I'm sorry, I don't know where he lives. But I heard he went to city 3 a few days ago. Maybe you should start at that city..");
                        Console.WriteLine($"{username} : Thank you so much, see you.");
                        IsGym1notPass = false;
                        Console.ReadKey(true);
                        Town(2,username);
                    }
                    if (gym == 2)
                    {
                        Console.WriteLine("Gym leader 3 :  Not bad, what do you want to know?");
                        Console.WriteLine($"{username} : Have you ever seen (Gym leader 10) ? I heard that he was here.");
                        Console.WriteLine("Gym leader 3 : Why would I tell you that? You got any problem with him?");
                        Console.WriteLine($"{username} : He stole my monster and I have to bring him back. If you know anything about him, please tell me.");
                        Console.WriteLine("Gym leader 3 : I actually don't wanna tell where someone is or doing. But this I can't let it happen. He is at city 10, But. before you get to that city, You will have to get through these cities I marked in this map. and you have to train your monster, because in most of people are people of Gym leader 10 in those cities. If can't use words then use violence. I can't tell you anything more than this. Good luck");
                        Console.WriteLine($"{username} : Thanks a lot, See you.");
                        Console.WriteLine($"Game clear");
                        Console.ReadKey(true);
                        IsGym2notPass = false;
                        
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
                        "Catch those monsters!!\n",
                        "Travel and become strong together\n",
                        "Hmmmm..... ",
                        "Come and say you name  "
                    };
                    

                     Console.Clear();
                    Logo();
                    for (int i = 0; i < 6; i++)

                    {
                    ShowText(dialogueinto[i]);
                    Console.ReadKey(true);
                    }
                    
                    Console.Clear();
                    
                    string userName;
                    while (true)
                    {
                        Logo();
                        Console.WriteLine("How can i call your name");
                        userName = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(userName) )
                        {
                            
                            ShowText("please enter you're name");
                            Console.Clear();
                            continue;
                        }
                        Console.Clear();
                        break;
                    }
                    
                    string[] dialogueinto2 = new string[]
                    {
                        $"Ohhh {userName} ??",
                        "\nI\'ll remember that ",
                        "We've no have time Have a good luck  "
                    };
                    
                    Logo();
                    for (int i = 0; i < 3; i++)
                    {
                        ShowText(dialogueinto2[i]);
                        Console.ReadKey(true);

                    }


                    Console.Clear();

                    

                    while (true)
                    {
                        Console.Clear();
                        ImgMonster1();
                        ImgMonster2();
                        ImgMonster3();
                        Console.WriteLine();
                        Console.WriteLine("Chose your first monster");
                        Console.WriteLine("===========================");
                        Console.WriteLine("1.Teloth\n" +
                                          "2.Dorran\n" +
                                          "3.Delphifire\n");
                        Console.WriteLine("===========================");

                        bool isTypeCorract = int.TryParse(Console.ReadLine(), out int chosenmonster);
                        if (isTypeCorract && chosenmonster < 4 && chosenmonster > 0 )
                        {
                            switch (chosenmonster)
                            {
                                case 1:

                                    Player.playerMonster[0] = new Player(updateMonsterA.NameMonster,
                                        updateMonsterA.LevelMonster, 0,
                                        updateMonsterA.Hp, updateMonsterA.Attack,
                                        updateMonsterA.Defense, updateMonsterA.SpAttack,
                                        updateMonsterA.SpDefense, updateMonsterA.Speed, updateMonsterA.Index);
                                    break;


                                case 2:


                                    Player.playerMonster[0] = new Player(updateMonsterB.NameMonster,
                                        updateMonsterB.LevelMonster, 0,
                                        updateMonsterB.Hp, updateMonsterB.Attack,
                                        updateMonsterB.Defense, updateMonsterB.SpAttack,
                                        updateMonsterB.SpDefense, updateMonsterB.Speed, updateMonsterB.Index);
                                    break;

                                case 3:

                                    Player.playerMonster[0] = new Player(updateMonsterC.NameMonster,
                                        updateMonsterC.LevelMonster, 0,
                                        updateMonsterC.Hp, updateMonsterC.Attack,
                                        updateMonsterC.Defense, updateMonsterC.SpAttack,
                                        updateMonsterC.SpDefense, updateMonsterC.Speed, updateMonsterC.Index);
                                    break;

                            }

                            break;
                        }

                        if (!isTypeCorract || chosenmonster > 3 || chosenmonster < 1 )
                        {
                            Console.WriteLine("Please Enter number 1 2 or 3");
                            Console.ReadKey(true);
                        }

                    }

                    
                    Console.Clear();
                    Logo();
                    string[] openingstory =
                    {
                    "\n\n\nYou own a Legendary tier Monster .....\n",
                    "This made many people want your monster and dare you to fight with their monster and hope to take it.....\n",
                    $"One day {userName}'s monster has been stolen..... \n",
                    "You need to find your monster back!.....\n\n\n",


                    };
                    Console.Clear();
                    Logo();
                    for (int i = 0; i < 4; i++)
                    {

                    ShowText(openingstory[i]);
                    Console.ReadKey(true);
                    }

                    Console.WriteLine("||-------------------------------------------------||");
                    ShowText(
                    "On that day I was searchhing for monstes in the forest. Sunddenly a man appeared and talked to my monster." +
                    "\nSomethingthing hard as rock hit my head, Before I passed out I saw his badge.\n" +
                    "it's a red colored sun badge it'd a Gym leader badge! When I woke up my monster was gone\n" +
                    "I'll find that gym leader and bring my monster back!!\n");
                    Console.WriteLine("\n||-------------------------------------------------||");
                    Console.ReadKey(true);
                    Logo();
                    Console.Clear();
                    
                    Town(1,userName);
                    





                }
            
        
    }
}
    

    


    


