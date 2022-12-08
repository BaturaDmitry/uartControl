using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ProjectUARTControl
{
    public class SerialPortManager
    {

        private const int BAUD_RATE = 9600;
        private const int DATA_BITS = 8;
        private const int PARITY_BITS = 0;
        private const int STOP_BITS = 1;

        private RichTextBox displayWindow;
        private SerialPort serialPort;
        

        public SerialPortManager(RichTextBox rtb, Label lbl)
        {
            serialPort = new SerialPort();
            displayWindow = rtb;
        }

        public IList<string> GetAvailablePorts()
        {
            IList<string> ports = new List<string>();
            foreach (string str in SerialPort.GetPortNames())
            {
                ports.Add(str);
            }
            return ports;
        }

        public bool Connected()
        {
            return serialPort.IsOpen;
        }

        public bool OpenConnection(string comPortName)
        {
            try
            {
                if (serialPort.IsOpen) serialPort.Close();
 
                serialPort.PortName = comPortName;
                serialPort.BaudRate = BAUD_RATE;
                serialPort.DataBits = DATA_BITS;
                serialPort.Parity = PARITY_BITS;
                serialPort.StopBits = (StopBits)STOP_BITS;

                serialPort.DataReceived += TemperatureDataReceivedHandler;

                serialPort.Open();

                DisplayData("Порт открыт " + DateTime.Now + "\n");
                return true;
            }
            catch (Exception ex)
            {
                DisplayData(ex.Message + "\n");
                return false;
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void CloseConnection()
        {
            if (serialPort.IsOpen) serialPort.Close();
            serialPort.DataReceived -= TemperatureDataReceivedHandler;
            DisplayData("Порт закрыт " + DateTime.Now + "\n");
        }
        

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void Send(byte data)
        {
            byte[] writeData = new byte[1];
            writeData[0] = data;
            serialPort.Write(writeData, 0, 1);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void DisplayData(string msg)
        {
            displayWindow.Invoke(new EventHandler(delegate
            {
                displayWindow.SelectedText = string.Empty;
                displayWindow.SelectionFont = new Font(displayWindow.SelectionFont, FontStyle.Bold);
                displayWindow.AppendText(msg);
                displayWindow.ScrollToCaret();
            }));
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void TemperatureDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (sender != null)
            {
                SerialPort sp = (SerialPort)sender;
                
           
                while (sp.BytesToRead < 2) { }
                
                byte[] buffer = new byte[2];
                sp.Read(buffer, 0, 2);
                string hex = BitConverter.ToString(buffer);
                hex = hex.Replace("-", "");
                int value = Convert.ToInt32(hex, 16);
                double cels = value/8.0f * 0.0625f;

                DisplayData( DateTime.Now + " -- " + Math.Round(cels, 2) + "°С \n");
                Send(byte.Parse(((int)Math.Round(cels)).ToString(), System.Globalization.NumberStyles.HexNumber));

            }
            else
            {
                DisplayData("Ошибка.Невозможно получить данные!");
            }
        }

    }
}
