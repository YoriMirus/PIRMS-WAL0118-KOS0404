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
        private Action<SerialCommunication, short[]> _onDataReceived;
        public string PortName { get => _port.PortName; }

        public SerialCommunication(string portName, Action<SerialCommunication, short[]> onDataReceived)
        {
            _port = new SerialPort(portName);
            _port.DataReceived += Port_DataReceived;
            _onDataReceived = onDataReceived;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Pro debug účely. Napíše text do konzole (viditelná pouze ve visual studiu)
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            // Převeď string na short[]
            string[] dataNumbers = indata.Split(';');
            short[] data = new short[dataNumbers.Length];
            for (int i = 0; i < dataNumbers.Length; i++)
            {
                if (!short.TryParse(dataNumbers[i], out data[i]))
                {
                    return;
                }
            }

            // Zavolej metodu, která má na tyto data reagovat
            _onDataReceived(this, data);
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
