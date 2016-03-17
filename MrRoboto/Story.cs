using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRoboto
{
    public class Story
    {

        public int RobotEnergy = 100;
        BotChoiceDirection userSelect = new BotChoiceDirection();
        public String LineBreak = Environment.NewLine;
        int BotChoice;
        public int beginning() {
            Console.WriteLine("Hello person, you've recently been in a car wreck and since your body was so brutally mangled" + LineBreak +
               "you will no longer be using it. So your conciousness will be imported into a robot. Luckily for you," + LineBreak + 
               "there is currently some choice in Robot kind. Most of the time there is only Battle bots and you have no chioce." + LineBreak +
               "I'll be right back, I need to check what we have available...." + LineBreak +
               "Well, we have 3 choices." + LineBreak + 
               "1. BattleBot" + LineBreak +
               "2. ChefBot" + LineBreak +
               "3. SpyBot" + LineBreak);
            RobotEnergy -= 5;
            BotChoice = int.Parse(Console.ReadLine());
            userSelect.ChoiceSwitch(BotChoice, RobotEnergy);
            return BotChoice;
        }

    }

}
