using System.Windows;

namespace WpfSimpleMessageBox.Test
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

        private void ShowCustomMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog.ShowSuccess("这是一个ShowSuccess");
        }

        private void ShowWarningMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog.ShowInfo("这是一个ShowInfo");
        }

        private void ShowErrorMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog.ShowError("这是一个Error");
        }

        private void ShowConfirmMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog.ShowConfirm("确定要删除该条记录吗？");
        }
    }
}