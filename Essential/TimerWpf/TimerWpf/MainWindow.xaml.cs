using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TimerWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Presenter timer;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler StartEvent = null;
        public event EventHandler StopEvent = null;
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartEvent.Invoke(sender,e);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            StopEvent.Invoke(sender,e);
        }
    }
}
