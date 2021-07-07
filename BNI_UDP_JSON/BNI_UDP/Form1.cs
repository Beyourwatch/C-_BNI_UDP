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
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;



namespace BNI_UDP
{
    public partial class Form1 : Form
    {

        Socket sendsocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);//定义一个Socket

        Thread listenThread ;
        Thread displayThread;

        public int commandTimeOut = 5;

        int sleeptime=500;

        string url;
        string ipaddr;
        JObject _data = new JObject();
        HttpWebRequest request;
        byte[] bytes;

        bool dataready = false;

        int port = 0;
        int datasizeport1 = 4;
        int datasizeport2 = 4;
        int datasizeport3 = 4;
        int datasizeport4 = 4;

        BNIData _DATA;
        string port1Processdata = "";
        string port2Processdata = "";
        string port3Processdata = "";
        string port4Processdata = "";

        bool startRead = false;
        bool port1Enable = false;
        bool port2Enable = false;
        bool port3Enable = false;
        bool port4Enable = false;
        bool bconnected = false;

        public Form1()
        {
            InitializeComponent();
            cbPort.Text = cbPort.Items[0].ToString();
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

                    ipaddr = single_ipaddress.Text;
                    url = "http://" + ipaddr + "/ports.jsn";

                    bytes = Encoding.UTF8.GetBytes(_data.ToString());       //json

                    

                }
                catch (Exception ex) // Catch and show any other Exceptions
                {
                    //single_connection.BackColor = SystemColors.Control;
                    //single_connection.Text = "Connect";
                    //bconnected = false;
                    //MessageBox.Show("local Connection failed, if you disconnected, please restart");
                    
                }
            }
            else
            {
                listenThread.Abort();
                displayThread.Abort();
                sendsocket.Shutdown(SocketShutdown.Both);
                //sendsocket.Close();

                single_connection.BackColor = SystemColors.Control;
                single_connection.Text = "Connect";
                bconnected = false;
            }


        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                listenThread.Abort();
                displayThread.Abort();
                sendsocket.Shutdown(SocketShutdown.Both);
                sendsocket.Close();
                Application.Exit();
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

            //ResultContainer.Items.Add("Send message:");

            //Build Sendmsg to show 
            for (int index = 0; index < msg.Length; index++)
            {
                Sendmsg = Sendmsg + msg[index].ToString("X2");
            }
            //ResultContainer.Items.Add(Sendmsg);

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

                //ResultContainer.Items.Add("Send message:");

                //Build Sendmsg to show 
                for (int index = 0; index < msg.Length; index++)
                {
                    Sendmsg = Sendmsg + msg[index].ToString("X2");
                }
                //ResultContainer.Items.Add(Sendmsg);

            }
            catch (Exception e)
            {
                MessageBox.Show("No connection");
            }

        }

        private void btnGetRequest_Click(object sender, EventArgs e)
        {

            if ( startRead  == false)
            {
                
                btnGetRequest.Text = "Disable";
                startRead = true;

                listenThread = new Thread(postCall);
                listenThread.Start();

                displayThread = new Thread(display);
                displayThread.Start();

            }
            else
            {
                startRead = false;
                btnGetRequest.Text = "Enable";
                dataready = false;

                listenThread.Abort();
                displayThread.Abort();
            }
        }


        private void postCall()
        {
            string responseText = string.Empty;
            DateTime datenow;
            DateTime dateend;
            double miliseconds;
            while (true) {
            
                if (startRead) {
                    datenow = DateTime.Now;
                  
                    try
                     {
                        request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "POST";
                        request.ContentType = "application/json";   //json
                        request.Timeout = commandTimeOut * 1000;
                        request.ContentLength = bytes.Length;

                        using (Stream reqStream = request.GetRequestStream())
                         {
                           reqStream.Write(bytes, 0, bytes.Length);
                           reqStream.Close();
                          }


                          using (WebResponse resp = request.GetResponse())
                            {
                             Stream respStream = resp.GetResponseStream();
                             using (StreamReader sr = new StreamReader(respStream))
                            {
                                 responseText = sr.ReadToEnd();
                                 sr.Close();
                             }

                     }

                      

                      _DATA = JsonConvert.DeserializeObject<BNIData>(responseText);

                        port1Processdata = _DATA.PORTS[0].PROCESSINPUTS.Replace(" ", "").Remove(datasizeport1);
                        port2Processdata = _DATA.PORTS[2].PROCESSINPUTS.Replace(" ", "").Remove(datasizeport2);
                        port3Processdata = _DATA.PORTS[4].PROCESSINPUTS.Replace(" ", "").Remove(datasizeport3);
                        port4Processdata = _DATA.PORTS[6].PROCESSINPUTS.Replace(" ", "").Remove(datasizeport4);

                        dataready = true;



                    }
            catch (System.Exception ex)
            {

              
            }

                    // ...
                     dateend = DateTime.Now;

                     miliseconds = (dateend - datenow).TotalMilliseconds;
                    // tbDataPort3.Text = miliseconds.ToString();
                     if (sleeptime > miliseconds)
                        Thread.Sleep(sleeptime- (int)miliseconds);
                   
                }
            }
        }

        private void display()
        {            
            while(true)
            {
                if (dataready)
                {
                     tbDataPort1.Text = port1Processdata;
                     tbDataPort2.Text = port2Processdata;
                     tbDataPort3.Text = port3Processdata;
                     tbDataPort4.Text = port4Processdata;
                     textBoxVendorName.Text = _DATA.PORTS[port].VENDORNAME;
                     textBoxVendorText.Text = _DATA.PORTS[port].VENDORTEXT;
                     textBoxSerialNumber.Text = _DATA.PORTS[port].SERIALNUMBER;
                     textBoxStatus.Text = _DATA.PORTS[port].STATUS;
                     textBoxProductText.Text = _DATA.PORTS[port].PRODUCTTEXT;
                     textBoxProductID.Text = _DATA.PORTS[port].PRODUCTID;
                     textBoxproductName.Text = _DATA.PORTS[port].PRODUCTNAME;
                     textBoxEvent.Text = _DATA.PORTS[port].EVENT;
                     textBoxEventFlag.Text = _DATA.PORTS[port].EVENTFLAG;
                     textBoxHWRevision.Text = _DATA.PORTS[port].HARDWAREREVISION;
                     textBoxFWRevision.Text = _DATA.PORTS[port].FIRMWAREREVISION;
                     textBoxPrcessInputs.Text = _DATA.PORTS[port].PROCESSINPUTS;
                     textBoxPrcessOutputs.Text = _DATA.PORTS[port].PROCESSOUTPUTS;
                     textBoxdsContentVendorID.Text = _DATA.PORTS[port].DSCONTENTVENDORID;
                     textBoxdsContentDeviceId.Text = _DATA.PORTS[port].DSCONTENTDEVICEID;
                     textBoxdsContentBuffer.Text = _DATA.PORTS[port].DSCONTENTBUFFER;
                     textBoxdsContentChecksum.Text = _DATA.PORTS[port].DSCONTENTCHECKSUM;
                     textBoxdirectparameters.Text = _DATA.PORTS[port].DIRECTPARAMETERS;
                     textBoxApplicationTag.Text = _DATA.PORTS[port].APPLICATIONSPECIFICTAG;
                     
                    Thread.Sleep(50);
            }
            }
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

                sleeptime = time;
                e.Handled = true;
            }

            
        }

        private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            port = cbPort.SelectedIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Encoding ASCII = Encoding.ASCII;
            datasizeport1 = 0;
            byte[] datasize = ASCII.GetBytes(textBox1.Text);

            for (int index = 0; index < datasize.Length; index++)
            {
                if (0x30 <= datasize[index] & datasize[index] < 0x39)
                {
                    datasizeport1 = datasizeport1 + (datasize[index] - 0x30) * (int)Math.Pow(10, datasize.Length - (double)index - 1);
                }
                else
                {
                    MessageBox.Show("Wrong input");
                    break;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Encoding ASCII = Encoding.ASCII;
            datasizeport2 = 0;
            byte[] datasize = ASCII.GetBytes(textBox2.Text);

            for (int index = 0; index < datasize.Length; index++)
            {
                if (0x30 <= datasize[index] & datasize[index] < 0x39)
                {
                    datasizeport2 = datasizeport2 + (datasize[index] - 0x30) * (int)Math.Pow(10, datasize.Length - (double)index - 1);
                }
                else
                {
                    MessageBox.Show("Wrong input");
                    break;
                }
            }
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Encoding ASCII = Encoding.ASCII;
            datasizeport3 = 0;
            byte[] datasize = ASCII.GetBytes(textBox3.Text);

            for (int index = 0; index < datasize.Length; index++)
            {
                if (0x30 <= datasize[index] & datasize[index] < 0x39)
                {
                    datasizeport3 = datasizeport3 + (datasize[index] - 0x30) * (int)Math.Pow(10, datasize.Length - (double)index - 1);
                }
                else
                {
                    MessageBox.Show("Wrong input");
                    break;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Encoding ASCII = Encoding.ASCII;
            datasizeport4 = 0;
            byte[] datasize = ASCII.GetBytes(textBox4.Text);

            for (int index = 0; index < datasize.Length; index++)
            {
                if (0x30 <= datasize[index] & datasize[index] < 0x39)
                {
                    datasizeport4 = datasizeport4 + (datasize[index] - 0x30) * (int)Math.Pow(10, datasize.Length - (double)index - 1);
                }
                else
                {
                    MessageBox.Show("Wrong input");
                    break;
                }
            }
            
        }
    }


    public class Interface
    {
        public string VERSION { get; set; }
        public string DESCRIPTION { get; set; }
    }

    public class Ports
    {
        public string VENDORNAME { get; set; }
        public string VENDORTEXT { get; set; }
        public string PRODUCTNAME { get; set; }
        public string PRODUCTID { get; set; }
        public string PRODUCTTEXT { get; set; }
        public string SERIALNUMBER { get; set; }
        public string HARDWAREREVISION { get; set; }
        public string FIRMWAREREVISION { get; set; }
        public string APPLICATIONSPECIFICTAG { get; set; }
        public string EVENT { get; set; }
        public string EVENTFLAG { get; set; }
        public string PROCESSINPUTS { get; set; }
        public string PROCESSOUTPUTS { get; set; }
        public string DIRECTPARAMETERS { get; set; }
        public string STATUS { get; set; }
        public string DSCONTENTVENDORID { get; set; }
        public string DSCONTENTDEVICEID { get; set; }
        public string DSCONTENTCHECKSUM  { get; set; }
        public string DSCONTENTBUFFER { get; set; }

    }

    public class BNIData
    {
        public Interface INTERFACE { get; set; }
        public List<Ports> PORTS { get; set; }

    }
}
