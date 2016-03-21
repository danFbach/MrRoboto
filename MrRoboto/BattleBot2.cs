using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRoboto
{
    public class BattleBot2
    {           
        public int AILife = 100;
        public int AIEnergy = 100;
        public int LaserPower;
        int RobotEnergy;
        public String lazurrr;
        public String LineBreak = Environment.NewLine;
        public String BotAction;
        //Military             


        public void Military(String RobotName, int RobotEnergy, string lazurrr)
        {
            if (lazurrr.Equals("green"))
            {
                LaserPower = 20;
            }
            else if (lazurrr.Equals("red"))
            {
                LaserPower = 35;
            }
            botFleet(RobotEnergy, lazurrr);
        }
        public void botFleet(int RobotEnergy, string lazurrr)
        {
            for (int i = 0; i < 25;i++)
            {
                while (AILife > 0 && RobotEnergy > 0) {


                    if (RobotEnergy > 100) { RobotEnergy = 100; Console.WriteLine("Your bot is already fully charged at 100%"); }

                    Console.WriteLine(LineBreak + "Will you fire back or recharge?" + LineBreak + "Please type fire or charge." + LineBreak);
                    BotAction = Console.ReadLine();
                    BotAction = BotAction.ToLower();
                    if (BotAction.Equals("fire"))
                    {
                        if (lazurrr.Equals("green"))
                        {
                            AIEnergy -= LaserPower;
                            Console.WriteLine("With your first hit you've reduced the enemy to " + AIEnergy + "%");
                            AIEnergy -= LaserPower;
                            Console.WriteLine("Your second hit took it down to " + AIEnergy + "%");
                        }
                        else if (lazurrr.Equals("red"))
                        {
                            AIEnergy -= LaserPower;
                            Console.WriteLine("With your first hit you've reduced the enemy to " + AIEnergy + "%");
                        }                                                                                                                                                                                                                    
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
                        AIEnergy += 20;
                        Console.WriteLine("The enemy robot is going to charge and has " + AIEnergy + "% remaining energy.");
                    }



                } Console.WriteLine("You have now defeated " + i + " bots, you have " + (25-i) + " robots remaining." );

            }
        }
    }
}
