using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHAS.Logic
{
    public class ThermostatController
    {

        private Thermostat thermostat = new Thermostat();
        private ShasController shasController = new ShasController();

        public void ThermostateRun()
        {
            if (shasController.SHAS_Status)
            {

                if (thermostat.desiredTemp > thermostat.roomTemp)
                    thermostat.Heater();
                if (thermostat.desiredTemp < thermostat.roomTemp)
                    thermostat.Cooler();
            
            }

            
       
        }
     
       

    }
}