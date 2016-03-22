using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRoboto
{
    public class BotChoiceDirection
    {
        lazur pickLaser = new lazur();   
        ChefBot cook = new ChefBot();
        SpyBot BotJamesBot = new SpyBot();              
        public String RobotName;
        public String LineBreak = Environment.NewLine;

        public void ChoiceSwitch(int BotChoice, int RobotEnergy) {
            switch (BotChoice) {
                case 1:
                    Console.WriteLine("Battle Bot it is. Most people would choose not to be a battle bot if given the choice but there are still many people" +
                        "who CHOOSE to live the rest of their concious lives as a battle bot. Your name is now Connor, Pvt. Mitch Connor.");
                    RobotName = "Connor, Pvt. Mitch Connor";
                    RobotEnergy = 100;
                    pickLaser.LazurrrType(RobotName, RobotEnergy);
                    
                    break;
                case 2:
                    Console.WriteLine("You've picked a chef bot, that's exciting. It's time to give yourself a name." + LineBreak +
                        "Go ahead and enter whatever you like. ");
                    RobotName = Console.ReadLine();
                    RobotEnergy -= 15;
                    cook.ChefBotStory(RobotName, RobotEnergy);
                    break;
                case 3:
                    Console.WriteLine("You have chosen to become a SpyBot. What will your Spy Name be?" + LineBreak +
                    "Go ahead and enter whatever you like. ");
                    RobotName = Console.ReadLine();
                    RobotEnergy -= 15;
                    BotJamesBot.SpyMission(RobotName, RobotEnergy);  
                    break;
            }
        }
    }
}
