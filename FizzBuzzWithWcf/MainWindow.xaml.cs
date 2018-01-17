using FizzBuzzWithWcf.Host;
using System.Windows;

namespace FizzBuzzWithWcf
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

        private void Decrement_Click(object sender, RoutedEventArgs e)
        {
            var proxy = new CheckFizzBuzzClient();
            proxy.DecrementCounter();
            DezePlek.Content = proxy.GetFizzBuzzLabel();
            proxy.Close();

        }

        private void Increment_Click(object sender, RoutedEventArgs e)
        {
            var proxy = new CheckFizzBuzzClient();
            proxy.IncrementCounter();
            DezePlek.Content = proxy.GetFizzBuzzLabel();
            proxy.Close();
        }

        private void DataWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
    }
}
