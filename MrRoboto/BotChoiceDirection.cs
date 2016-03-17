using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRoboto
{
    public class BotChoiceDirection
    {
        BattleBot1 bat1 = new BattleBot1();
        BattleBot2 bat2 = new BattleBot2();
        ChefBot cook = new ChefBot();
        SpyBot BotJamesBot = new SpyBot();             
        public String LineBreak = Environment.NewLine;
        public String RobotName;

        public void ChoiceSwitch(int BotChoice, int RobotEnergy) {
            switch (BotChoice) {
                case 1:
                    Console.WriteLine("choice 1");
                    break;
                case 2:
                    Console.WriteLine("You've picked a chef bot, that's exciting. It's time to give yourself a name." + LineBreak +
                        "Go ahead and enter whatever you like. ");
                    RobotName = Console.ReadLine();
                    RobotEnergy -= 5;
                    cook.ChefBotLife(RobotName, RobotEnergy);
                    break;
                case 3:
                    Console.WriteLine("You have chosen to become a SpyBot. What will your Spy Name be?" + LineBreak +
                    "Go ahead and enter whatever you like. ");
                    RobotName = Console.ReadLine();
                    RobotEnergy -= 5;
                    BotJamesBot.SpyMission(RobotName, RobotEnergy);  
                    break;
            }
        }
    }
}
