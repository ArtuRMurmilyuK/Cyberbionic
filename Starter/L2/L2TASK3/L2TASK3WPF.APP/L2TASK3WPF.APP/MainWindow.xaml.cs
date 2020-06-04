
using System.Windows;


namespace L2TASK3WPF.APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_byte(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("from 0 to 255");
        }

        private void Button_sbyte(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("from -128 to +127");
        }

        private void Button_short(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("from -32768 to +32767");
        }

        private void Button_ushort(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("from 0 to 65535");
        }

        private void Button_int(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("from -2147483648 to +2147483647");
        }

        private void Button_uint(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("from 0 to 4294967295");
        }

        private void Button_long(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("from -9223372036854775808 to +9223372036854775807");
        }

        private void Button_ulong(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("from 0 to 18446744073709551615");
        }
    }
}
