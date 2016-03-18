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
        int TwoStar;
        String FoodMade;
        public String FoodMadeL;
        public String LineBreak = Environment.NewLine;
        public ChefBot()                        
        {
        }
        public void ChefBotStory(String RobotName, int RobotEnergy)
        {
            Console.WriteLine("It's cooking time " + RobotName + "bot." + LineBreak +
               "You must decide where you want to cook." + LineBreak +
               "1. A 5-Star Restaurant." + LineBreak +
               "2. A 2-Star." + LineBreak +
               "Current Battery Level is: " + RobotEnergy + "%");
            restaurant = int.Parse(Console.ReadLine());

            if (restaurant == 1)                        //5-STAR RESTAURANT
            {
                Console.WriteLine("Great choice, you're going to be the head chef of a 5-Star restaurant." + LineBreak);
                while (RobotEnergy > 0)
                {
                    Console.WriteLine("What kind of food would you like to make for your customers " + RobotName + "." + LineBreak +
                        "Please enter whatever kind of food you like. Or Charge.");
                    FoodMade = Console.ReadLine();
                    FoodMadeL = FoodMade.ToLower();
                    if (FoodMadeL.Equals("charge"))
                    {
                        RobotEnergy += 15;
                        Console.WriteLine(LineBreak + "Your new battery level is " + RobotEnergy + "%" + LineBreak);
                    }                                          
                    else if (FoodMade.Length > 5 && FoodMade.Length < 10)
                    {
                        RobotEnergy -= 10;
                        Console.WriteLine(LineBreak + FoodMade + "! Great decision " + RobotName + "bot. " + LineBreak + "You used some battery to make the food, your current Battery Level is: " + RobotEnergy + LineBreak); 
                    }
                    else if (FoodMade.Length > 10)
                    {
                        RobotEnergy -= FoodMade.Length;
                        Console.WriteLine(LineBreak + FoodMade + "! Great decision " + RobotName + "bot. " + LineBreak + "You used some battery to make the food, your current Battery Level is: " + RobotEnergy + LineBreak); 
                    }
                    else
                    {
                        RobotEnergy -= 5;
                        Console.WriteLine(LineBreak + FoodMade + "! Great decision " + RobotName + "bot. " + LineBreak + "You used some battery to make the food, your current Battery Level is: " + RobotEnergy + LineBreak);
                    }

                } Console.WriteLine("You're out of battery power. Donsomagunzo");
                Console.ReadLine();

            }else if (restaurant == 2)                  //2-STAR RESTAURANT
            {
                Console.WriteLine("You have decided to work for a 2-Star restaurant. You don't really have that many options when it comes to what" + LineBreak +
                    "you're able to cook because this is a crappy 2-Star restaurant." + LineBreak);
                while (RobotEnergy > 0)
                {
                    Console.WriteLine("Pick from the basic food options." + LineBreak + "1. Cheeseburgers" + LineBreak + "2. Hot Dogs" + LineBreak + "3. Chicken Sammichs");
                    TwoStar = int.Parse(Console.ReadLine());
                    if (TwoStar == 1)
                    {
                        Console.WriteLine("Great choce " + RobotName + "bot. Even though the restaurant is crappy, you made a great cheeseburger." + LineBreak +
                            "You used some battery to make the food, your current Battery Level is: " + RobotEnergy + "%" + LineBreak);
                        RobotEnergy -= 10;      
                    }
                    else if (TwoStar == 2)
                    {
                        Console.WriteLine("Hot dogs!, Wow you're an amazing chef you should be extremely proud of yourself " + RobotName + "bot." + LineBreak +
                            "You used some battery to make the food, your current Battery Level is: " + RobotEnergy + "%" + LineBreak);
                        RobotEnergy -= 5;          
                    }
                    else if (TwoStar == 3)
                    {
                        Console.WriteLine("Some chicken sandwiches, not my first choice but I'm sure you make a good one " + RobotName + "bot." + LineBreak +
                            "You used some battery to make the food, your current Battery Level is: " + RobotEnergy + "%" + LineBreak);
                        RobotEnergy -= 15;      
                    }
                }
                Console.WriteLine("Battery dead.");
                Console.ReadLine();
            }
        }       
    }
}
