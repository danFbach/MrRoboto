using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MrRoboto
{                        
    public class Robot
        {
            public String RobotName;
            public int RobotDamage;
            public int RobotEnergy;
            public int BattleBot1Life;
            public int BattleBot2Life;

        public void BattleType(String RobotName,int RobotEnergy)
        {
            Console.WriteLine(RobotName + " " + RobotEnergy);
            Console.ReadLine();

        }




                                            
    }
}
