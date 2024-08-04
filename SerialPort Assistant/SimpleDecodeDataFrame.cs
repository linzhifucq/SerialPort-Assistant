using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPort_Assistant
{
    public class SimpleDecodeDataFrame:DecodeData
    {
        private bool isHeadReceive = false;
        private byte frameLength;
        private bool frameCheckOk = false;

        private bool crc_check(byte[] frameBuffer)
        {
            /*大端模式: 是指数据的高字节保存在内存的低地址中，
             * 而数据的低字节保存在内存的高地址中，这样的存储
             * 模式有点儿类似于把数据当作字符串顺序处理：地址
             * 由小向大增加，而数据从高位往低位放；这和我们的
             * 阅读习惯一致。
             * 
             * 小端模式: 是指数据的高字节保存在内存的高地址中，
             * 而数据的低字节保存在内存的低地址中，这种存储模
             * 式将地址的高低和数据位权有效地结合起来，高地址
             * 部分权值高，低地址部分权值低。*/

            bool ret = false;
            byte[] temp = new byte[frameLength - 2];
            Array.Copy(frameBuffer, 0, temp, 0, temp.Length);
            byte[] crcdata = DataCheck.DataCrc16_Ccitt(temp, DataCheck.BigOrLittle.BigEndian);
            if (crcdata[0] == frameBuffer[frameBuffer.Length - 2] &&
                crcdata[1] == frameBuffer[frameBuffer.Length - 1])
            {
                //check ok
                ret = true;
            }
            return ret;

        }
        public override byte[] decodeDataFrame(Queue<byte> bufferQueue)
        {
            //具体实现算法解析数据，并返回帧或空
            if (isHeadReceive == false)
            {
                foreach (byte item in bufferQueue.ToArray())
                {
                    if (item != 0x7f)
                    {
                        //出列
                        bufferQueue.Dequeue();
                        Console.WriteLine("not 0x7f Dequeue!");
                    }
                    else
                    {
                        isHeadReceive = true;
                        Console.WriteLine("0x7f is received!");
                        break;
                    }
                }
            }

            if (isHeadReceive == true)
            {
                //判断有数据帧的长度
                if (bufferQueue.Count >= 2)
                {
                    Console.WriteLine(DateTime.Now.ToLongTimeString());
                    Console.WriteLine($"show the data in bufferQueue {Transform.ToHexString(bufferQueue.ToArray())}");
                    Console.WriteLine($"frame length = {String.Format("{0:X2}", bufferQueue.ToArray()[1])}");
                    frameLength = bufferQueue.ToArray()[1];
                    //一帧完整的数据长度判断，数据不一定正确
                    if (bufferQueue.Count >= 1 + 1 + frameLength + 2)
                    {
                        byte[] frameBuffer = new byte[1 + 1 + frameLength + 2];
                        Array.Copy(bufferQueue.ToArray(), 0, frameBuffer, 0, frameBuffer.Length);
                        if (crc_check(frameBuffer))
                        {
                            Console.WriteLine("frame is check ok, pick it");
                            frameCheckOk = true;
                        }
                        else
                        {
                            //无效数据帧
                            Console.WriteLine("bad frame, drop it");
                            for (int i = 0; i < 1 + 1 + frameLength + 2; i++)
                            {
                                bufferQueue.Dequeue();
                            }
                           
                        }

                        if (frameCheckOk)
                        {
                            frameCheckOk = false;
                            return frameBuffer;
                        }

                    }
                }
            }
                return null;
        }
    }
}
