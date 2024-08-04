using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPort_Assistant
{
    public partial class Form1 : Form
    {
        private bool isOpen = false;
        private bool isRxShow = true;
        private List<byte> receiveBuffer = new List<byte>();
        private List<byte> sendBuffer = new List<byte>();
        private int receiveCount = 0;
        private int sendCount = 0;
        private Queue<byte> buffQueue = null;
        private bool isHeadReceive = false;
        private int frameLength = 0;
        private bool frameCheckOk = false;
        public TransmitData transmitData;
        public event TransmitEventHandler transmitData2;
        public DecodeDataContext ddc;
        private string strRead;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            //打开端口
            try
            {
                if(serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = cob_port.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cob_baud.Text);
                    serialPort1.DataBits = Convert.ToInt32(cob_databit.Text);
                    switch (cob_check.SelectedIndex)
                    {
                        // 无校验   奇校验   偶校验
                        case 0:
                            serialPort1.Parity = Parity.None;
                            break;
                        case 1:
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case 2:
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            serialPort1.Parity = Parity.None;
                            break;
                    }

                    switch(cob_stopbit.SelectedIndex)
                    {
                        //1bit  1.5bit  2bit
                        case 0:
                            serialPort1.StopBits = StopBits.One; 
                            break;
                        case 1:
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case 2:
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            serialPort1.StopBits = StopBits.One;
                            break;
                    }
                    serialPort1.Open();
                    isOpen = true;
                    btn_open.Text = "关闭串口";
                    tssl_state.Text = $"关闭{serialPort1.PortName}串口成功！";
                }
                else
                {
                    serialPort1.Close();
                    isOpen = false;
                    btn_open.Text = "打开串口";
                    tssl_state.Text = $"打开{serialPort1.PortName}串口成功！";
                }
               
            }
            catch (Exception ex)
            {
                tssl_state.Text = $"打开{serialPort1.PortName}异常！";
                MessageBox.Show(ex.ToString() + serialPort1.PortName.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置默认的数据
            /* this.cob_port.SelectedIndex = 0;
             this.cob_baud.SelectedIndex = 1;
             this.cob_check.SelectedIndex = 0;
             this.cob_databit.SelectedIndex = 3;
             this.cob_stopbit.SelectedIndex = 0;*/
            serialLoad();
            //实例化队列
            buffQueue = new Queue<byte>();

            Form2 fr2 = new Form2();

            //接收数据委托窗体2 receivedata 执行显示
            //transmitdata += fr2.receivedata;
            //接收数据事件窗体2 receivedata 执行显示
            //transmitdata2 += new transmiteventhandler(fr2.receivedata2);
            //窗体2发送委托窗体1 sendbytes 执行发送 
            //fr2.useform1send += sendbytes;
            //窗体2发送事件窗体1 sendbytes2 执行发送
            //fr2.useform1send2 += new transmiteventhandler(sendbytes2);   
            //fr2.show();

            //ddc = new decodedatacontext(new simpledecodedataframe());

        }

        private void sendBytes2(object sender, TransmitEventAgrs e)
        {
            serialPort1.Write(e.data, 0, e.data.Length);
            sendCount += e.data.Length;
            tssl_sendcount.Text = sendCount.ToString();
        }

        private void sendBytes(byte[] data)
        {
            serialPort1.Write(data, 0, data.Length);
            sendCount += data.Length;
            tssl_sendcount.Text = sendCount.ToString();
        }

        private void serialLoad()
        {
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");

            string[] sSubKeys = keyCom.GetValueNames();
            cob_port.Items.Clear();
            foreach (var sValue in sSubKeys)
            {
                string portName =(string)keyCom.GetValue(sValue);
                cob_port.Items.Add(portName);
            }
            this.cob_port.SelectedIndex = 0;
            this.cob_baud.SelectedIndex = 1;
            this.cob_check.SelectedIndex = 0;
            this.cob_databit.SelectedIndex = 3;
            this.cob_stopbit.SelectedIndex = 0;
        }

        private void sendData()
        {
            serialPort1.Write(sendBuffer.ToArray(), 0, sendBuffer.Count);
            sendCount += sendBuffer.Count; 
            tssl_sendcount.Text = sendCount.ToString();
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            //如果发送的数据不为空且串口打开，则发送
            if(txt_send.Text != null && serialPort1.IsOpen) 
            {
                Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
                sendData();
            }
            else
            {
                MessageBox.Show("请先输入发送数据！");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (isRxShow == false) return;
            //读取有效的数据 BytesToRead
            byte[] dataTemp = new byte[serialPort1.BytesToRead];
            serialPort1.Read(dataTemp, 0, dataTemp.Length);

            receiveBuffer.AddRange(dataTemp);

            receiveCount += dataTemp.Length;

            //?.如果transmitData != null
            //transmitData?.Invoke(dataTemp);
            transmitData2?.Invoke(this, new TransmitEventAgrs { data = dataTemp});

            this.Invoke(new EventHandler(delegate
            {
                //显示接收数据的长度
                tssl_receivecount.Text = receiveCount.ToString();
                if (chb_startdata.Checked == false)
                {
                    if (!chb_receivehex.Checked)
                    {
                        //选择编码格式
                        string str = Encoding.GetEncoding("GB2312").GetString(dataTemp);
                        //0x00 -> \0 结束 不会显示
                        str = str.Replace("\0", "\\0");
                        txt_receive.AppendText(str);
                    }
                    else
                    {
                        //选中十六进制
                        txt_receive.AppendText(Transform.ToHexString(dataTemp));
                    }
                }
                else
                {
                    //解析数据
                    foreach (byte item in dataTemp)
                    {
                        //入列
                        buffQueue.Enqueue(item);
                    }

                    //获取帧数据
                    byte[] frameData = ddc.getDataFrame(buffQueue);
                    if(frameData != null)
                    {
                        Console.WriteLine($"show the data in frameData {Transform.ToHexString(frameData)}");
                        txt_data.Text = Transform.ToHexString(frameData);
                        txt_data1.Text = String.Format("{0:X2}", frameData[2]);
                        txt_data1.Text = String.Format("{0:X2}", frameData[3]);
                        txt_data1.Text = String.Format("{0:X2}", frameData[4]);
                        txt_data1.Text = String.Format("{0:X2}", frameData[5]);

                        for(int i = 0;i < frameData.Length; i++)
                        {
                            buffQueue.Dequeue();
                        }
                    }
#if old
                    //解析获取帧头
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
#endif
                }
            }));

           /* string dataReceive = serialPort1.ReadExisting();
            txt_receive.AppendText(dataReceive);*/
        }

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

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if(isRxShow == true)
            {
                isRxShow = false;
                btn_stop.Text = "取消暂停";
            }
            else
            {
                isRxShow = true;
                btn_stop.Text = "暂停";
            }
        }

        private void chb_receivehex_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_receive.Text == "") return;
            if (chb_receivehex.Checked)
            {
                txt_receive.Text = Transform.ToHexString(receiveBuffer.ToArray(), " ");
            }
            else
            {
                txt_receive.Text = Encoding.GetEncoding("GB2312").GetString(receiveBuffer.ToArray()).Replace("\0", "\\0");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            receiveBuffer.Clear();
            tssl_receivecount.Text = "";
            txt_receive.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(txt_receive.Text.Length > 4096)
            {
                receiveBuffer.Clear();
                receiveCount = 0;
                tssl_receivecount.Text = "0";
                tssl_receivecount.Text = "  ";
                txt_receive.Text = "";
            }
        }

        private void chb_autoclear_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_autoclear.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void txt_send_Leave(object sender, EventArgs e)
        {
            if(chb_sendhex.CheckState == CheckState.Checked)
            {
                if (DataEncoding.IsHexString(txt_send.Text.Replace("", "")))
                {
                    sendBuffer.Clear();
                    sendBuffer.AddRange(Transform.ToBytes(txt_send.Text.Replace("", "")));
                }
                else
                {
                    MessageBox.Show("请输入正确的十六进制数！");
                    txt_send.Select();
                }
            }
            else
            {
                sendBuffer.Clear();
                sendBuffer.AddRange(Encoding.GetEncoding("GB2312").GetBytes(txt_send.Text));
            }
        }

        private void txt_send_TextChanged(object sender, EventArgs e)
        {
            //十六进制切换的过程中会出现0x00转换的问题
        }

        private void chb_sendhex_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_send.Text == "") return;
            if (chb_sendhex.Checked == true) 
            { 
                txt_send.Text = Transform.ToHexString(sendBuffer.ToArray(), " ");
            }
            else
            {
                txt_send.Text = Encoding.GetEncoding("GB2312").GetString(sendBuffer.ToArray()).Replace("\0", "\\0");
            }
        }

        private void btn_clearsend_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            txt_send.Text = "";
            sendCount = 0;
            tssl_sendcount.Text = "0";
        }

        private void chb_autosend_CheckedChanged(object sender, EventArgs e)
        {
            //串口未打开
            if(serialPort1.IsOpen == false && chb_autoclear.CheckState == CheckState.Checked) 
            { 
                chb_autoclear.CheckState = CheckState.Unchecked;
                if(timer2 != null)
                {
                    timer2.Enabled = false;
                    timer2.Stop();
                    timer2 = null;
                }
                MessageBox.Show("发送失败，串口未打开！");
                return;
            }

            //串口打开
            if(serialPort1.IsOpen == true && chb_autoclear.CheckState == CheckState.Checked)
            {
                txt_autotimer.Enabled = false;
                btn_send.Enabled = false;
                int i = Convert.ToInt32(txt_autotimer.Text);
                //设置发送周期，启动定时器
                if(i < 10 || i > 60 * 1000)
                {
                    i = 1000;
                    chb_autoclear.Text = "1000";
                    MessageBox.Show("自动发送数据的周期是10-60000毫秒", "警告");
                }
                timer2.Interval = i;
                timer2.Start();
            }
            else
            {
                //关闭定时器
                btn_send.Enabled = true;
                txt_autotimer.Enabled = true;
                if(timer2 != null)
                {
                    timer2.Stop();
                    timer2 = null;
                }
            }
       }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //如果发送的数据不为空且串口打开，则发送
            if (txt_send.Text != null && serialPort1.IsOpen)
            {
                Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
                sendData();
            }
            else
            {
                tssl_state.Text = "请先输入发送数据！";
                Console.WriteLine("请先输入发送数据！"); 
            }
        }

        private void tssl_clearcount_Click(object sender, EventArgs e)
        {
            //清空发送
            sendBuffer.Clear();
            sendCount = 0;
            tssl_sendcount.Text = "0";

            //清空接收
            receiveBuffer.Clear();
            receiveCount = 0;
            tssl_receivecount.Text = "0";
        }

        private void chb_RTS_CheckedChanged(object sender, EventArgs e)
        {
            if(chb_RTS.CheckState == CheckState.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void chb_DTR_CheckedChanged(object sender, EventArgs e)
        {
            if(chb_DTR.CheckState == CheckState.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void btn_choosepath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            if(fbDialog.ShowDialog() == DialogResult.OK)
            {
                txt_receivefile.Text = fbDialog.SelectedPath;
            }
        }

        private void btn_savedata_Click(object sender, EventArgs e)
        {
            if (txt_receive.Text == "") return;

            string fileName = txt_receivefile.Text + "\\" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt"; 
            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(txt_receive.Text); 
            sw.Flush();
            sw.Close();
            MessageBox.Show("保存成功！");
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            //加载文本到发送窗
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Title = "请选择文件";
            ofDialog.Filter = "文本文件(*.txt)|*.txt";
            ofDialog.RestoreDirectory = true;
            if(ofDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofDialog.FileName;
                txt_sendfile.Text = fileName;
                StreamReader sr = new StreamReader(fileName,Encoding.GetEncoding("GB2312"));
                strRead = sr.ReadToEnd();
                txt_send.Text = strRead;
                sr.Close();
            }
        }

        private void btn_sendfile_Click(object sender, EventArgs e)
        {
            if(strRead == "")
            {
                MessageBox.Show("请先选择文件！");
                return;
            }
            try
            {
                byte[] data = Encoding.GetEncoding("GB2312").GetBytes(strRead);
                sendCount += data.Length;
                tssl_sendcount.Text= sendCount.ToString();
                int pagenum = data.Length / 4096;
                int  remaind = data.Length % 4096;
                for(int i = 0; i < pagenum; i++)
                {
                    serialPort1.Write(data, (i * 4096), 4096);
                    Thread.Sleep(10);
                }
                if(remaind > 0)
                {
                    serialPort1.Write(data, (pagenum * 4096), remaind);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("发送数据失败" +  ex.Message.ToString(), "错误");
            }
        }
    }
}
