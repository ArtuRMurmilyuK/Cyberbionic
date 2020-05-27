using System;
using System.Windows;
using System.Windows.Controls;


namespace Calculate_in_forms
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_Result(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void TextBox_Num2(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
        }

        private void TextBox_Num1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
        }

        private void RadioButton_Remainder(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Exponentiation(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Concatenation(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Division(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = Content.int(TextBox1.Text) / Content.int(TextBox2.Text);
        }
    }
}
