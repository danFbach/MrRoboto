using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRoboto
{
    public class SpyBot
    {
        int SpyChoice;

        public String LineBreak = Environment.NewLine;
        public SpyBot()
        {

        }
        public void SpyMission(String RobotName, int RobotEnergy)
        {
            int i;
            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine("Bot, " + LineBreak + " Bot. This is a pretty serious profession, I'm now going to take some time to explain to you, your mission." + LineBreak +
                    "In this mission you must locate papers proving illegal money transactions by a financial institution widely considered to be the dirtiest bank in the business." + LineBreak +
                   "You'll have to start by deciding what your first step will be." + LineBreak +
                   "1. Get a Job undercover at the bank." + LineBreak +
                   "2. Study the organization first and break in later." + LineBreak +
                   "3. Threaten a current employee with arrest in order to gain information." + LineBreak);
                SpyChoice = int.Parse(Console.ReadLine());
                if (SpyChoice == 1)
                {
                    RobotEnergy -= 20;
                    Console.WriteLine("Well " + RobotName + "your contact at the bank set you up");
                }
                if (SpyChoice == 2)
                {
                    RobotEnergy -= 15;
                    Console.WriteLine("");
                }
                if (SpyChoice == 3)
                {
                    RobotEnergy -= 10;
                    Console.WriteLine("");
                }                       
            }
        }
    }
}
