using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRoboto
{
    public class SpyBot
    {
        int SpyChoice1;
        int SpyChoice2_1;
        int SpyChoice2_2;
        int SpyChoice2_3;
        public String LineBreak = Environment.NewLine;
        
        public void SpyMission(String RobotName, int RobotEnergy)
        {
            int i;
            for (i = 0; i <= 5;)
            {
                Console.WriteLine("Bot, " + RobotName + " Bot. This is a pretty serious profession, I'm now going to take some time to explain to you, your mission." + LineBreak +
                    "In this mission you must locate papers proving illegal money transactions by a financial institution widely considered to be the dirtiest bank in the business." + LineBreak +
                   "You'll have to start by deciding what your first step will be." + LineBreak +
                   "1. Get a Job undercover at the bank." + LineBreak +
                   "2. Study the organization first and break in later." + LineBreak +
                   "3. Threaten a current employee in order to gain information." + LineBreak);
                SpyChoice1 = int.Parse(Console.ReadLine());
                if (SpyChoice1 == 1)
                {
                    RobotEnergy -= 20;
                    Console.WriteLine("Well " + RobotName + ", your contact at the bank, Mr.BeezleB set you up with a job at the bank. However this position still leaves your target too far out of reach..." + LineBreak +
                        "Will you..." + LineBreak +
                        "1. Quit the job and attempt another method of penetration?" + LineBreak +
                        "2. Spend the amount of time needed to reach your target?" + LineBreak +
                        "3. Charge into your targets' office and...interrogate the truth out of him!" + LineBreak);
                    SpyChoice2_1 = int.Parse(Console.ReadLine());
                }else if (SpyChoice1 == 2)
                {
                    RobotEnergy -= 15;
                    Console.WriteLine("After studying the organization you think you've figured out who is at the top of the corruption chain."+
                        " Is it the CEO, CFO, or Janitor. Please enter your choice.");
                    SpyChoice2_2 = int.Parse(Console.ReadLine());
                    

                }else if (SpyChoice1 == 3)
                {
                    RobotEnergy -= 10;
                    Console.WriteLine("Well, the threatening lead to arresting, and arresting led to...well, you put all of your super secret spy agent" + 
                        " skills to the test with some enhanced interrogation. Fearing for his life he gives up some imformation. Unfortunately, he also gave " +
                        "you up to your superior officer. You lose.");
                    SpyChoice2_3 = int.Parse(Console.ReadLine());

                    i += 1;
                }                       
            }
        }
    }
}
