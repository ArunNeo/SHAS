using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAS.Logic
{
    interface TheromostatI
    {

       void increaseRoomTemperature(int temp);
       void decreaseRoomTemperature(int temp);
       void Heater();
       void Cooler();

    }
}
