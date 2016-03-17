using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRoboto
{
    public class ChefBot
        {
        int restaurant;
        String FoodMade;
        public String LineBreak = Environment.NewLine;
        public ChefBot()
        {                     

        }
        public void ChefBotLife(String RobotName, int RobotEnergy)
        {
            Console.WriteLine("It's cooking time " + RobotName + "." + LineBreak +
               "You must decide where you want to cook." + LineBreak +
               "1. A 5-Star Restaurant." + LineBreak +
               "2. A 4-Star." + LineBreak +
               "3. A 2 Star. " + LineBreak + 
               "Current Battery Level is: " + RobotEnergy + "%");
            restaurant = int.Parse(Console.ReadLine());

            if (restaurant == 1)
            {
                while (RobotEnergy > 0)
                {
                    Console.WriteLine("What kind of food would you like to make for your customers " + RobotName + "." + LineBreak +
                        "Please enter whatever kind of food you like.");
                    FoodMade = Console.ReadLine();

                    if (FoodMade.Length > 5 && FoodMade.Length < 10)
                    {
                        RobotEnergy -= 10;
                        Console.WriteLine(LineBreak + FoodMade + "! Great decision. " + LineBreak + "You used some battery to make the food, your current Battery Level is: " + RobotEnergy + LineBreak); 
                    }
                    else if (FoodMade.Length > 10)
                    {
                        RobotEnergy -= FoodMade.Length;
                        Console.WriteLine(LineBreak + FoodMade + "! Great decision. " + LineBreak + "You used some battery to make the food, your current Battery Level is: " + RobotEnergy + LineBreak); 
                    }
                    else {
                        RobotEnergy -= 5;
                        Console.WriteLine(LineBreak + FoodMade + "! Great decision. " + LineBreak + "You used some battery to make the food, your current Battery Level is: " + RobotEnergy + LineBreak);
                    }

                } Console.WriteLine("You're out of battery power. Donsomagunzo");
                Console.ReadLine();

            }else if (restaurant == 2)
            {
                while (RobotEnergy > 0)
                {
                    Console.WriteLine("Makes some food Makes some food.");
                }


            }
            else if (restaurant == 3)
            {
                while (RobotEnergy > 0)
                {
                    Console.WriteLine("Makes some food Makes some food.");
                }


            }

        }       
    }
}
