using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Globalization;
using System.IO;
using System.Numerics;

namespace L1
{
    public partial class Form1 : Form
    {
        RobotData Rdata = new RobotData();
        RobotMessage Rmess = new RobotMessage();
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Point> numbers = new Dictionary<int, Point>();
        Bitmap bitmap;
        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap=new Bitmap(pictureBox_map.Size.Width, pictureBox_map.Size.Height);
        }
        private void ShowUDPMessageMethod(string message)
        {
            PrintLog("Remote >" + message);
        }
        private void PrintLog(string s)
        {
            const int CMaxVisibleLogLines = 20;
            ReportListBox.Items.Add(s);
            while (ReportListBox.Items.Count > CMaxVisibleLogLines)
            {
                ReportListBox.Items.RemoveAt(0);
            }
            ReportListBox.SelectedIndex = ReportListBox.Items.Count - 1;
            ReportListBox.SelectedIndex = -1;
        }
        private void CheckStartStopUDPClient()
        {
            if (udpClient != null)
            {
                StartStopUDPClientButton.Text = "Stop";
                RemoteIPTextBox.Enabled = false;
                RemoteIPTextBox.BackColor = Color.LightGray;
                RemotePortTextBox.Enabled = false;
                RemotePortTextBox.BackColor = Color.LightGray;
                LocalIPTextBox.Enabled = false;
                LocalIPTextBox.BackColor = Color.LightGray;
                LocalPortTextBox.Enabled = false;
                LocalPortTextBox.BackColor = Color.LightGray;
            }
            else
            {
                StartStopUDPClientButton.Text = "Start";
                RemoteIPTextBox.Enabled = true;
                RemoteIPTextBox.BackColor = Color.White;
                RemotePortTextBox.Enabled = true;
                RemotePortTextBox.BackColor = Color.White;
                LocalIPTextBox.Enabled = true;
                LocalIPTextBox.BackColor = Color.White;
                LocalPortTextBox.Enabled = true;
                LocalPortTextBox.BackColor = Color.White;
            }
        }

        UdpClient udpClient;
        Thread thread;
        int localPort;
        private void StartUDPClient()
        {
            if (thread != null)
            {
                thread.Abort();
            }
            if (udpClient != null)
            {
                udpClient.Close();
            }

            localPort = Int32.Parse(LocalPortTextBox.Text);
            try
            {
                udpClient = new UdpClient(localPort);
                thread = new Thread(new ThreadStart(ReceiveUDPMessage));
                thread.IsBackground = true;
                thread.Start();
                PrintLog("UDPClient started");
            }
            catch
            {
                PrintLog("UDPClient's start failed");
            }
            CheckStartStopUDPClient();
        }
        private void StopUDPClient()
        {
            if ((thread != null) && (udpClient != null))
            {
                thread.Abort();
                udpClient.Close();
                thread = null;
                udpClient = null;
            }
            PrintLog("UDPClient stopped");
            CheckStartStopUDPClient();
        }
        private void ReceiveUDPMessage()
        {
            while (true)
            {
                try
                {
                    IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] content = udpClient.Receive(ref remoteIPEndPoint);
                    if (content.Length > 0)
                    {
                        string message = Encoding.ASCII.GetString(content);
                        this.Invoke(new MethodInvoker(() =>
                        {
                            try
                            {
                                Rdata = JsonSerializer.Deserialize<RobotData>(message);
                                PrintLog(message);
                                if (checkBox_AI.Checked)
                                {
                                    Trigger();
                                }                              
                                map();
                                EncoderMap();
                            }
                            catch
                            {
                                PrintLog("Incorrect message");
                            }
                        }));
                    }
                }
                catch
                {
                    string errmessage = "RemoteHost lost";
                    this.Invoke(new MethodInvoker(() =>
                    {
                            PrintLog(errmessage);
                    }));
                }
            }
        }
        private void SendUDPMessage()
        {
            if (udpClient != null)
            {
                Int32 port = Int32.Parse(RemotePortTextBox.Text);
                IPAddress ip = IPAddress.Parse(RemoteIPTextBox.Text.Trim());
                IPEndPoint ipEndPoint = new IPEndPoint(ip, port);
                string text = JsonSerializer.Serialize<RobotMessage>(Rmess);
                text += "\n";
                byte[] content = Encoding.ASCII.GetBytes(text);
                try
                {
                    int count = udpClient.Send(content, content.Length, ipEndPoint);
                    if (count > 0)
                    {
                        PrintLog("Sent message:" + text);
                    }
                }
                catch
                {
                    PrintLog("Error occurs.");
                }

            }
        }
        private void SendUDPMessageButton_Click(object sender, EventArgs e)
        {       
            SendUDPMessage();
            if (checkBox_N.Checked)
            {
                Rmess.N++;
                UpD();
            }
        }

        private void UDPRegularSenderTimer_Tick(object sender, EventArgs e)
        {
            SendUDPMessage();
        }

        private void pictureBox_control_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap control = new Bitmap(120, 120);
            Graphics g = Graphics.FromImage(control);
            Rectangle[] rectangles =
            {
                new Rectangle(-1,70,51,50),
                new Rectangle(70,70,50,50),
                new Rectangle(-1,-1,51,51),
                new Rectangle(70,-1,50,51),
            };
            g.DrawRectangles(new Pen(Color.Black, 1), rectangles);
            g.DrawLine(new Pen(Color.Red, 1), e.X, e.Y + 5, e.X, e.Y - 5);
            g.DrawLine(new Pen(Color.Red, 1), e.X + 5, e.Y, e.X - 5, e.Y);
            pictureBox_control.Image = control;
            if (e.X < 50)
            {
                Rmess.B = 50 - e.X;
            }
            else if (e.X > 70)
            {
                Rmess.B = 70 -e.X;
            }
            else { Rmess.B = 0; }
            if (e.Y < 50)
            {
                Rmess.F = 50 - e.Y;
            }
            else if (e.Y > 70)
            {
                Rmess.F = 70 - e.Y;
            }
            else { Rmess.F = 0; }
            Rmess.B = Rmess.B * 2;
            Rmess.F = Rmess.F * 2;
            Rmess.N++;
            UpD();
            SendUDPMessage();
        }

        private void StartStopUDPClientButton_Click(object sender, EventArgs e)
        {
            if (udpClient == null)
            {
                StartUDPClient();
            }
            else
            {
                StopUDPClient();
            }
        }
        public void UpD()
        {
            up_B.Value = Rmess.B;
            up_F.Value = Rmess.F;
            up_M.Value = Rmess.M;
            up_T.Value = Rmess.T;
            up_N.Value = Rmess.N;
        }

        public void Trigger()
        {

        }


        public (double x, double y, double theta) GetPose(double x, double y, double theta, double leftEncoder, double rightEncoder)
        {
            double dLeftEncoder = leftEncoder - prevLeftEncoder;
            double dRightEncoder = rightEncoder - prevRightEncoder;

            prevLeftEncoder = leftEncoder;
            prevRightEncoder = rightEncoder;
            // Вычисляем линейные и угловые приращения  
            double dx, dy, dTheta;
            (dx, dy, dTheta) = GetDeltaPose(dLeftEncoder, dRightEncoder);

            // Интегрируем для получения новой позиции
            double newX = x + dx;
            double newY = y + dy * Math.Cos(this.theta) - dx * Math.Sin(this.theta);
            double newTheta = theta + dTheta;

            // Возвращаем обновленную позицию 
            return (newX, newY, newTheta);
        }
        double WHEEL_DIAMETER = 0.1;
        double WHEEL_SEPARATION = 0.5;
        double prevLeftEncoder;
        double prevRightEncoder;
        public (double dx, double dy, double theta) GetDeltaPose(double leftEncoder, double rightEncoder)
        {

            // Расстояние пройденное левым и правым колесом 
            double leftDistance = leftEncoder * WHEEL_DIAMETER;
            double rightDistance = rightEncoder * WHEEL_DIAMETER;

            // Вычисляем среднее расстояние
            double distance = (leftDistance + rightDistance) / 2;

            // Вычисляем угол поворота
            double theta = (rightDistance - leftDistance) / WHEEL_SEPARATION;

            // Вычисляем приращения x и y 
            double dx = distance * Math.Cos(this.theta);
            double dy = distance * Math.Sin(this.theta);

            // Возвращаем координаты и угол
            return (dx, dy, theta);
        }
     
        double X = 0.75; double Y = 0.75;
        double theta = -Math.PI;
        void EncoderMap()
        {

            int mnozetel = 20;
            Bitmap Nbit = new Bitmap(bitmap.Width, bitmap.Height);
            Graphics g = Graphics.FromImage(Nbit);
            g.DrawImage(bitmap, 0, 0);
            double dx = Convert.ToDouble(Rdata.x, NumberFormatInfo.InvariantInfo);
            double dy = Convert.ToDouble(Rdata.y, NumberFormatInfo.InvariantInfo);
            int x = Convert.ToInt32(dx * mnozetel);
            int y = pictureBox_map.Size.Height - Convert.ToInt32(dy * mnozetel);
            theta = Math.PI/180*(double.Parse(Rdata.t.Replace('.',','))-90);         
            DrawCircleLine(theta,7, x, y,  g);
            pictureBox_map.Image = Nbit;

        }
        static void DrawCircleLine(double theta, int r, int xCenter, int yCenter, Graphics g)
        {
            int x = (int)(r * Math.Cos(theta));
            int y = (int)(r * Math.Sin(theta));
            g.DrawEllipse(Pens.Black, xCenter - r, yCenter - r, r * 2, r * 2);
            g.DrawLine(Pens.Black, xCenter, yCenter, xCenter + x, yCenter + y);
        }

        void map()
        {
            int mnozetel = 20;
            Graphics g = Graphics.FromImage(bitmap);
            double dx = Convert.ToDouble(Rdata.x, NumberFormatInfo.InvariantInfo);
            double dy = Convert.ToDouble(Rdata.y, NumberFormatInfo.InvariantInfo);
            int x = Convert.ToInt32(dx* mnozetel);
            int y = Convert.ToInt32(dy * mnozetel);
            g.FillRectangle(Brushes.Red, x,pictureBox_map.Size.Height -y, 1, 1);
            label_X.Text = Rdata.x;
            label_Y.Text = Rdata.y;
            theta = Math.PI / 180 * (double.Parse(Rdata.t.Replace('.', ',')) - 90);
            label_dtheta.Text = theta.ToString();
            //pictureBox_map.Image=bitmap;
            //pictureBox_map.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
        }   
        int shag = 0;
        private void checkBox_AI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AI.Checked&& numbers.Count!=0)
            {
                Rmess.B = 0;
                Rmess.F = 100;
                Rmess.N++;
                SendUDPMessage();
                target= numbers.Keys.Min();
                timer1.Start();
                shag = 0;
            }
            else
            {
                timer1.Stop();
            }
        }
        int target = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point point = new Point();            
            numbers.TryGetValue(target, out point);
            PointD tar = new PointD();
            tar.X = point.X * 0.25;
            tar.Y =10 -point.Y * 0.25;

            double dx = Convert.ToDouble(Rdata.x, NumberFormatInfo.InvariantInfo);
            double dy = Convert.ToDouble(Rdata.y, NumberFormatInfo.InvariantInfo);
            PointD robot = new PointD { X = dx, Y = dy };

            var angle = Geometry.GetAngle(tar, robot);
            //angle = ((angle + 720) % 360)-180;
            var dist = Geometry.GetDistance(tar, robot);
            double angleN = (double.Parse(Rdata.t.Replace('.', ',')));
            //angleN = ((angleN + 720) % 360)-180;
            double target_angle = angleN +angle;
            target_angle = ((target_angle + 720) % 360)-90;
            label_angle.Text = target_angle.ToString();
            label_dist.Text = dist.ToString();
            label_target.Text = target.ToString();

            if (dist < 0.75) {
                target++;
                if (target == numbers.Keys.Max())
                {
                    ReportListBox.Items.Add("Финиш");
                    label_target.Text = "Финиш";
                    checkBox_AI.Checked = false;
                }
            }

            int AZ = 0;
            if (target_angle < 180) { AZ = 1; }
            if (target_angle > 180) { AZ = -1; }
            Rmess.B = 50 * AZ;
            Rmess.F = 100;
            Rmess.N++;
            int W = check_Way();
            if (W != 0)
            {
                Rmess.B = 75 * W;
            }
            SendUDPMessage();
            ReportListBox.Items.Add(Rmess);
        }


        public int check_Way()
        {
            int k = (int.Parse(Rdata.d1) + int.Parse(Rdata.d2))
                - (int.Parse(Rdata.d4) + int.Parse(Rdata.d4));
            if (k > 0) k = -1; else k = 1;
            if (Rdata.d0.ToInt() > 45 &&
                Rdata.d1.ToInt() > 50 && Rdata.d2.ToInt() > 75 &&
                Rdata.d3.ToInt() > 75 &&
                Rdata.d5.ToInt() > 50 && Rdata.d4.ToInt() > 75 &&
                Rdata.d6.ToInt() > 45)
            {
                k = 0;
            }
            return k;
        }
        private void up_N_ValueChanged(object sender, EventArgs e)
        {
            Rmess.N = (int)up_N.Value;
        }

        private void up_M_ValueChanged(object sender, EventArgs e)
        {
            Rmess.M = (int)up_M.Value;
        }

        private void up_F_ValueChanged(object sender, EventArgs e)
        {
            Rmess.F = (int)up_F.Value;
        }

        private void up_B_ValueChanged(object sender, EventArgs e)
        {
            Rmess.B = (int)up_B.Value;
        }

        private void up_T_ValueChanged(object sender, EventArgs e)
        {
            Rmess.T = (int)up_T.Value;
        }


        private void pictureBox_map_Click_1(object sender, EventArgs e)
        {
            string[] data;
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFileDialog1.FilterIndex = 2;
            OpenFileDialog1.RestoreDirectory = true;
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sw = new StreamReader(OpenFileDialog1.FileName, false))
                {
                    data = sw.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    int s = 2;
                }
                Graphics g = Graphics.FromImage(bitmap);
                g.Clear(Color.White);
                Random rnd = new Random();
                int size = 5;
                numbers.Clear();
                for (int i = 0; i < data.Length; i++)
                {
                    string line = data[i];

                    for (int j = 0; j < line.Length; j++)
                    {
                        char c = line[j];
                        if (char.IsDigit(c))
                        {
                            g.FillRectangle(Brushes.Orange, j * size, i * size, size, size);

                            Point coord = new Point(j, i);
                            numbers.Add((c - '0'), coord);
                        }
                        else if (c == '#')
                        {
                            g.FillRectangle(Brushes.Gray, j * size, i * size, size, size);
                        }
                        else if (c == '.')
                        {
                            // не рисовать
                        }
                        else
                        {
                            Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                            g.FillRectangle(new SolidBrush(color), j * size, i * size, size, size);
                        }
                    }
                }
                pictureBox_map.Image = bitmap;
                listBox1.Items.Clear();
                var sortedNumbers = from entry in numbers orderby entry.Key ascending select entry;
                foreach (KeyValuePair<int, Point> pair in sortedNumbers)
                {
                    listBox1.Items.Add($"{pair.Key} = {pair.Value}");

                }
            }
        }

        private void UDPRegularSenderTimer_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
