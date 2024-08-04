namespace SerialPort_Assistant
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cob_port = new System.Windows.Forms.ComboBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.txt_receive = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.chb_DTR = new System.Windows.Forms.CheckBox();
            this.chb_RTS = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cob_stopbit = new System.Windows.Forms.ComboBox();
            this.cob_databit = new System.Windows.Forms.ComboBox();
            this.cob_check = new System.Windows.Forms.ComboBox();
            this.cob_baud = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_receivefile = new System.Windows.Forms.TextBox();
            this.btn_savedata = new System.Windows.Forms.Button();
            this.btn_choosepath = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.chb_receivehex = new System.Windows.Forms.CheckBox();
            this.chb_autoclear = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_autotimer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sendfile = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_sendfile = new System.Windows.Forms.Button();
            this.chb_autosend = new System.Windows.Forms.CheckBox();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.chb_sendhex = new System.Windows.Forms.CheckBox();
            this.btn_clearsend = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_state = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_sendcount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_receivecount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_clearcount = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chb_startdata = new System.Windows.Forms.CheckBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_data4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_data3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_data2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_data1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cob_port
            // 
            this.cob_port.FormattingEnabled = true;
            this.cob_port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.cob_port.Location = new System.Drawing.Point(123, 18);
            this.cob_port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cob_port.Name = "cob_port";
            this.cob_port.Size = new System.Drawing.Size(104, 28);
            this.cob_port.TabIndex = 0;
            // 
            // txt_send
            // 
            this.txt_send.BackColor = System.Drawing.Color.Beige;
            this.txt_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_send.Location = new System.Drawing.Point(3, 23);
            this.txt_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(401, 184);
            this.txt_send.TabIndex = 3;
            this.txt_send.TextChanged += new System.EventHandler(this.txt_send_TextChanged);
            this.txt_send.Leave += new System.EventHandler(this.txt_send_Leave);
            // 
            // txt_receive
            // 
            this.txt_receive.BackColor = System.Drawing.Color.Beige;
            this.txt_receive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_receive.Location = new System.Drawing.Point(3, 23);
            this.txt_receive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_receive.Multiline = true;
            this.txt_receive.Name = "txt_receive";
            this.txt_receive.Size = new System.Drawing.Size(404, 348);
            this.txt_receive.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.chb_DTR);
            this.groupBox1.Controls.Add(this.chb_RTS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cob_stopbit);
            this.groupBox1.Controls.Add(this.cob_databit);
            this.groupBox1.Controls.Add(this.cob_check);
            this.groupBox1.Controls.Add(this.cob_baud);
            this.groupBox1.Controls.Add(this.cob_port);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 251);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(123, 207);
            this.btn_open.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(104, 31);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "打开串口";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // chb_DTR
            // 
            this.chb_DTR.AutoSize = true;
            this.chb_DTR.Location = new System.Drawing.Point(40, 224);
            this.chb_DTR.Name = "chb_DTR";
            this.chb_DTR.Size = new System.Drawing.Size(61, 24);
            this.chb_DTR.TabIndex = 2;
            this.chb_DTR.Text = "DTR";
            this.chb_DTR.UseVisualStyleBackColor = true;
            this.chb_DTR.CheckedChanged += new System.EventHandler(this.chb_DTR_CheckedChanged);
            // 
            // chb_RTS
            // 
            this.chb_RTS.AutoSize = true;
            this.chb_RTS.Location = new System.Drawing.Point(40, 194);
            this.chb_RTS.Name = "chb_RTS";
            this.chb_RTS.Size = new System.Drawing.Size(59, 24);
            this.chb_RTS.TabIndex = 2;
            this.chb_RTS.Text = "RTS";
            this.chb_RTS.UseVisualStyleBackColor = true;
            this.chb_RTS.CheckedChanged += new System.EventHandler(this.chb_RTS_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口号";
            // 
            // cob_stopbit
            // 
            this.cob_stopbit.FormattingEnabled = true;
            this.cob_stopbit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cob_stopbit.Location = new System.Drawing.Point(123, 162);
            this.cob_stopbit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cob_stopbit.Name = "cob_stopbit";
            this.cob_stopbit.Size = new System.Drawing.Size(104, 28);
            this.cob_stopbit.TabIndex = 0;
            // 
            // cob_databit
            // 
            this.cob_databit.FormattingEnabled = true;
            this.cob_databit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cob_databit.Location = new System.Drawing.Point(123, 126);
            this.cob_databit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cob_databit.Name = "cob_databit";
            this.cob_databit.Size = new System.Drawing.Size(104, 28);
            this.cob_databit.TabIndex = 0;
            // 
            // cob_check
            // 
            this.cob_check.FormattingEnabled = true;
            this.cob_check.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.cob_check.Location = new System.Drawing.Point(123, 90);
            this.cob_check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cob_check.Name = "cob_check";
            this.cob_check.Size = new System.Drawing.Size(104, 28);
            this.cob_check.TabIndex = 0;
            // 
            // cob_baud
            // 
            this.cob_baud.FormattingEnabled = true;
            this.cob_baud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.cob_baud.Location = new System.Drawing.Point(123, 54);
            this.cob_baud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cob_baud.Name = "cob_baud";
            this.cob_baud.Size = new System.Drawing.Size(104, 28);
            this.cob_baud.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_receivefile);
            this.groupBox2.Controls.Add(this.btn_savedata);
            this.groupBox2.Controls.Add(this.btn_choosepath);
            this.groupBox2.Controls.Add(this.btn_stop);
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.chb_receivehex);
            this.groupBox2.Controls.Add(this.chb_autoclear);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 153);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // txt_receivefile
            // 
            this.txt_receivefile.Location = new System.Drawing.Point(27, 117);
            this.txt_receivefile.Name = "txt_receivefile";
            this.txt_receivefile.Size = new System.Drawing.Size(200, 27);
            this.txt_receivefile.TabIndex = 5;
            // 
            // btn_savedata
            // 
            this.btn_savedata.Location = new System.Drawing.Point(128, 83);
            this.btn_savedata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_savedata.Name = "btn_savedata";
            this.btn_savedata.Size = new System.Drawing.Size(99, 27);
            this.btn_savedata.TabIndex = 4;
            this.btn_savedata.Text = "保存数据";
            this.btn_savedata.UseVisualStyleBackColor = true;
            this.btn_savedata.Click += new System.EventHandler(this.btn_savedata_Click);
            // 
            // btn_choosepath
            // 
            this.btn_choosepath.Location = new System.Drawing.Point(27, 82);
            this.btn_choosepath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_choosepath.Name = "btn_choosepath";
            this.btn_choosepath.Size = new System.Drawing.Size(99, 27);
            this.btn_choosepath.TabIndex = 4;
            this.btn_choosepath.Text = "选择路径";
            this.btn_choosepath.UseVisualStyleBackColor = true;
            this.btn_choosepath.Click += new System.EventHandler(this.btn_choosepath_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(128, 48);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(99, 27);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "暂停";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(128, 18);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(99, 27);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "手动清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // chb_receivehex
            // 
            this.chb_receivehex.AutoSize = true;
            this.chb_receivehex.Location = new System.Drawing.Point(27, 51);
            this.chb_receivehex.Name = "chb_receivehex";
            this.chb_receivehex.Size = new System.Drawing.Size(91, 24);
            this.chb_receivehex.TabIndex = 2;
            this.chb_receivehex.Text = "十六进制";
            this.chb_receivehex.UseVisualStyleBackColor = true;
            this.chb_receivehex.CheckedChanged += new System.EventHandler(this.chb_receivehex_CheckedChanged);
            // 
            // chb_autoclear
            // 
            this.chb_autoclear.AutoSize = true;
            this.chb_autoclear.Location = new System.Drawing.Point(27, 21);
            this.chb_autoclear.Name = "chb_autoclear";
            this.chb_autoclear.Size = new System.Drawing.Size(91, 24);
            this.chb_autoclear.TabIndex = 2;
            this.chb_autoclear.Text = "自动清空";
            this.chb_autoclear.UseVisualStyleBackColor = true;
            this.chb_autoclear.CheckedChanged += new System.EventHandler(this.chb_autoclear_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_autotimer);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_sendfile);
            this.groupBox3.Controls.Add(this.btn_send);
            this.groupBox3.Controls.Add(this.btn_sendfile);
            this.groupBox3.Controls.Add(this.chb_autosend);
            this.groupBox3.Controls.Add(this.btn_openfile);
            this.groupBox3.Controls.Add(this.chb_sendhex);
            this.groupBox3.Controls.Add(this.btn_clearsend);
            this.groupBox3.Location = new System.Drawing.Point(12, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 187);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // txt_autotimer
            // 
            this.txt_autotimer.Location = new System.Drawing.Point(144, 151);
            this.txt_autotimer.Name = "txt_autotimer";
            this.txt_autotimer.Size = new System.Drawing.Size(103, 27);
            this.txt_autotimer.TabIndex = 7;
            this.txt_autotimer.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "自动发送周期(ms):";
            // 
            // txt_sendfile
            // 
            this.txt_sendfile.Location = new System.Drawing.Point(27, 114);
            this.txt_sendfile.Name = "txt_sendfile";
            this.txt_sendfile.Size = new System.Drawing.Size(200, 27);
            this.txt_sendfile.TabIndex = 5;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(128, 15);
            this.btn_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(99, 27);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "手动发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_sendfile
            // 
            this.btn_sendfile.Location = new System.Drawing.Point(128, 80);
            this.btn_sendfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sendfile.Name = "btn_sendfile";
            this.btn_sendfile.Size = new System.Drawing.Size(99, 27);
            this.btn_sendfile.TabIndex = 4;
            this.btn_sendfile.Text = "发送文件";
            this.btn_sendfile.UseVisualStyleBackColor = true;
            this.btn_sendfile.Click += new System.EventHandler(this.btn_sendfile_Click);
            // 
            // chb_autosend
            // 
            this.chb_autosend.AutoSize = true;
            this.chb_autosend.Location = new System.Drawing.Point(27, 18);
            this.chb_autosend.Name = "chb_autosend";
            this.chb_autosend.Size = new System.Drawing.Size(91, 24);
            this.chb_autosend.TabIndex = 2;
            this.chb_autosend.Text = "自动发送";
            this.chb_autosend.UseVisualStyleBackColor = true;
            this.chb_autosend.CheckedChanged += new System.EventHandler(this.chb_autosend_CheckedChanged);
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(27, 79);
            this.btn_openfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(99, 27);
            this.btn_openfile.TabIndex = 4;
            this.btn_openfile.Text = "打开文件";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // chb_sendhex
            // 
            this.chb_sendhex.AutoSize = true;
            this.chb_sendhex.Location = new System.Drawing.Point(27, 48);
            this.chb_sendhex.Name = "chb_sendhex";
            this.chb_sendhex.Size = new System.Drawing.Size(91, 24);
            this.chb_sendhex.TabIndex = 2;
            this.chb_sendhex.Text = "十六进制";
            this.chb_sendhex.UseVisualStyleBackColor = true;
            this.chb_sendhex.CheckedChanged += new System.EventHandler(this.chb_sendhex_CheckedChanged);
            // 
            // btn_clearsend
            // 
            this.btn_clearsend.Location = new System.Drawing.Point(128, 45);
            this.btn_clearsend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clearsend.Name = "btn_clearsend";
            this.btn_clearsend.Size = new System.Drawing.Size(99, 27);
            this.btn_clearsend.TabIndex = 4;
            this.btn_clearsend.Text = "清空发送";
            this.btn_clearsend.UseVisualStyleBackColor = true;
            this.btn_clearsend.Click += new System.EventHandler(this.btn_clearsend_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_receive);
            this.groupBox4.Location = new System.Drawing.Point(283, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 374);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_send);
            this.groupBox5.Location = new System.Drawing.Point(286, 402);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(407, 210);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_state,
            this.toolStripStatusLabel3,
            this.tssl_sendcount,
            this.toolStripStatusLabel5,
            this.tssl_receivecount,
            this.toolStripStatusLabel6,
            this.tssl_clearcount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(926, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "状态：";
            // 
            // tssl_state
            // 
            this.tssl_state.AutoSize = false;
            this.tssl_state.Name = "tssl_state";
            this.tssl_state.Size = new System.Drawing.Size(190, 20);
            this.tssl_state.Text = "初始化正常";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel3.Text = "发送计数：";
            // 
            // tssl_sendcount
            // 
            this.tssl_sendcount.AutoSize = false;
            this.tssl_sendcount.Name = "tssl_sendcount";
            this.tssl_sendcount.Size = new System.Drawing.Size(60, 20);
            this.tssl_sendcount.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel5.Text = "接收计数：";
            // 
            // tssl_receivecount
            // 
            this.tssl_receivecount.AutoSize = false;
            this.tssl_receivecount.Name = "tssl_receivecount";
            this.tssl_receivecount.Size = new System.Drawing.Size(60, 20);
            this.tssl_receivecount.Text = "0";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(0, 20);
            // 
            // tssl_clearcount
            // 
            this.tssl_clearcount.Name = "tssl_clearcount";
            this.tssl_clearcount.Size = new System.Drawing.Size(69, 20);
            this.tssl_clearcount.Text = "清空计数";
            this.tssl_clearcount.Click += new System.EventHandler(this.tssl_clearcount_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.chb_startdata);
            this.groupBox6.Controls.Add(this.txt_data);
            this.groupBox6.Controls.Add(this.txt_data4);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txt_data3);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txt_data2);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txt_data1);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(702, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(212, 392);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "数据解析";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(16, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "例:7f0431323334DE10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(6, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 30);
            this.label15.TabIndex = 30;
            this.label15.Text = "格式：\r\n  7F+长度+数据+CRC";
            // 
            // chb_startdata
            // 
            this.chb_startdata.AutoSize = true;
            this.chb_startdata.Location = new System.Drawing.Point(7, 269);
            this.chb_startdata.Name = "chb_startdata";
            this.chb_startdata.Size = new System.Drawing.Size(136, 24);
            this.chb_startdata.TabIndex = 2;
            this.chb_startdata.Text = "启动数据帧接收";
            this.chb_startdata.UseVisualStyleBackColor = true;
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(6, 174);
            this.txt_data.Multiline = true;
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(186, 88);
            this.txt_data.TabIndex = 1;
            // 
            // txt_data4
            // 
            this.txt_data4.Location = new System.Drawing.Point(56, 120);
            this.txt_data4.Name = "txt_data4";
            this.txt_data4.Size = new System.Drawing.Size(126, 27);
            this.txt_data4.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "数据帧";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "数据4";
            // 
            // txt_data3
            // 
            this.txt_data3.Location = new System.Drawing.Point(56, 87);
            this.txt_data3.Name = "txt_data3";
            this.txt_data3.Size = new System.Drawing.Size(126, 27);
            this.txt_data3.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "数据3";
            // 
            // txt_data2
            // 
            this.txt_data2.Location = new System.Drawing.Point(56, 54);
            this.txt_data2.Name = "txt_data2";
            this.txt_data2.Size = new System.Drawing.Size(126, 27);
            this.txt_data2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "数据2";
            // 
            // txt_data1
            // 
            this.txt_data1.Location = new System.Drawing.Point(56, 21);
            this.txt_data1.Name = "txt_data1";
            this.txt_data1.Size = new System.Drawing.Size(126, 27);
            this.txt_data1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "数据1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 650);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cob_port;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.TextBox txt_receive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cob_stopbit;
        private System.Windows.Forms.ComboBox cob_databit;
        private System.Windows.Forms.ComboBox cob_check;
        private System.Windows.Forms.ComboBox cob_baud;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.CheckBox chb_DTR;
        private System.Windows.Forms.CheckBox chb_RTS;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.CheckBox chb_receivehex;
        private System.Windows.Forms.CheckBox chb_autoclear;
        private System.Windows.Forms.TextBox txt_receivefile;
        private System.Windows.Forms.Button btn_savedata;
        private System.Windows.Forms.Button btn_choosepath;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox txt_sendfile;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_sendfile;
        private System.Windows.Forms.CheckBox chb_autosend;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.CheckBox chb_sendhex;
        private System.Windows.Forms.Button btn_clearsend;
        private System.Windows.Forms.TextBox txt_autotimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_state;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssl_sendcount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tssl_receivecount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel tssl_clearcount;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_data4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_data3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_data2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_data1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chb_startdata;
        private System.Windows.Forms.Timer timer2;
    }
}

