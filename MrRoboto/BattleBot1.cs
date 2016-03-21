using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRoboto
{
    public class BattleBot1
    {
        public String BotAction;
        public String RePlay;
        public String LineBreak = Environment.NewLine;
        public int AIEnergy = 100;
        public int AIcharge;
        public int LaserPower;
        public int RobotEnergy;
        public bool play = true;
        //1v1
        public void Battle1v1(String RobotName, int RobotEnergy, String lazurrr)
        {
            if (lazurrr.Equals("green"))
            {
                LaserPower = 20;
                AIcharge = 15;
            }
            else if (lazurrr.Equals("red"))
            {
                LaserPower = 15;
                AIcharge = 10;
            }
            Console.WriteLine(LineBreak + "The battle is about to begin, you currently have " + RobotEnergy + "% energy, and the enemy is at 100%");
            while (play == true)
            { 
                
                if (RobotEnergy < 1) { Console.WriteLine("You have lost the bot battle."); replay(); play = false; }
                else if (AIEnergy < 1) { Console.WriteLine("You have beaten the enemy robot."); replay(); play = false; }

                if (RobotEnergy > 100) { RobotEnergy = 100; Console.WriteLine("Your bot is already fully charged at 100%"); }

                Console.WriteLine(LineBreak + "Now will you fire back or recharge?" + LineBreak + "Please type fire or charge." + LineBreak);
                BotAction = Console.ReadLine();
                BotAction = BotAction.ToLower();
                if (BotAction.Equals("fire"))
                {
                    AIEnergy -= LaserPower;
                    Console.WriteLine("After firing, the enemy bot now has " + AIEnergy + "% energy remaining;");
                }
                else if (BotAction.Equals("charge"))
                {
                    RobotEnergy += 20;
                    Console.WriteLine("You are charging and now have " + RobotEnergy + "% remaining energy.");
                }

                if (AIEnergy > 50)
                {
                    RobotEnergy -= 15;
                    Console.WriteLine("The enemy bot has returned fire and you now have " + RobotEnergy + "% energy.");
                }
                else if (AIEnergy < 50)
                {
                    AIEnergy += AIcharge;
                    Console.WriteLine("The enemy robot is going to charge and has " + AIEnergy + "% remaining energy.");
                }
            }
           
        }  public void replay()
        {
            Console.WriteLine("Would you like to have another battle? Yes or No.");
            RePlay = Console.ReadLine();
            RePlay = RePlay.ToLower();
            if (RePlay.Equals("yes")) { RobotEnergy = 100; AIEnergy = 100; play = true; }
            else if (RePlay.Equals("no")) { Console.WriteLine("Thanks for playing, Game Over."); Console.ReadLine(); }
        }
    }
}
