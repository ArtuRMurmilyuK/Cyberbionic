using System;
using System.Windows.Threading;

namespace TimerWpf
{
    public class Timer
    {
        private DispatcherTimer _timer;
        private int x;

        public Timer()
        {
            _timer = new DispatcherTimer();
        }
        public void TimerStart()
        {
            _timer.Tick += new EventHandler(timerTick);
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Start();
        }

        public void TimerStop()
        {
            x = 0;
            _timer.Stop();
        }

        private void timerTick(object? sender, EventArgs e)
        {
            x++;
        }

        public string TimerShow()
        {
            return x.ToString();
        }
    }
}