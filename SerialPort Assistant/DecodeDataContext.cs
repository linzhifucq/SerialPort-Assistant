using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPort_Assistant
{
    public class DecodeDataContext
    {
        private DecodeData dd;
        public DecodeDataContext(DecodeData dd)
        {
            this.dd = dd;
        }

        //获取数据帧，可以传入不同的协议策略。
        public byte[] getDataFrame(Queue<byte> buffferQueue)
        {
            return dd.decodeDataFrame(buffferQueue);
        }
    }
}
