using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRoboto
{
    public class BattleBot2
    {
        public int AIEnergy = 100;
        public int LaserPower;
        public int AIcharge;
        public int RobotEnergy;
        public bool play = true;
        public String RePlay;
        public String lazurrr;
        public String LineBreak = Environment.NewLine;
        public String BotAction;

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

                if (RobotEnergy > 100)
                {
                    RobotEnergy = 100;
                    Console.WriteLine("Your bot is already fully charged at 100%");
                }

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


                if (RobotEnergy < 1) { Console.WriteLine("You have lost the bot battle."); play = false; }
                else if (AIEnergy < 1) { Console.WriteLine("You have beaten the enemy robot."); play = false; }
            }replay(RobotName, lazurrr);
        }



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
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("You have now defeated " + i + " bot(s), you have " + (25 - i) + " robots remaining.");
                AIEnergy = 100;
                while (AIEnergy >= 1 && RobotEnergy >= 1)
                {


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



                }

            } Console.WriteLine("You have defeated all enemy robots.");
        }
        public void replay(String RobotName, String lazurrr)
        {
            Console.WriteLine("Would you like to have another battle? (Y/N)");
            RePlay = Console.ReadLine();
            RePlay = RePlay.ToLower();
            if (RePlay.Equals("y"))
            {
                RobotEnergy = 100;
                AIEnergy = 100;
                play = true;
                Console.WriteLine("1. 1v1 2. Military");
                int replayType = int.Parse(Console.ReadLine());
                if (replayType.Equals(1))
                {
                    Battle1v1(RobotName, RobotEnergy, lazurrr);
                }
                else if (replayType.Equals(2))
                {
                    botFleet(RobotEnergy, lazurrr);
                }
                            
            }
        
            else if (RePlay.Equals("n"))
            {
                Console.WriteLine("Thanks for playing, Game Over.");
                Console.ReadLine();
            }
        }
    }
}
