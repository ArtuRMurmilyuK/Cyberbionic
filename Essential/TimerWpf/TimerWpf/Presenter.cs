using System.Windows.Controls;

namespace TimerWpf
{
    public class Presenter
    {
        private Timer timer;
        private MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.timer = new Timer();
            this.mainWindow.StartEvent += MainWindowStartEvent;
            this.mainWindow.StopEvent += MainWindowStopEvent;
        }

        private void MainWindowStopEvent(object? sender, System.EventArgs e)
        {
            timer.TimerStop();
        }

        private void MainWindowStartEvent(object? sender, System.EventArgs e)
        {
            timer.TimerStart();
            this.mainWindow.TextBox1.Text = this.timer.TimerShow();
        }
    }
}