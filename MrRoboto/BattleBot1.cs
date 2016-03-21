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
        public String LineBreak = Environment.NewLine;
        public int AIEnergy = 100;
        public int LaserPower;
        public int RobotEnergy;
        //1v1
        public void Battle1v1(String RobotName, int RobotEnergy, String lazurrr)
        {  
            if (lazurrr.Equals("green"))
            {
                LaserPower = 20;
            }
            else if (lazurrr.Equals("red"))
            {
                LaserPower = 15;
            }
            Console.WriteLine(LineBreak + "The battle is about to begin, you currently have " + RobotEnergy + "% energy, and the enemy is at 100%");
            while (RobotEnergy > 0 && AIEnergy > 0)
            {
                //while (RobotEnergy > 0)
                //{
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
               // }
                //while (AIEnergy > 0)
                //{
                    if (AIEnergy > 50)
                    {
                        RobotEnergy -= 15;
                        Console.WriteLine("The enemy bot has returned fire and you now have " + RobotEnergy + "% energy.");
                    }
                    else if (AIEnergy < 50)
                    {
                        AIEnergy += 15;
                        Console.WriteLine("The enemy robot is going to charge and has " + AIEnergy + "% remaining energy.");
                    }
               // }
            }
                //UserBot(RobotEnergy, AIEnergy);
                //AIBOT(RobotEnergy, AIEnergy);           
        }




        public void UserBot(int RobotEnergy, int AIEnergy)
        {
           


        }
        public void AIBOT(int RobotEnergy, int AIEnergy)
        {
           
        }
    }
}
