using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
namespace IP2
{
    class ConnectionToBicycle
    {
        BicycleCommunication bicycle;

        public ConnectionToBicycle()
        {
            bicycle = new BicycleCommunication();
            bicycle.initComm("COM5");
            bicycle.sendData("ST");
        }

    }
}
