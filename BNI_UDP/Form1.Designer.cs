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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.single_connection = new System.Windows.Forms.Button();
            this.single_ipaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultContainer = new System.Windows.Forms.ListBox();
            this.btnEnablePort1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetRequest = new System.Windows.Forms.Button();
            this.cbLocalPort = new System.Windows.Forms.ComboBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbRequestTimer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // single_connection
            // 
            this.single_connection.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.single_connection.Location = new System.Drawing.Point(359, 39);
            this.single_connection.Name = "single_connection";
            this.single_connection.Size = new System.Drawing.Size(95, 25);
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
            this.single_ipaddress.Text = "192.168.0.4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(194, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Local IP addresse";
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
            // ResultContainer
            // 
            this.ResultContainer.FormattingEnabled = true;
            this.ResultContainer.ItemHeight = 12;
            this.ResultContainer.Location = new System.Drawing.Point(470, 39);
            this.ResultContainer.Name = "ResultContainer";
            this.ResultContainer.Size = new System.Drawing.Size(407, 376);
            this.ResultContainer.TabIndex = 10;
            // 
            // btnEnablePort1
            // 
            this.btnEnablePort1.Location = new System.Drawing.Point(87, 80);
            this.btnEnablePort1.Name = "btnEnablePort1";
            this.btnEnablePort1.Size = new System.Drawing.Size(65, 34);
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
            this.btnGetRequest.Location = new System.Drawing.Point(115, 361);
            this.btnGetRequest.Name = "btnGetRequest";
            this.btnGetRequest.Size = new System.Drawing.Size(65, 37);
            this.btnGetRequest.TabIndex = 14;
            this.btnGetRequest.Text = "Enable";
            this.btnGetRequest.UseVisualStyleBackColor = true;
            this.btnGetRequest.Click += new System.EventHandler(this.btnGetRequest_Click);
            // 
            // cbLocalPort
            // 
            this.cbLocalPort.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbLocalPort.FormattingEnabled = true;
            this.cbLocalPort.Location = new System.Drawing.Point(197, 39);
            this.cbLocalPort.Name = "cbLocalPort";
            this.cbLocalPort.Size = new System.Drawing.Size(132, 21);
            this.cbLocalPort.TabIndex = 15;
            // 
            // btnEnablePort2
            // 
            this.btnEnablePort2.Location = new System.Drawing.Point(184, 80);
            this.btnEnablePort2.Name = "btnEnablePort2";
            this.btnEnablePort2.Size = new System.Drawing.Size(65, 34);
            this.btnEnablePort2.TabIndex = 16;
            this.btnEnablePort2.Text = "Port2";
            this.btnEnablePort2.UseVisualStyleBackColor = true;
            this.btnEnablePort2.Click += new System.EventHandler(this.btnEnablePort2_Click);
            // 
            // btnEnablePort3
            // 
            this.btnEnablePort3.Location = new System.Drawing.Point(282, 80);
            this.btnEnablePort3.Name = "btnEnablePort3";
            this.btnEnablePort3.Size = new System.Drawing.Size(65, 34);
            this.btnEnablePort3.TabIndex = 17;
            this.btnEnablePort3.Text = "Port3";
            this.btnEnablePort3.UseVisualStyleBackColor = true;
            this.btnEnablePort3.Click += new System.EventHandler(this.btnEnablePort3_Click);
            // 
            // btnEnablePort4
            // 
            this.btnEnablePort4.Location = new System.Drawing.Point(389, 80);
            this.btnEnablePort4.Name = "btnEnablePort4";
            this.btnEnablePort4.Size = new System.Drawing.Size(65, 34);
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
            this.tbDataPort1.Size = new System.Drawing.Size(338, 26);
            this.tbDataPort1.TabIndex = 23;
            // 
            // tbDataPort2
            // 
            this.tbDataPort2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDataPort2.Location = new System.Drawing.Point(116, 198);
            this.tbDataPort2.Name = "tbDataPort2";
            this.tbDataPort2.Size = new System.Drawing.Size(338, 26);
            this.tbDataPort2.TabIndex = 24;
            // 
            // tbDataPort3
            // 
            this.tbDataPort3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDataPort3.Location = new System.Drawing.Point(116, 248);
            this.tbDataPort3.Name = "tbDataPort3";
            this.tbDataPort3.Size = new System.Drawing.Size(338, 26);
            this.tbDataPort3.TabIndex = 25;
            // 
            // tbDataPort4
            // 
            this.tbDataPort4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDataPort4.Location = new System.Drawing.Point(116, 298);
            this.tbDataPort4.Name = "tbDataPort4";
            this.tbDataPort4.Size = new System.Drawing.Size(338, 26);
            this.tbDataPort4.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Read\r\nProcessdata\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbRequestTimer
            // 
            this.tbRequestTimer.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRequestTimer.Location = new System.Drawing.Point(303, 371);
            this.tbRequestTimer.Name = "tbRequestTimer";
            this.tbRequestTimer.Size = new System.Drawing.Size(100, 22);
            this.tbRequestTimer.TabIndex = 31;
            this.tbRequestTimer.Text = "500";
            this.tbRequestTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRequestTimer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRequestTimer_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "Request Time";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "ms";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 441);
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
            this.Controls.Add(this.cbLocalPort);
            this.Controls.Add(this.btnGetRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnablePort1);
            this.Controls.Add(this.ResultContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.single_connection);
            this.Controls.Add(this.single_ipaddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Balluff UDP IO-link Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button single_connection;
        private System.Windows.Forms.TextBox single_ipaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ResultContainer;
        private System.Windows.Forms.Button btnEnablePort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetRequest;
        private System.Windows.Forms.ComboBox cbLocalPort;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbRequestTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

