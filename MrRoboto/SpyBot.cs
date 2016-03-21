using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRoboto
{
    public class SpyBot
    {
        int SpyChoice0 = 0;
        int SpyChoice1_0;
        int SpyChoice1_1;
        String SpyChoice2_2;
        int SpyChoice2_3;
        public String LineBreak = Environment.NewLine;
        
        public void SpyMission(String RobotName, int RobotEnergy)
        {
            Console.WriteLine("Bot, " + RobotName + " Bot. This is a pretty serious profession, I'm now going to take some time to explain to you, your mission." + LineBreak +
            "In this mission you must locate papers proving illegal money transactions by a financial institution widely considered to be the dirtiest bank in the business." + LineBreak +
           "You'll have to start by deciding what your first step will be.");
            int i;
            for (i = 5; i >= 0;)
            {
                
                if (SpyChoice0 == 0)
                {
                    Console.WriteLine(LineBreak + "1. Hack into the bank and make yourself an employee, being working a false job." + LineBreak +
                 "2. Plug your Robot brain into the WiFi and research the business to the best of your Robility." + LineBreak +
                 "3. Threaten a current employee in order to gain information." + LineBreak);
                    SpyChoice0 = int.Parse(Console.ReadLine());
                }
                else if (SpyChoice0 == 1)
                {
                    RobotEnergy -= 20;
                    Console.WriteLine(LineBreak + "Well " + RobotName + ", your hack was perfect and worked without a problem." + LineBreak +
                        "Next, will you..." + LineBreak +
                        "1. Quit the job and attempt another method of penetration?" + LineBreak +
                        "2. Spend the amount of time needed to reach your target?" + LineBreak +
                        "3. Charge into your targets' office and...interrogate the truth out of him!" + LineBreak);
                    SpyChoice1_0 = int.Parse(Console.ReadLine());
                    if (SpyChoice1_0 == 1)
                    {
                        i -= 1;
                        Console.WriteLine(LineBreak + "You have " + i + " chances left to take down the bank." + LineBreak);
                        SpyChoice0 = 0;
                    } else if (SpyChoice1_0 == 2)
                    {
                        Console.WriteLine(LineBreak + "After a few days of working in the bank an investigation is launched against you and you are fired..." + LineBreak);
                        i -= 1;
                        Console.WriteLine(LineBreak + "You have " + i + " chances left to take down the bank." + LineBreak);
                        SpyChoice0 = 0;
                    } else if (SpyChoice1_0 == 3)
                    {
                        Console.WriteLine(LineBreak + "You kick some serious *** with your robot body and retrieve the information that you're looking for." + 
                        "You now that have administrative passwords needed to gain entry to the banks financial Databases." + LineBreak +
                        "");
                        SpyChoice1_1 = int.Parse(Console.ReadLine());

                    }
                }else if (SpyChoice0 == 2)
                {
                    RobotEnergy -= 15;
                    Console.WriteLine("After studying the organization you think you've figured out who is at the top of the corruption chain."+
                        " Is it the CEO, CFO, or Janitor. Please enter your choice.");
                    SpyChoice2_2 = Console.ReadLine();
                    

                }else if (SpyChoice0 == 3)
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
