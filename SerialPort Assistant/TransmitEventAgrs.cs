using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPort_Assistant
{
    public delegate void TransmitData(byte[] data);

    public delegate void TransmitEventHandler(object sender, TransmitEventAgrs e);
    public class TransmitEventAgrs:EventArgs
    {
       // SerialPort sp {  get; set; }
        public byte[] data { get; set; }
    }
}
