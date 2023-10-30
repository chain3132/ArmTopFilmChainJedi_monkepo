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

        static void imgmonster1()
        {
            string text = @"                                                                                       
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
            Console.WriteLine(text);

        }

        static void imgmonster2()
        {
            string text = @"                                                                                    
                                                                           
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
            Console.WriteLine(text);
        }

        static void imgmonster3()
        {
            string text = @"                                                                                                    
                            =*+.                              . -+*:                                
                           ==+*=+-    :+:....   .:+:         *=++**=+.                              
                    ..... .====#+  :+.+=%@@@@@%*+*: ::       .**+=*-=-                              
            :++---=++*****+-++..  +=  -++++++++*=.   =*         -+-==-=*=.                          
        .+=*#*+++++++++++*==     :*+.               -***.         .+-*++*#+-*=.                     
     :*#++++++++++++++++**+.   :#*--=#*=::...::=+#*=---==%=.       =--*++++++*+-*:                  
  .=#=:.    .-**+++++++++=:  =+-=------=------------------+#*.     -=-=*++++++++*+-*:               
                 :#++++*==: ==--#----+@@%------*=-----+----++*+    =--=*+++++++++++*==:             
                   ++++#==----+@@+---@@@@@=----@@+----=+----*=     =--=*+++++++++++++*++:           
                   =++****-=-*#.:%=-%@@@@@@--=@@@@+---+*=---=:=  :+=-=+*+++++++++++++++**+-         
                   =+#++++++*-+#-%%+@@@@%+@@*@@@@@%---%%=---=:+---+#+*#+*++++++++++++++++*+*.       
                  :+*++++++++++*=%%@@@@@@@#@@@@@@@@=-%@*-=+---#*+++++++++#+++++++++++++++++*+.      
                  .*+***-..  -=-***@@@@@%@#%@@@@@@@#%@#---=*+++++**+++++++**++++++++++++++++*=:     
                  =:         =---**@@@@+-*@*+#@@@@@@@#-----#-          :#*++#+++++*#:       +*+-    
               .::.+=*.  -=--%----=@@@----%@@@@*-%@@=-#=-+=-               :**++*.             *.   
               +==*=+-=.=--+. ------=+----+@@%---*=-=-----*.                 .*=                .   
               +=*++*-+=-+.    -=----------#=--------#+*--*.*+*.                                    
               :*=+=----:        .#-------------------*:+-#-=+== ..                                 
                    .=--:          =+---------------+. :=+--=+++-*==                                
                    :++#=          .#%@@%*=---+%@@+.   -==-+-*+-#=+-                                
                     +===          :-==@@@@@@%=++:     -=---+#:.+*.                                 
                                   +---=------+:       -=-=#+=                                      
                                  =---------*.         -=+==+:                                      
                                 .=-------+.            -+*:                                        
                                 ------+.                                                           
                                 .=--=-*:                                                           
                                   =-----==                                                         
                                     =------=                                               
                                       :+----=:                                                     
                                       .+--==                                                       
                                      :+==+.                                                        
                                     ====*.                                                         
                                      .+===                                                         
                                        ===-#.                                                      
                                          =-                                                        
                                                                                                    ";
            Console.WriteLine(text);
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
            public int RequirEXP { get; set; }
            public int Hp { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int Speed { get; set; }
            public int SpAttack { get; set; }
            public int SpDefense { get; set; }

            public Player(string namemonster, int levelmonster, int requirexp, int hp, int attack, int defense,
                int speed, int spattack, int spdefense)
            {
                NameMonster = namemonster;
                LevelMonster = levelmonster;
                RequirEXP = requirexp;
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
            public int LevelMonster { get; set; }
            public int Exp { get; set; }
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

            public Monster(string namemonster, int levelmonster, int exp, int hp, int attack, int defense, int spattack,
                int spdefense, int speed,
                int ivhp, int ivatk, int ivdef, int ivspAtk, int ivspDef, int ivspeed)
            {
                NameMonster = namemonster;
                LevelMonster = levelmonster;
                Exp = exp;
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

            public Monster(string namemonster, int levelmonster, int exp, int hp, int attack, int defense, int spattack,
                int spdefense, int speed)
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
            }

            //ตั้งค่าสเตตัสมอนสเตอร์

            public static Monster[] monster =
            {

                //standard monster
                new Monster("Teloth", 0, 75, 40, 50, 10, 5, 20, 25, 25, 30, 20, 15, 15, 20), //00
                new Monster("Dorran", 0, 70, 60, 10, 30, 10, 30, 10, 30, 10, 25, 10, 30, 20), //01
                new Monster("Delphifire", 0, 65, 40, 10, 30, 50, 10, 10, 20, 25, 10, 30, 20, 20), //02

                //monster forest1
                new Monster("Zephyrak", 0, 50, 30, 55, 20, 15, 10, 20, 20, 30, 10, 30, 20, 15), //03
                new Monster("Gravoloth", 0, 65, 30, 60, 20, 10, 20, 10, 25, 30, 10, 30, 10, 20), //04
                new Monster("Venomyth", 0, 75, 20, 10, 20, 60, 30, 10, 20, 20, 20, 30, 15, 20), //05
                new Monster("Doomfang", 0, 55, 60, 20, 30, 10, 20, 10, 35, 20, 30, 10, 20, 10), //06
                new Monster("Blazebane", 0, 75, 50, 40, 35, 10, 20, 5, 25, 30, 30, 10, 10, 20), //07
                new Monster("Frostbite", 0, 60, 30, 50, 20, 40, 10, 10, 20, 35, 20, 30, 10, 10), //08
                new Monster("Duskrage", 0, 70, 70, 20, 30, 40, 15, 5, 30, 10, 30, 35, 10, 10), //09
                new Monster("Scaledra", 0, 75, 70, 120, 30, 30, 30, 20, 20, 30, 15, 20, 10, 30), //10
                new Monster("Emberclaw", 0, 80, 120, 30, 60, 20, 60, 10, 30, 10, 30, 10, 30, 15), //11
                new Monster("Impolyos", 0, 85, 120, 200, 40, 30, 30, 10, 20, 30, 20, 20, 30, 30), //12

                //monster forest2
                new Monster("Abyssion", 0, 65, 50, 30, 20, 70, 10, 20, 30, 20, 10, 30, 5, 10), //13
                new Monster("Voidflam", 0, 70, 90, 20, 30, 10, 30, 20, 30, 20, 30, 10, 30, 5), //14
                new Monster("Vortexus", 0, 70, 50, 25, 20, 75, 20, 10, 10, 30, 30, 30, 30, 25), //15
                new Monster("Howlgrim", 0, 80, 50, 60, 30, 20, 10, 30, 30, 30, 20, 30, 30, 10), //16
                new Monster("Thundermaw", 0, 75, 110, 20, 30, 10, 30, 20, 20, 30, 30, 15, 30, 30), //17
                new Monster("Nightshade", 0, 70, 60, 35, 20, 80, 15, 10, 30, 30, 30, 30, 15, 15), //18
                new Monster("Scorchwing", 0, 65, 90, 10, 50, 50, 40, 10, 30, 20, 30, 30, 30, 15), //19
                new Monster("Dreadmire", 0, 85, 70, 120, 50, 30, 30, 50, 30, 30, 20, 30, 20, 25), //20
                new Monster("Raventhor", 0, 80, 80, 50, 40, 100, 40, 40, 30, 30, 30, 30, 20, 15), //21
                new Monster("Quantex", 0, 80, 170, 40, 100, 120, 70, 50, 30, 30, 30, 30, 30, 5), //22

                //monster forest3
                new Monster("Darknova", 0, 70, 70, 90, 20, 20, 20, 30, 31, 31, 31, 31, 31, 31), //23
                new Monster("Infernus", 0, 60, 120, 20, 50, 10, 30, 20, 31, 31, 31, 31, 31, 31), //24
                new Monster("Shadowclaw", 0, 55, 60, 45, 20, 90, 15, 10, 31, 31, 31, 31, 31, 31), //25
                new Monster("Stormscale", 0, 65, 70, 90, 30, 10, 20, 30, 31, 31, 31, 31, 31, 31), //26
                new Monster("Cyclonus", 0, 65, 90, 110, 30, 20, 20, 10, 31, 31, 31, 31, 31, 31), //27
                new Monster("Vipervenom", 0, 70, 75, 50, 20, 100, 15, 20, 31, 31, 31, 31, 31, 31), //28
                new Monster("Thundersoul", 0, 80, 70, 20, 40, 80, 50, 40, 31, 31, 31, 31, 31, 31), //29
                new Monster("Scaldrax", 0, 85, 150, 40, 70, 40, 60, 40, 31, 31, 31, 31, 31, 31), //30
                new Monster("Frostree", 0, 75, 120, 100, 40, 60, 20, 60, 31, 31, 31, 31, 31, 31), //31
                new Monster("Infynit", 0, 85, 200, 150, 80, 100, 60, 10, 31, 31, 31, 31, 31, 31), //33

            };

            public static Monster[] CloneMonsters()
            {
                Monster[] clonedMonsters = new Monster[monster.Length];

                for (int i = 0; i < monster.Length; i++)
                {
                    Monster originalMonster = monster[i];
                    clonedMonsters[i] = new Monster(originalMonster.NameMonster, originalMonster.LevelMonster,
                        originalMonster.Exp, originalMonster.Hp,
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
                    Convert.ToInt32((4 * clonedMonsters[intdex].Attack + clonedMonsters[intdex].IVatk) * level / 100 +
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

                clonedMonsters[intdex] = new Monster(clonedMonsters[intdex].NameMonster, level,
                    clonedMonsters[intdex].Exp, hpresult, atkresult, defresult,
                    spatkresult, spdefresult, speedresult);

                return clonedMonsters[intdex];
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

            public static Level[] levels =
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

        public static void test()
        {
        }

        // level = level ของมอนสเตอร์ที่ถูกโจมตี
        // attack = attackของมอนสเตอร์ที่โจมตี
        //defense = defenseพลังป้องกันของมอนสเตอร์ที่โจมตี
        //hpMonster = hpของมอนสเตอร์ที่ถูกโจมตี
        public static int CaculateDamage(int level, int attack, int defense, int hpMonster)
        {
            int damage =
                Convert.ToInt32(
                    2 * level / 5 * attack / defense / 50 + 2);
            int hpEqual = hpMonster - damage;
            return hpEqual;
        }

        //b = baseExp ของมอนสเตอร์ที่ถูกกำจัด
        //l = levelของมอนสเตอร์ที่ถูกกำจัด
        public static int CaculateExp(int b, int l)
        {
            int totalExp = Convert.ToInt32(b * l / 7 * 1.5);
            return totalExp;
        }

        public static void Town1()
        {
            ShowText("now I don't have any clue about that gym leader. \n" +
                     "This city may give me some information of that gym leader and this city maybe a great place to start");
        }

        public static void forest1()
        {
            Monster forestmonster = null;
            int currentHPMonsterForest;
            int currentHPMonsterPlayer;
            int passturn = 4;
            
            while (passturn > 0)
            {
                ShowText("you\'re going to the first forest ");
                ShowText("!!! \n your found a monster");
                Random random = new Random();
                int num = random.Next(1, 101);

                if (num <= 70)
                {
                    int rd = random.Next(1, 8);
                    switch (rd)
                    {
                        case 1:
                            forestmonster = Monster.CaculateStat(5, 3);
                            break;
                        case 2:
                            forestmonster = Monster.CaculateStat(5, 4);
                            break;
                        case 3:
                            forestmonster = Monster.CaculateStat(5, 5);
                            break;
                        case 4:
                            forestmonster = Monster.CaculateStat(5, 6);
                            break;
                        case 5:
                            forestmonster = Monster.CaculateStat(5, 7);
                            break;
                        case 6:
                            forestmonster = Monster.CaculateStat(5, 8);
                            break;
                        case 7:
                            forestmonster = Monster.CaculateStat(5, 9);
                            break;
                    }
                }
                else if (num <= 95)
                {
                    int rd = random.Next(0, 1);
                    switch (rd)
                    {
                        case 0:
                            forestmonster = Monster.CaculateStat(5, 10);
                            break;
                        case 1:
                            forestmonster = Monster.CaculateStat(5, 11);
                            break;
                    }
                }
                else
                {
                    forestmonster = Monster.CaculateStat(5, 12);
                }

                ShowText($"{forestmonster.NameMonster} appear!!\n");
                ShowText("Please choose your order");
                Console.WriteLine("1. Attack \n 2.Defense");
                int playerOrder = int.Parse(Console.ReadLine());
                if (playerOrder == 1)
                {
                    //mps > mfs?
                    //yes
                    if (Player.playerMonster[0].Speed > forestmonster.Speed)
                    {
                        //mp atk mf
                        currentHPMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                            Player.playerMonster[0].Attack, forestmonster.Defense, forestmonster.Hp);
                        //is mf die?
                        //yes 
                        if (currentHPMonsterForest <= 0)
                        {
                            //mp gain Exp
                            Player.playerMonster[0].RequirEXP +=
                                CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                            //if mp exp >= expTarget?
                            //yes
                            if (Player.playerMonster[0].RequirEXP >=
                                Level.levels[Player.playerMonster[0].LevelMonster + 1].ExpRequi)
                            {

                                Monster updateMonster =
                                    Monster.CaculateStat(Player.playerMonster[0].LevelMonster + 1, 0);
                                Player.playerMonster[0] = new Player(updateMonster.NameMonster,
                                    updateMonster.LevelMonster, 0, updateMonster.Hp, updateMonster.Attack,
                                    updateMonster.Defense, updateMonster.Speed, updateMonster.SpAttack,
                                    updateMonster.SpDefense);
                                passturn--;
                                
                            }

                            //if mp exp >= expTarget?
                            //no
                            else
                            {
                                passturn--;
                            }
                            
                            
                        }

                        //is mf die?
                        //no
                        else
                        {
                            //mf atk mp
                            currentHPMonsterPlayer = CaculateDamage(Player.playerMonster[0].LevelMonster,
                                forestmonster.Attack, Player.playerMonster[0].Defense, Player.playerMonster[0].Hp);
                            //is mp die?
                            //yes
                            if (currentHPMonsterPlayer <= 0)
                            {
                                Town1();
                            }

                            //is mp die?
                            //no
                            if (currentHPMonsterPlayer > 0)
                            {
                                continue;
                            }
                            //is mp die?
                            //yes


                        }

                    }

                    //mps > mfs?
                    //no
                    else
                    {
                        //mf atk mp
                        currentHPMonsterPlayer = CaculateDamage(Player.playerMonster[0].LevelMonster,
                            forestmonster.Attack, Player.playerMonster[0].Defense, Player.playerMonster[0].Hp);
                        //is mp die?
                        //yes
                        if (currentHPMonsterPlayer <= 0)
                        {

                        }
                        //is mp die?
                        //no
                        else
                        {
                            //mp atk mf
                            currentHPMonsterForest = CaculateDamage(forestmonster.LevelMonster,
                                Player.playerMonster[0].Attack, forestmonster.Defense, forestmonster.Hp);
                            //is mfs die?
                            //yes
                            if (currentHPMonsterForest <= 0)
                            {
                                //mp gain Exp
                                Player.playerMonster[0].RequirEXP +=
                                    CaculateExp(forestmonster.Exp, forestmonster.LevelMonster);
                                //if mp exp >= expTarget?
                                //yes
                                if (Player.playerMonster[0].RequirEXP >=
                                    Level.levels[Player.playerMonster[0].LevelMonster + 1].ExpRequi)
                                {

                                    Monster updateMonster =
                                        Monster.CaculateStat(Player.playerMonster[0].LevelMonster + 1, 0);
                                    Player.playerMonster[0] = new Player(updateMonster.NameMonster,
                                        updateMonster.LevelMonster, 0, updateMonster.Hp, updateMonster.Attack,
                                        updateMonster.Defense, updateMonster.Speed, updateMonster.SpAttack,
                                        updateMonster.SpDefense);
                                    passturn--;
                                
                                }

                                //if mp exp >= expTarget?
                                //no
                                else
                                {
                                    passturn--;
                                }
                            }
                        }

                    }


                }
                // playerOrder == 2
                else
                {
                    //mps > mfs?
                    //yes
                    if (Player.playerMonster[0].Speed > forestmonster.Speed)
                    {
                        //mp def status +20%
                        Player.playerMonster[0].Defense += 20 / 100;
                    }
                    
                   
                   


                }
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
                Console.Clear();
                
                imgmonster1();
                imgmonster2();
                imgmonster3();
                
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

                        Player.playerMonster[0] = new Player(updateMonsterA.NameMonster, updateMonsterA.LevelMonster, 0,
                            updateMonsterA.Hp, updateMonsterA.Attack,
                            updateMonsterA.Defense, updateMonsterA.Speed, updateMonsterA.SpAttack,
                            updateMonsterA.SpDefense);
                        break;


                    case 2:

                        Player.playerMonster[0] = new Player(updateMonsterB.NameMonster, updateMonsterB.LevelMonster, 0,
                            updateMonsterB.Hp, updateMonsterB.Attack,
                            updateMonsterB.Defense, updateMonsterB.Speed, updateMonsterB.SpAttack,
                            updateMonsterB.SpDefense);
                        break;

                    case 3:

                        Player.playerMonster[0] = new Player(updateMonsterC.NameMonster, updateMonsterC.LevelMonster, 0,
                            updateMonsterC.Hp, updateMonsterC.Attack,
                            updateMonsterC.Defense, updateMonsterC.Speed, updateMonsterC.SpAttack,
                            updateMonsterC.SpDefense);
                        break;

                }

                string[] openingstory = 
                {
                    "You own a Legendary tier Monster .....",
                    "This made many people want your monster and dare you to fight with their mnster and hope to take it.....",
                    $"One day {userName}'s monster has been stolen..... ",
                    "You need to find your monster back!.....",
                    
                    
                };
                for (int i = 0; i < 4; i++)
                {
                    ShowText(openingstory[i]);
                    Console.ReadKey(true);
                }
                Console.WriteLine("||-------------------------------------------------||");
                ShowText("On that day I was searchhing for monstes in the forest. Sunddenly a man appeared and talked to my monster." +
                         " \n Somethingthing hard as rock hit my head, Before I passed out I saw his badge.\n" +
                         " it's a red colored sun badge it'd a Gym leader badge! When I woke up my monster was gone\n"+
                         "I'll find that gym leader and bring my monster back!!");
                Console.WriteLine("||-------------------------------------------------||");
                
                



        }
        
        

    }
}
