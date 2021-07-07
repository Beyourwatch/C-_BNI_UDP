using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // Network Communication reference
using System.Net.Sockets;
using System.Net.NetworkInformation;



namespace BNI_UDP
{
    public partial class Form1 : Form
    {

        Socket sendsocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);//定义一个Socket
        Socket receviesocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);//定义一个Socket

        Byte[] bytesReceived = new Byte[256];
        Thread listenThread ;

        bool timerenable = false;
        bool port1Enable = false;
        bool port2Enable = false;
        bool port3Enable = false;
        bool port4Enable = false;
        bool bconnected = false;

        public Form1()
        {
            InitializeComponent();
            GetAddressIP();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public static bool PingServer(string IPAddress)
        {
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(IPAddress);
                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(IPAddress + " not reachable");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Unexpected exception while Ping, check the given IPv4 address or Hostname please");
                return false;
            }

        }
               

        private void single_connection_Click(object sender, EventArgs e)
        {   
            if (bconnected == false)
            {
                try
                {

                    string ipaddress = single_ipaddress.Text; // Get IP (as string) and Single-Mode-Port (as int) from TextBoxes
                    PingServer(ipaddress);
               
                    sendsocket.Connect(ipaddress,1999);

                    if (sendsocket.Connected == true)
                    {
                        single_connection.BackColor = SystemColors.ActiveCaption;
                        single_connection.Text = "Disconnect";
                    }
                    else
                    {
                        single_connection.BackColor = SystemColors.Control;
                        single_connection.Text = "Connect";
                        MessageBox.Show("Remote Connection failed, if you disconnected, please restart");
                    }
                }
                catch (Exception ex) // Catch and show any other Exceptions
                {
                    
                    MessageBox.Show("Remote Connection failed, if you disconnected, please restart");
                    
                }

                try
                {

                    var ipe = new IPEndPoint(IPAddress.Parse(cbLocalPort.Text), 2000);
                    // Get Endpoint from IP and Port and create a new Controller instance (Contr)

                    receviesocket.Bind(ipe);

                    if (sendsocket.Connected == true)
                    {
                        single_connection.BackColor = SystemColors.ActiveCaption;
                        single_connection.Text = "Disconnect";
                        bconnected = true;
                        listenThread = new Thread(listenMessage);
                        listenThread.Start();
                    }
                    else
                    {
                        single_connection.BackColor = SystemColors.Control;
                        single_connection.Text = "Connect";
                        bconnected = false;
                        MessageBox.Show("local Connection failed, if you disconnected, please restart");
                    }

                    
                    

                }
                catch (Exception ex) // Catch and show any other Exceptions
                {
                    single_connection.BackColor = SystemColors.Control;
                    single_connection.Text = "Connect";
                    bconnected = false;
                    MessageBox.Show("local Connection failed, if you disconnected, please restart");
                    
                }
            }
            else
            {
                listenThread.Abort();
                sendsocket.Shutdown(SocketShutdown.Both);
                //sendsocket.Close();
                receviesocket.Shutdown(SocketShutdown.Both);
                //receviesocket.Close();
                single_connection.BackColor = SystemColors.Control;
                single_connection.Text = "Connect";
                bconnected = false;
            }


        }


        private void listenMessage()
        {
            byte[] bytes = new byte[1024];
            String Receviemsg = "";
            int length=0;
            String Datamsg = "";

            while (true)
            {
                Receviemsg = "";
                // Receive the response from the remote device.  
                int bytesRec = receviesocket.Receive(bytes);
                
                ResultContainer.Items.Add("Recevied data:");

                for (int index = 0; index < bytesRec; index++)
                {   
                    Receviemsg = Receviemsg + bytes[index].ToString("X2");
                }
                ResultContainer.Items.Add(Receviemsg);

                if (bytes[4] == 0x00 & bytes[3] == 0x0A)
                {
                    Datamsg = Receviemsg.Substring(10);
                    Datamsg = Datamsg.Remove(Datamsg.Length-2, 2);
                    tbDataPort1.Text = Datamsg;
                }

                if (bytes[4] == 0x02 & bytes[3] == 0x0A)
                {
                    Datamsg = Receviemsg.Substring(10);
                    Datamsg = Datamsg.Remove(Datamsg.Length - 2, 2);
                    tbDataPort2.Text = Datamsg;
                }

                if (bytes[4] == 0x04 & bytes[3] == 0x0A)
                {
                    Datamsg = Receviemsg.Substring(10);
                    Datamsg = Datamsg.Remove(Datamsg.Length - 2, 2);
                    tbDataPort3.Text = Datamsg;
                }

                if (bytes[4] == 0x06 & bytes[3] == 0x0A)
                {
                    Datamsg = Receviemsg.Substring(10);
                    Datamsg = Datamsg.Remove(Datamsg.Length - 2, 2);
                    tbDataPort4.Text = Datamsg;
                }
            }

        }

        void GetAddressIP()
        {
            ///获取本地的IP地址
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                    cbLocalPort.Items.Add(AddressIP);
                }
            }

            cbLocalPort.Text = cbLocalPort.Items[0].ToString();
            
        }

               

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                listenThread.Abort();
                sendsocket.Shutdown(SocketShutdown.Both);
                sendsocket.Close();
                receviesocket.Shutdown(SocketShutdown.Both);
                receviesocket.Close();
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }


        private void btnEnablePort1_Click(object sender, EventArgs e)
        {
            if (port1Enable == false)
            {
                enableIOLinkPort(0x00);
                port1Enable = true;
                btnEnablePort1.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                enableDigitalIOPort(0x00);
                port1Enable = false;
                btnEnablePort1.BackColor = SystemColors.Control;
            }
            
        }

        private void btnEnablePort2_Click(object sender, EventArgs e)
        {
            if (port2Enable == false)
            {
                enableIOLinkPort(0x02);
                port2Enable = true;
                btnEnablePort2.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                enableDigitalIOPort(0x02);
                port2Enable = false;
                btnEnablePort2.BackColor = SystemColors.Control;
            }
        }

        private void btnEnablePort3_Click(object sender, EventArgs e)
        {
            if (port3Enable == false)
            {
                enableIOLinkPort(0x04);
                port3Enable = true;
                btnEnablePort3.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                enableDigitalIOPort(0x04);
                port3Enable = false;
                btnEnablePort3.BackColor = SystemColors.Control;
            }
        }

        private void btnEnablePort4_Click(object sender, EventArgs e)
        {
            if (port4Enable == false)
            {
                enableIOLinkPort(0x06);
                port4Enable = true;
                btnEnablePort4.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                enableDigitalIOPort(0x06);
                port4Enable = false;
                btnEnablePort4.BackColor = SystemColors.Control;
            }
        }

        private void enableIOLinkPort(byte port)
        {
            // Encode the connect message into a byte array.  
            byte[] msg = new byte[36];
            string Sendmsg = "";
            msg[0] = 0x24;
            msg[2] = 0x02;
            msg[3] = 0x0f;
            msg[4] = port;   //Port list
            msg[6] = 0x0c;
            msg[7] = 0x11;
            msg[34] = 0x20;
            msg[35] = 0x20;

            try
            {
                // Send the data through the socket.  
                int bytesSent = sendsocket.Send(msg);

            ResultContainer.Items.Add("Send message:");

            //Build Sendmsg to show 
            for (int index = 0; index < msg.Length; index++)
            {
                Sendmsg = Sendmsg + msg[index].ToString("X2");
            }
            ResultContainer.Items.Add(Sendmsg);

            }
            catch (Exception e)
            {
                MessageBox.Show("No connection");
            }

        }

        private void enableDigitalIOPort(byte port)
        {
            // Encode the connect message into a byte array.  
            byte[] msg = new byte[36];
            string Sendmsg = "";
            msg[0] = 0x24;
            msg[2] = 0x02;
            msg[3] = 0x0f;
            msg[4] = port;   //Port list
            msg[6] = 0x04;
            msg[7] = 0x11;
            msg[34] = 0x00;
            msg[35] = 0x00;

            try
            {
                // Send the data through the socket.  
                int bytesSent = sendsocket.Send(msg);

                ResultContainer.Items.Add("Send message:");

                //Build Sendmsg to show 
                for (int index = 0; index < msg.Length; index++)
                {
                    Sendmsg = Sendmsg + msg[index].ToString("X2");
                }
                ResultContainer.Items.Add(Sendmsg);

            }
            catch (Exception e)
            {
                MessageBox.Show("No connection");
            }

        }

        private void btnGetRequest_Click(object sender, EventArgs e)
        {

            if (timerenable == false)
            {
                timer1.Start();
                timer1.Enabled = true;
                btnGetRequest.Text = "Disable";
                timerenable = true;
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                btnGetRequest.Text = "Enable";
                timerenable = false;
            }



        }

        private bool getrequest( byte port)
        {
            // Encode the connect message into a byte array.  
            byte[] msg = new byte[5];
            string Sendmsg = "";
            msg[0] = 0x05;
            msg[1] = 0x00;
            msg[2] = 0x02;
            msg[3] = 0x0a;
            msg[4] = port;

            try { 
            // Send the data through the socket.  
            int bytesSent = sendsocket.Send(msg);

            ResultContainer.Items.Add("Send message:");

            //Build Sendmsg to show 
            for (int index = 0; index < msg.Length; index++)
            {
                Sendmsg = Sendmsg + msg[index].ToString("X2");
            }
            ResultContainer.Items.Add(Sendmsg);
                return true;
            }
            catch(Exception e)
            {
                timer1.Stop();
                timer1.Enabled = false;
                btnGetRequest.Text = "Enable";
                timerenable = false;
                MessageBox.Show("No connection");
                return false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (getrequest(0x00))
                if (getrequest(0x02))
                    if (getrequest(0x04))
                        getrequest(0x06);
        }

        

        private void tbRequestTimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == 10 || e.KeyChar ==13)
            {
                int time = 0;
                Encoding ASCII = Encoding.ASCII;

                byte[] TimeBytes = ASCII.GetBytes(tbRequestTimer.Text);

                for (int index = 0; index < TimeBytes.Length; index++)
                {   
                    if ( 0x30<= TimeBytes[index] & TimeBytes[index] < 0x39)
                    {
                        time = time + (TimeBytes[index] - 0x30) * (int)Math.Pow(10, TimeBytes.Length-(double)index-1);
                    }
                    else
                    {
                        MessageBox.Show("Wrong input");
                        break;
                    }
                }

                timer1.Interval = time;
                e.Handled = true;
            }

            
        }
    }
}
