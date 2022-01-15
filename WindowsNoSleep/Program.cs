using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MouseMoveTimer
{
    class Program
    {
        [DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_MOVE = 0x0001;
        static void Main(string[] args)
        {
            // 1. 输入鼠标定时移动的时间间隔（秒）
            Console.WriteLine("Input the Timer Interval by second: ");
            string timerInterval = Console.ReadLine();

            // 2. 定义定时器
            int TimerInterval;
            if (Int32.TryParse(timerInterval, out TimerInterval))
            {
                Timer timer = new System.Timers.Timer(); // 定义定时器
                timer.Enabled = true; // 启用定时器
                timer.Interval = 1000 * TimerInterval; // 设定时间间隔（毫秒：1秒 = 1000毫秒）

                timer.Elapsed += new ElapsedEventHandler(MoveMouseHandler); // 等到间隔时间到，执行
            }
            else
            {
                Console.WriteLine("Error: Please input a number!");
            }

            // 3. 保持程序不退出
            Console.ReadKey();
        }

        /// <summary>
        /// 定时器方法体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected static void MoveMouseHandler(object sender, System.Timers.ElapsedEventArgs e)
        {
            // 将鼠标移动一个像素
            mouse_event(MOUSEEVENTF_MOVE, 1, 1, 0, 0); 
        }
    }
}
