using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPort_Assistant
{
    public class ModbusDecodeDataFrame : DecodeData
    {
        public override byte[] decodeDataFrame(Queue<byte> buffer)
        {
            //modbus实现...

            return null;
        }
    }
}
