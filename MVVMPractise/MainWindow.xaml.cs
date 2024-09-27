using MVVMPractise.ViewModal;
using System.Windows;

namespace MVVMPractise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModal vm = new MainWindowViewModal();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}