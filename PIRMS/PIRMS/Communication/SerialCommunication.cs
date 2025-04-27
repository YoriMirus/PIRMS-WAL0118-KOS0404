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
        private SerialPort _port;

        public static string[] GetAllAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        public SerialCommunication(string portName)
        {
            // Zkontrolujme, že nezadáváme blbosti
            // Můžeme kdyžtak potom chytnout později a ukázat uživateli messagebox
            string[] strings = SerialPort.GetPortNames();
            if (strings.Contains(portName) == false)
            {
                throw new ArgumentException("Zadaný port neexistuje v seznamů dostupných portů.");
            }

            _port = new SerialPort(portName);
            _port.DataReceived += _port_DataReceived;
        }

        private void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Pro debug účely. Napíše text do konzole (viditelná pouze ve visual studiu)
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine($"Data Received ({sp.PortName}): {indata}");
        }

        public void Open()
        {
            if(!_port.IsOpen)
                _port.Open();
        }

        public void Close()
        {
            if (_port.IsOpen)
                _port.Close();
        }

        // Doporučuje se port zavřít, když ho už nepotřebujeme.
        // Garbage collector tohle za nás pravděpodobně neudělá
        ~SerialCommunication()
        {
            if (_port.IsOpen)
                _port.Close();
            _port.Dispose();
        }
    }
}
