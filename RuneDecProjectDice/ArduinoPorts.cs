using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace RuneDecProjectDice
{
    internal class ArduinoPort
    {
        private SerialPort port;
        public ArduinoPort(String portNumber, int baudRate)
        {
            if (port == null)
            {
                port = new SerialPort(portNumber, baudRate); //Set your board COM
                port.Open();
            }
        }
        public void WriteToPort(String text)
        {
            if (port != null && port.IsOpen)
            {
                port.Write(text);
            }
        }
        public void ClosePort()
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }
    }
}
