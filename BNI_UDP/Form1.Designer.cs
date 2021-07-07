namespace BNI_UDP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.single_connection = new System.Windows.Forms.Button();
            this.single_ipaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnablePort1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetRequest = new System.Windows.Forms.Button();
            this.btnEnablePort2 = new System.Windows.Forms.Button();
            this.btnEnablePort3 = new System.Windows.Forms.Button();
            this.btnEnablePort4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDataPort1 = new System.Windows.Forms.TextBox();
            this.tbDataPort2 = new System.Windows.Forms.TextBox();
            this.tbDataPort3 = new System.Windows.Forms.TextBox();
            this.tbDataPort4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRequestTimer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxdirectparameters = new System.Windows.Forms.TextBox();
            this.labeldirectparameters = new System.Windows.Forms.Label();
            this.textBoxPrcessOutputs = new System.Windows.Forms.TextBox();
            this.labelPrcessOutputs = new System.Windows.Forms.Label();
            this.textBoxPrcessInputs = new System.Windows.Forms.TextBox();
            this.labelPrcessInputs = new System.Windows.Forms.Label();
            this.textBoxdsContentChecksum = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxdsContentBuffer = new System.Windows.Forms.TextBox();
            this.textBoxEventFlag = new System.Windows.Forms.TextBox();
            this.labeldsContentChecksum = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labeldsContentBuffer = new System.Windows.Forms.Label();
            this.labelEventFlag = new System.Windows.Forms.Label();
            this.textBoxdsContentDeviceId = new System.Windows.Forms.TextBox();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.textBoxdsContentVendorID = new System.Windows.Forms.TextBox();
            this.textBoxApplicationTag = new System.Windows.Forms.TextBox();
            this.labeldsContentDeviceId = new System.Windows.Forms.Label();
            this.labeldsContentVendorID = new System.Windows.Forms.Label();
            this.labelEvent = new System.Windows.Forms.Label();
            this.labelAPPTag = new System.Windows.Forms.Label();
            this.textBoxFWRevision = new System.Windows.Forms.TextBox();
            this.textBoxHWRevision = new System.Windows.Forms.TextBox();
            this.labelFWRevision = new System.Windows.Forms.Label();
            this.labelHWRevision = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxProductText = new System.Windows.Forms.TextBox();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelProductText = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.textBoxproductName = new System.Windows.Forms.TextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelproductName = new System.Windows.Forms.Label();
            this.textBoxVendorText = new System.Windows.Forms.TextBox();
            this.textBoxVendorName = new System.Windows.Forms.TextBox();
            this.labelVendorText = new System.Windows.Forms.Label();
            this.labelVendorName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // single_connection
            // 
            this.single_connection.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.single_connection.Location = new System.Drawing.Point(158, 37);
            this.single_connection.Name = "single_connection";
            this.single_connection.Size = new System.Drawing.Size(102, 25);
            this.single_connection.TabIndex = 7;
            this.single_connection.Text = "Connect";
            this.single_connection.UseVisualStyleBackColor = true;
            this.single_connection.Click += new System.EventHandler(this.single_connection_Click);
            // 
            // single_ipaddress
            // 
            this.single_ipaddress.Location = new System.Drawing.Point(22, 39);
            this.single_ipaddress.Name = "single_ipaddress";
            this.single_ipaddress.Size = new System.Drawing.Size(130, 21);
            this.single_ipaddress.TabIndex = 5;
            this.single_ipaddress.Text = "192.168.0.3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remote IP addresse";
            // 
            // btnEnablePort1
            // 
            this.btnEnablePort1.Location = new System.Drawing.Point(97, 84);
            this.btnEnablePort1.Name = "btnEnablePort1";
            this.btnEnablePort1.Size = new System.Drawing.Size(55, 28);
            this.btnEnablePort1.TabIndex = 11;
            this.btnEnablePort1.Text = "Port1";
            this.btnEnablePort1.UseVisualStyleBackColor = true;
            this.btnEnablePort1.Click += new System.EventHandler(this.btnEnablePort1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enable \r\nIO-Link";
            // 
            // btnGetRequest
            // 
            this.btnGetRequest.Location = new System.Drawing.Point(100, 342);
            this.btnGetRequest.Name = "btnGetRequest";
            this.btnGetRequest.Size = new System.Drawing.Size(65, 37);
            this.btnGetRequest.TabIndex = 14;
            this.btnGetRequest.Text = "Enable";
            this.btnGetRequest.UseVisualStyleBackColor = true;
            this.btnGetRequest.Click += new System.EventHandler(this.btnGetRequest_Click);
            // 
            // btnEnablePort2
            // 
            this.btnEnablePort2.Location = new System.Drawing.Point(171, 84);
            this.btnEnablePort2.Name = "btnEnablePort2";
            this.btnEnablePort2.Size = new System.Drawing.Size(55, 28);
            this.btnEnablePort2.TabIndex = 16;
            this.btnEnablePort2.Text = "Port2";
            this.btnEnablePort2.UseVisualStyleBackColor = true;
            this.btnEnablePort2.Click += new System.EventHandler(this.btnEnablePort2_Click);
            // 
            // btnEnablePort3
            // 
            this.btnEnablePort3.Location = new System.Drawing.Point(243, 84);
            this.btnEnablePort3.Name = "btnEnablePort3";
            this.btnEnablePort3.Size = new System.Drawing.Size(55, 28);
            this.btnEnablePort3.TabIndex = 17;
            this.btnEnablePort3.Text = "Port3";
            this.btnEnablePort3.UseVisualStyleBackColor = true;
            this.btnEnablePort3.Click += new System.EventHandler(this.btnEnablePort3_Click);
            // 
            // btnEnablePort4
            // 
            this.btnEnablePort4.Location = new System.Drawing.Point(310, 84);
            this.btnEnablePort4.Name = "btnEnablePort4";
            this.btnEnablePort4.Size = new System.Drawing.Size(55, 28);
            this.btnEnablePort4.TabIndex = 18;
            this.btnEnablePort4.Text = "Port4";
            this.btnEnablePort4.UseVisualStyleBackColor = true;
            this.btnEnablePort4.Click += new System.EventHandler(this.btnEnablePort4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Process in\r\nData Port 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Process in \r\nData Port 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Process in \r\nData Port 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Process in \r\nData Port 4";
            // 
            // tbDataPort1
            // 
            this.tbDataPort1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDataPort1.Location = new System.Drawing.Point(116, 150);
            this.tbDataPort1.Name = "tbDataPort1";
            this.tbDataPort1.Size = new System.Drawing.Size(193, 26);
            this.tbDataPort1.TabIndex = 23;
            // 
            // tbDataPort2
            // 
            this.tbDataPort2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDataPort2.Location = new System.Drawing.Point(116, 198);
            this.tbDataPort2.Name = "tbDataPort2";
            this.tbDataPort2.Size = new System.Drawing.Size(193, 26);
            this.tbDataPort2.TabIndex = 24;
            // 
            // tbDataPort3
            // 
            this.tbDataPort3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDataPort3.Location = new System.Drawing.Point(116, 248);
            this.tbDataPort3.Name = "tbDataPort3";
            this.tbDataPort3.Size = new System.Drawing.Size(193, 26);
            this.tbDataPort3.TabIndex = 25;
            // 
            // tbDataPort4
            // 
            this.tbDataPort4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDataPort4.Location = new System.Drawing.Point(116, 298);
            this.tbDataPort4.Name = "tbDataPort4";
            this.tbDataPort4.Size = new System.Drawing.Size(193, 26);
            this.tbDataPort4.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Read\r\nProcessdata\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbRequestTimer
            // 
            this.tbRequestTimer.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRequestTimer.Location = new System.Drawing.Point(265, 351);
            this.tbRequestTimer.Name = "tbRequestTimer";
            this.tbRequestTimer.Size = new System.Drawing.Size(80, 22);
            this.tbRequestTimer.TabIndex = 31;
            this.tbRequestTimer.Text = "5000";
            this.tbRequestTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRequestTimer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRequestTimer_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "Request Time";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "ms";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxdirectparameters);
            this.groupBox1.Controls.Add(this.labeldirectparameters);
            this.groupBox1.Controls.Add(this.textBoxPrcessOutputs);
            this.groupBox1.Controls.Add(this.labelPrcessOutputs);
            this.groupBox1.Controls.Add(this.textBoxPrcessInputs);
            this.groupBox1.Controls.Add(this.labelPrcessInputs);
            this.groupBox1.Controls.Add(this.textBoxdsContentChecksum);
            this.groupBox1.Controls.Add(this.textBoxStatus);
            this.groupBox1.Controls.Add(this.textBoxdsContentBuffer);
            this.groupBox1.Controls.Add(this.textBoxEventFlag);
            this.groupBox1.Controls.Add(this.labeldsContentChecksum);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.labeldsContentBuffer);
            this.groupBox1.Controls.Add(this.labelEventFlag);
            this.groupBox1.Controls.Add(this.textBoxdsContentDeviceId);
            this.groupBox1.Controls.Add(this.textBoxEvent);
            this.groupBox1.Controls.Add(this.textBoxdsContentVendorID);
            this.groupBox1.Controls.Add(this.textBoxApplicationTag);
            this.groupBox1.Controls.Add(this.labeldsContentDeviceId);
            this.groupBox1.Controls.Add(this.labeldsContentVendorID);
            this.groupBox1.Controls.Add(this.labelEvent);
            this.groupBox1.Controls.Add(this.labelAPPTag);
            this.groupBox1.Controls.Add(this.textBoxFWRevision);
            this.groupBox1.Controls.Add(this.textBoxHWRevision);
            this.groupBox1.Controls.Add(this.labelFWRevision);
            this.groupBox1.Controls.Add(this.labelHWRevision);
            this.groupBox1.Controls.Add(this.textBoxSerialNumber);
            this.groupBox1.Controls.Add(this.textBoxProductText);
            this.groupBox1.Controls.Add(this.labelSerialNumber);
            this.groupBox1.Controls.Add(this.labelProductText);
            this.groupBox1.Controls.Add(this.textBoxProductID);
            this.groupBox1.Controls.Add(this.textBoxproductName);
            this.groupBox1.Controls.Add(this.labelProductID);
            this.groupBox1.Controls.Add(this.labelproductName);
            this.groupBox1.Controls.Add(this.textBoxVendorText);
            this.groupBox1.Controls.Add(this.textBoxVendorName);
            this.groupBox1.Controls.Add(this.labelVendorText);
            this.groupBox1.Controls.Add(this.labelVendorName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.Location = new System.Drawing.Point(374, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 352);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JSON Data";
            // 
            // textBoxdirectparameters
            // 
            this.textBoxdirectparameters.Location = new System.Drawing.Point(126, 314);
            this.textBoxdirectparameters.Name = "textBoxdirectparameters";
            this.textBoxdirectparameters.Size = new System.Drawing.Size(367, 21);
            this.textBoxdirectparameters.TabIndex = 63;
            // 
            // labeldirectparameters
            // 
            this.labeldirectparameters.AutoSize = true;
            this.labeldirectparameters.Location = new System.Drawing.Point(12, 320);
            this.labeldirectparameters.Name = "labeldirectparameters";
            this.labeldirectparameters.Size = new System.Drawing.Size(107, 12);
            this.labeldirectparameters.TabIndex = 62;
            this.labeldirectparameters.Text = "DirectParameters:";
            // 
            // textBoxPrcessOutputs
            // 
            this.textBoxPrcessOutputs.Location = new System.Drawing.Point(126, 290);
            this.textBoxPrcessOutputs.Name = "textBoxPrcessOutputs";
            this.textBoxPrcessOutputs.Size = new System.Drawing.Size(367, 21);
            this.textBoxPrcessOutputs.TabIndex = 63;
            // 
            // labelPrcessOutputs
            // 
            this.labelPrcessOutputs.AutoSize = true;
            this.labelPrcessOutputs.Location = new System.Drawing.Point(12, 294);
            this.labelPrcessOutputs.Name = "labelPrcessOutputs";
            this.labelPrcessOutputs.Size = new System.Drawing.Size(89, 12);
            this.labelPrcessOutputs.TabIndex = 62;
            this.labelPrcessOutputs.Text = "PrcessOutputs:";
            // 
            // textBoxPrcessInputs
            // 
            this.textBoxPrcessInputs.Location = new System.Drawing.Point(126, 264);
            this.textBoxPrcessInputs.Name = "textBoxPrcessInputs";
            this.textBoxPrcessInputs.Size = new System.Drawing.Size(367, 21);
            this.textBoxPrcessInputs.TabIndex = 61;
            // 
            // labelPrcessInputs
            // 
            this.labelPrcessInputs.AutoSize = true;
            this.labelPrcessInputs.Location = new System.Drawing.Point(12, 267);
            this.labelPrcessInputs.Name = "labelPrcessInputs";
            this.labelPrcessInputs.Size = new System.Drawing.Size(83, 12);
            this.labelPrcessInputs.TabIndex = 60;
            this.labelPrcessInputs.Text = "PrcessInputs:";
            // 
            // textBoxdsContentChecksum
            // 
            this.textBoxdsContentChecksum.Location = new System.Drawing.Point(378, 239);
            this.textBoxdsContentChecksum.Name = "textBoxdsContentChecksum";
            this.textBoxdsContentChecksum.Size = new System.Drawing.Size(115, 21);
            this.textBoxdsContentChecksum.TabIndex = 59;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(378, 187);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(115, 21);
            this.textBoxStatus.TabIndex = 59;
            // 
            // textBoxdsContentBuffer
            // 
            this.textBoxdsContentBuffer.Location = new System.Drawing.Point(126, 237);
            this.textBoxdsContentBuffer.Name = "textBoxdsContentBuffer";
            this.textBoxdsContentBuffer.Size = new System.Drawing.Size(126, 21);
            this.textBoxdsContentBuffer.TabIndex = 58;
            // 
            // textBoxEventFlag
            // 
            this.textBoxEventFlag.Location = new System.Drawing.Point(126, 185);
            this.textBoxEventFlag.Name = "textBoxEventFlag";
            this.textBoxEventFlag.Size = new System.Drawing.Size(126, 21);
            this.textBoxEventFlag.TabIndex = 58;
            // 
            // labeldsContentChecksum
            // 
            this.labeldsContentChecksum.AutoSize = true;
            this.labeldsContentChecksum.Location = new System.Drawing.Point(264, 243);
            this.labeldsContentChecksum.Name = "labeldsContentChecksum";
            this.labeldsContentChecksum.Size = new System.Drawing.Size(113, 12);
            this.labeldsContentChecksum.TabIndex = 57;
            this.labeldsContentChecksum.Text = "dsContentChecksum:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(264, 191);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 12);
            this.labelStatus.TabIndex = 57;
            this.labelStatus.Text = "Status:";
            // 
            // labeldsContentBuffer
            // 
            this.labeldsContentBuffer.AutoSize = true;
            this.labeldsContentBuffer.Location = new System.Drawing.Point(12, 240);
            this.labeldsContentBuffer.Name = "labeldsContentBuffer";
            this.labeldsContentBuffer.Size = new System.Drawing.Size(101, 12);
            this.labeldsContentBuffer.TabIndex = 56;
            this.labeldsContentBuffer.Text = "dsContentBuffer:";
            // 
            // labelEventFlag
            // 
            this.labelEventFlag.AutoSize = true;
            this.labelEventFlag.Location = new System.Drawing.Point(12, 188);
            this.labelEventFlag.Name = "labelEventFlag";
            this.labelEventFlag.Size = new System.Drawing.Size(65, 12);
            this.labelEventFlag.TabIndex = 56;
            this.labelEventFlag.Text = "EventFlag:";
            // 
            // textBoxdsContentDeviceId
            // 
            this.textBoxdsContentDeviceId.Location = new System.Drawing.Point(378, 213);
            this.textBoxdsContentDeviceId.Name = "textBoxdsContentDeviceId";
            this.textBoxdsContentDeviceId.Size = new System.Drawing.Size(115, 21);
            this.textBoxdsContentDeviceId.TabIndex = 55;
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Location = new System.Drawing.Point(378, 161);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(115, 21);
            this.textBoxEvent.TabIndex = 55;
            // 
            // textBoxdsContentVendorID
            // 
            this.textBoxdsContentVendorID.Location = new System.Drawing.Point(126, 211);
            this.textBoxdsContentVendorID.Name = "textBoxdsContentVendorID";
            this.textBoxdsContentVendorID.Size = new System.Drawing.Size(126, 21);
            this.textBoxdsContentVendorID.TabIndex = 54;
            // 
            // textBoxApplicationTag
            // 
            this.textBoxApplicationTag.Location = new System.Drawing.Point(126, 159);
            this.textBoxApplicationTag.Name = "textBoxApplicationTag";
            this.textBoxApplicationTag.Size = new System.Drawing.Size(126, 21);
            this.textBoxApplicationTag.TabIndex = 54;
            // 
            // labeldsContentDeviceId
            // 
            this.labeldsContentDeviceId.AutoSize = true;
            this.labeldsContentDeviceId.Location = new System.Drawing.Point(264, 217);
            this.labeldsContentDeviceId.Name = "labeldsContentDeviceId";
            this.labeldsContentDeviceId.Size = new System.Drawing.Size(113, 12);
            this.labeldsContentDeviceId.TabIndex = 53;
            this.labeldsContentDeviceId.Text = "dsContentDeviceId:";
            // 
            // labeldsContentVendorID
            // 
            this.labeldsContentVendorID.AutoSize = true;
            this.labeldsContentVendorID.Location = new System.Drawing.Point(12, 214);
            this.labeldsContentVendorID.Name = "labeldsContentVendorID";
            this.labeldsContentVendorID.Size = new System.Drawing.Size(113, 12);
            this.labeldsContentVendorID.TabIndex = 52;
            this.labeldsContentVendorID.Text = "dsContentVendorID:";
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Location = new System.Drawing.Point(264, 165);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(41, 12);
            this.labelEvent.TabIndex = 53;
            this.labelEvent.Text = "Event:";
            // 
            // labelAPPTag
            // 
            this.labelAPPTag.AutoSize = true;
            this.labelAPPTag.Location = new System.Drawing.Point(12, 162);
            this.labelAPPTag.Name = "labelAPPTag";
            this.labelAPPTag.Size = new System.Drawing.Size(95, 12);
            this.labelAPPTag.TabIndex = 52;
            this.labelAPPTag.Text = "ApplicationTag:";
            // 
            // textBoxFWRevision
            // 
            this.textBoxFWRevision.Location = new System.Drawing.Point(378, 134);
            this.textBoxFWRevision.Name = "textBoxFWRevision";
            this.textBoxFWRevision.Size = new System.Drawing.Size(115, 21);
            this.textBoxFWRevision.TabIndex = 51;
            // 
            // textBoxHWRevision
            // 
            this.textBoxHWRevision.Location = new System.Drawing.Point(126, 132);
            this.textBoxHWRevision.Name = "textBoxHWRevision";
            this.textBoxHWRevision.Size = new System.Drawing.Size(126, 21);
            this.textBoxHWRevision.TabIndex = 50;
            // 
            // labelFWRevision
            // 
            this.labelFWRevision.AutoSize = true;
            this.labelFWRevision.Location = new System.Drawing.Point(264, 138);
            this.labelFWRevision.Name = "labelFWRevision";
            this.labelFWRevision.Size = new System.Drawing.Size(71, 12);
            this.labelFWRevision.TabIndex = 49;
            this.labelFWRevision.Text = "FWRevision:";
            // 
            // labelHWRevision
            // 
            this.labelHWRevision.AutoSize = true;
            this.labelHWRevision.Location = new System.Drawing.Point(12, 135);
            this.labelHWRevision.Name = "labelHWRevision";
            this.labelHWRevision.Size = new System.Drawing.Size(71, 12);
            this.labelHWRevision.TabIndex = 48;
            this.labelHWRevision.Text = "HWRevision:";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(378, 108);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(115, 21);
            this.textBoxSerialNumber.TabIndex = 47;
            // 
            // textBoxProductText
            // 
            this.textBoxProductText.Location = new System.Drawing.Point(126, 106);
            this.textBoxProductText.Name = "textBoxProductText";
            this.textBoxProductText.Size = new System.Drawing.Size(126, 21);
            this.textBoxProductText.TabIndex = 46;
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Location = new System.Drawing.Point(264, 112);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(83, 12);
            this.labelSerialNumber.TabIndex = 45;
            this.labelSerialNumber.Text = "SerialNumber:";
            // 
            // labelProductText
            // 
            this.labelProductText.AutoSize = true;
            this.labelProductText.Location = new System.Drawing.Point(12, 109);
            this.labelProductText.Name = "labelProductText";
            this.labelProductText.Size = new System.Drawing.Size(77, 12);
            this.labelProductText.TabIndex = 44;
            this.labelProductText.Text = "ProductText:";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(378, 81);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(115, 21);
            this.textBoxProductID.TabIndex = 43;
            // 
            // textBoxproductName
            // 
            this.textBoxproductName.Location = new System.Drawing.Point(126, 79);
            this.textBoxproductName.Name = "textBoxproductName";
            this.textBoxproductName.Size = new System.Drawing.Size(126, 21);
            this.textBoxproductName.TabIndex = 42;
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Location = new System.Drawing.Point(264, 85);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(65, 12);
            this.labelProductID.TabIndex = 41;
            this.labelProductID.Text = "ProductID:";
            // 
            // labelproductName
            // 
            this.labelproductName.AutoSize = true;
            this.labelproductName.Location = new System.Drawing.Point(12, 82);
            this.labelproductName.Name = "labelproductName";
            this.labelproductName.Size = new System.Drawing.Size(77, 12);
            this.labelproductName.TabIndex = 40;
            this.labelproductName.Text = "ProductName:";
            // 
            // textBoxVendorText
            // 
            this.textBoxVendorText.Location = new System.Drawing.Point(378, 55);
            this.textBoxVendorText.Name = "textBoxVendorText";
            this.textBoxVendorText.Size = new System.Drawing.Size(115, 21);
            this.textBoxVendorText.TabIndex = 39;
            // 
            // textBoxVendorName
            // 
            this.textBoxVendorName.Location = new System.Drawing.Point(126, 53);
            this.textBoxVendorName.Name = "textBoxVendorName";
            this.textBoxVendorName.Size = new System.Drawing.Size(126, 21);
            this.textBoxVendorName.TabIndex = 38;
            // 
            // labelVendorText
            // 
            this.labelVendorText.AutoSize = true;
            this.labelVendorText.Location = new System.Drawing.Point(264, 59);
            this.labelVendorText.Name = "labelVendorText";
            this.labelVendorText.Size = new System.Drawing.Size(71, 12);
            this.labelVendorText.TabIndex = 37;
            this.labelVendorText.Text = "VendorText:";
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(12, 56);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(71, 12);
            this.labelVendorName.TabIndex = 36;
            this.labelVendorName.Text = "VendorName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ports:";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cbPort.Location = new System.Drawing.Point(75, 20);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 20);
            this.cbPort.TabIndex = 0;
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(316, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 26);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "4";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(315, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 26);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = "4";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(316, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 26);
            this.textBox3.TabIndex = 38;
            this.textBox3.Text = "4";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(315, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 26);
            this.textBox4.TabIndex = 39;
            this.textBox4.Text = "4";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 40;
            this.label11.Text = "Datasize";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Save CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbRequestTimer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDataPort4);
            this.Controls.Add(this.tbDataPort3);
            this.Controls.Add(this.tbDataPort2);
            this.Controls.Add(this.tbDataPort1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnablePort4);
            this.Controls.Add(this.btnEnablePort3);
            this.Controls.Add(this.btnEnablePort2);
            this.Controls.Add(this.btnGetRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnablePort1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.single_connection);
            this.Controls.Add(this.single_ipaddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Balluff JSON Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button single_connection;
        private System.Windows.Forms.TextBox single_ipaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnablePort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetRequest;
        private System.Windows.Forms.Button btnEnablePort2;
        private System.Windows.Forms.Button btnEnablePort3;
        private System.Windows.Forms.Button btnEnablePort4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDataPort1;
        private System.Windows.Forms.TextBox tbDataPort2;
        private System.Windows.Forms.TextBox tbDataPort3;
        private System.Windows.Forms.TextBox tbDataPort4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRequestTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxdirectparameters;
        private System.Windows.Forms.Label labeldirectparameters;
        private System.Windows.Forms.TextBox textBoxPrcessOutputs;
        private System.Windows.Forms.Label labelPrcessOutputs;
        private System.Windows.Forms.TextBox textBoxPrcessInputs;
        private System.Windows.Forms.Label labelPrcessInputs;
        private System.Windows.Forms.TextBox textBoxdsContentChecksum;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxdsContentBuffer;
        private System.Windows.Forms.TextBox textBoxEventFlag;
        private System.Windows.Forms.Label labeldsContentChecksum;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labeldsContentBuffer;
        private System.Windows.Forms.Label labelEventFlag;
        private System.Windows.Forms.TextBox textBoxdsContentDeviceId;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.TextBox textBoxdsContentVendorID;
        private System.Windows.Forms.TextBox textBoxApplicationTag;
        private System.Windows.Forms.Label labeldsContentDeviceId;
        private System.Windows.Forms.Label labeldsContentVendorID;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Label labelAPPTag;
        private System.Windows.Forms.TextBox textBoxFWRevision;
        private System.Windows.Forms.TextBox textBoxHWRevision;
        private System.Windows.Forms.Label labelFWRevision;
        private System.Windows.Forms.Label labelHWRevision;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxProductText;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelProductText;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.TextBox textBoxproductName;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labelproductName;
        private System.Windows.Forms.TextBox textBoxVendorText;
        private System.Windows.Forms.TextBox textBoxVendorName;
        private System.Windows.Forms.Label labelVendorText;
        private System.Windows.Forms.Label labelVendorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}

