using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPort_Assistant
{
    public partial class Form2 : Form
    {
        public TransmitData useForm1Send;
        public event TransmitEventHandler useForm1Send2;
        public Form2()
        {
            InitializeComponent();
        }

        public void ReceiveData(byte[] dataTemp)
        {
            //选择编码格式
            string str = Encoding.GetEncoding("GB2312").GetString(dataTemp);
            //0x00 -> \0 结束 不会显示
            str = str.Replace("\0", "\\0");
            richTextBox1.AppendText(str);
        }

        internal void ReceiveData2(object sender, TransmitEventAgrs e)
        {
            //选择编码格式
            string str = Encoding.GetEncoding("GB2312").GetString(e.data);
            //0x00 -> \0 结束 不会显示
            /* str = str.Replace("\0", "\\0");
             richTextBox1.AppendText(str);*/
            MessageBox.Show(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] dataTemp = Encoding.GetEncoding("GB2312").GetBytes(textBox1.Text);
            useForm1Send?.Invoke(dataTemp);
            useForm1Send2?.Invoke(this, new TransmitEventAgrs { data = dataTemp});


        }
    }
}
