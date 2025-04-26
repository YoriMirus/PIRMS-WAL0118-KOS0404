using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIRMS.Communication
{
    internal class SerialCommunication
    {
        public static string[] GetAllAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }
    }
}
