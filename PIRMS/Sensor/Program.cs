using System.IO.Ports;
using NAudio.Wave;

namespace Sensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PIRMS - Čítač mikrofonu");
            int portNum = -1;
            while (portNum < 1)
            {
                string ports = string.Join(", ", SerialPort.GetPortNames());
                if (string.IsNullOrEmpty(ports))
                    ports = "Žádné";

                Console.WriteLine("Dostupné porty: " + ports);
                Console.Write("Zadej číslo portu: ");
                string? input = Console.ReadLine();
                _ = int.TryParse(input, out portNum);
            }

            int baudRate = -1;
            while (baudRate < 1)
            {
                Console.Write("Baud rate: ");
                string? input = Console.ReadLine();
                _ = int.TryParse(input, out baudRate);
            }

            Console.WriteLine("Otevírám port...");

            var waveIn = new WaveInEvent
            {
                DeviceNumber = 0, // indicates which microphone to use
                WaveFormat = new WaveFormat(rate: 44100, bits: 16, channels: 1),
                BufferMilliseconds = 20
            };
            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.StartRecording();

            port = new SerialPort()
            {
                BaudRate = baudRate,
                PortName = $"COM{portNum}"
            };
            port.Open();

            Console.WriteLine("Nahrávání začnulo.");
            Console.WriteLine("Zmáčkněte enter pro vypnutí programu.");
            Console.ReadLine();

            port.Close();
        }

        public static int sampleNum;
        public static SerialPort port = new SerialPort();

        static void WaveIn_DataAvailable(object? sender, WaveInEventArgs e)
        {
            sampleNum++;
            // copy buffer into an array of integers
            Int16[] values = new Int16[e.Buffer.Length / 2];
            Buffer.BlockCopy(e.Buffer, 0, values, 0, e.Buffer.Length);

            // determine the highest value as a fraction of the maximum possible value
            float fraction = (float)values.Max() / 32768;

            // print a level meter using the console
            string bar = new('#', (int)(fraction * 70));
            string meter = "[" + bar.PadRight(60, '-') + "]";
            Console.CursorLeft = 0;
            Console.CursorVisible = false;
            Console.Write($"{meter} {fraction * 100:00.0}% ({sampleNum})");

            port.Write(string.Join(';', values));
        }
    }
}
