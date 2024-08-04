using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPort_Assistant
{
    public abstract class DecodeData
    {
        public abstract byte[] decodeDataFrame(Queue<byte> buffer);
    }
}
