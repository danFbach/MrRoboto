using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MrRoboto
{
    public class Robot : BotChoiceDirection
    {
        BattleBot1 battle1 = new BattleBot1();
        BattleBot2 battle2 = new BattleBot2();
                                
        public String lazurrr;
        public int battleChoice;                       
        public int RobotDamage;                       
        public int BattleBot1Life;
        public int BattleBot2Life;
        public int RedLaser = 100;
        public int GreenLaser = 100;

        public void LazurrrType(String RobotName, int RobotEnergy)
        {
            Console.WriteLine("Now you must pick a red or green laser. Red lasers are more powerful but greens fire more rapidly. Make a choice, green or red. Also, be aware that if you pick the green lazur you must sacrifice 20% of your battery life.");
            lazurrr = Console.ReadLine();
            BattleType(RobotName, RobotEnergy);
        }
        public void BattleType(String RobotName, int RobotEnergy)
        {
            if (lazurrr.Equals("green"))
            {
                RobotEnergy -= 20;
                Console.WriteLine("Great " + RobotName + ", you've picked the Green laser, my personal favorite. Now you just have to pick what type of battlebot you'd like to be..." +
                    LineBreak + "1. 1v1 2. Military");
                battleChoice = int.Parse(Console.ReadLine());
                if (battleChoice == 1) { battle1.Battle1v1(RobotName, RobotEnergy); }
                else if (battleChoice == 2) { battle2.Military(RobotName, RobotEnergy); }
            }
            else if (lazurrr.Equals("Great " + RobotName + ", you've picked the red laser, not my personal favorite but who cares what I think, I'm just a computer. Anyways, now just pick what type of battle bot" +
                "you'd like to be." + LineBreak + "1. 1v1 2. Military"))
                battleChoice = int.Parse(Console.ReadLine());
            if (battleChoice == 1) { battle1.Battle1v1(RobotName, RobotEnergy); }
            else if (battleChoice == 2) { battle2.Military(RobotName, RobotEnergy); }
            {

            }
        }
    }                             
}

