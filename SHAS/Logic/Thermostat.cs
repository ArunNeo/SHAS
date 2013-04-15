using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHAS.Logic
{
    public class Thermostat:TheromostatI
    {
        public int roomTemp { get; set; } 
        public int desiredTemp { get; set; }
        public int mode { get; set; }  
        public int  ClimateCondition { get; set; } 

        public Thermostat()
        {
            mode = 0;
            ClimateCondition = 1;
            roomTemp = 68;
        }

     

        public void Heater()
        {
            if (ClimateCondition == 0)//cold
                increaseRoomTemperature(3);
            if (ClimateCondition == 1)//warm
                increaseRoomTemperature(4);
            if(ClimateCondition == 2)//hot
                increaseRoomTemperature(6);
        
        }

        public void Cooler()
        {
            if (ClimateCondition == 0)//cold
                decreaseRoomTemperature(6);
            if (ClimateCondition == 1)//warm
                decreaseRoomTemperature(4);
            if (ClimateCondition == 2)//hot
                decreaseRoomTemperature(3);
        
        }
        public void increaseRoomTemperature(int temp)
        {
            
                 
              this.roomTemp  +=temp;
                

        }
        public void decreaseRoomTemperature(int temp)

        {

            this.roomTemp  -= temp;
        
        }

        
  


    }
}