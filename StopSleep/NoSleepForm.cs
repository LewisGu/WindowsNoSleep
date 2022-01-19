using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StopSleep
{
    public partial class NoSleepForm : Form
    {
        [DllImport("user32")]

        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private static string local_dir = Environment.CurrentDirectory;

        private const int MOUSEEVENTF_MOVE = 0x0001;

        private int cycle = 30;

        int count = 0;

        int SH = Screen.PrimaryScreen.Bounds.Height;

        int SW = Screen.PrimaryScreen.Bounds.Width;  

        public NoSleepForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.cycle_tb.Text, out this.cycle))
            {
                return;
            }
            else
            {
                this.cycle = 30;
            }
        }

        private void s_label_Click(object sender, EventArgs e)
        {
            return;       
        }

        public byte[] GetFileBytes(string Filename)
        {
            if (Filename == "")
                return null;
            try
            {
                FileStream fileStream = new FileStream(Filename, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);

                byte[] fileBytes = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();

                return fileBytes;
            }
            catch
            {
                return null;
            }
        }

        private void ChangeStatusPicAs(string PicName)
        {
            byte[] picbinary = GetFileBytes(PicName);                   //第一步：打开图片文件，获得比特流
            if (picbinary != null)
            {
                MemoryStream mempicstream = new MemoryStream(picbinary);    //第二步：将比特流还存在内存工作流中
                this.status_pb.Image = Image.FromStream(mempicstream);      //第三步：加载内存流到图片控件
            }
            else
            {
                Console.WriteLine("Pic Open Error");
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            setTimerCycle();
                     
            Console.WriteLine("Timer Ready to Start");
            nosleep_timer.Start();
            Console.WriteLine("Timer Alredy Start");
            ChangeStatusPicAs("Run.GIF");   
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Timer Ready to Stop");
            nosleep_timer.Stop();
            Console.WriteLine("Timer Alredy Stop");
            ChangeStatusPicAs("Stop.GIF");
        }

        private void setTimerCycle()
        {
            this.cycle = Convert.ToInt32(this.cycle_tb.Text);
            this.cycle = Int32.Parse(this.cycle_tb.Text);
            bool result = Int32.TryParse(this.cycle_tb.Text, out this.cycle);
            if ( !Int32.TryParse(this.cycle_tb.Text, out this.cycle) )
            {
                this.cycle = 30;
                this.cycle_tb.Text = this.cycle.ToString();
            }
            Console.WriteLine("The cycle time is {0:G}",this.cycle);
        }

        // TODO 待完善鼠标随机运动算法
        private void move_algorithm(int x, int y)
        {
            mouse_event(MOUSEEVENTF_MOVE, 1, 1, 0, 0);
        }

        private void nosleep_timer_Tick(object sender, EventArgs e)
        {
            int x_label = 1, y_label = 1;
#if CONDITIONA
            Point p = e.Location;
            int x_label = p.X;
            int y_label = p.Y;
#endif      
            move_algorithm(x_label, y_label);
            string head = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:ffff");
            string end = " mouse walk!";
            Console.WriteLine(head + end);
            Thread.Sleep(1000 * this.cycle);
            count++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Program Start");
            ChangeStatusPicAs("Start.GIF");
        }
    }
}
