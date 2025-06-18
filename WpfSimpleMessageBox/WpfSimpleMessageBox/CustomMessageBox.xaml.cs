using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfSimpleMessageBox
{
    /// <summary>
    /// CustomMessageBox.xaml 的交互逻辑
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        public string Message { get; set; }
        public string TitleText { get; set; }
        public string ConfirmText { get; set; } = "OK";
        public string CancelText { get; set; } = "";
        public bool ShowCancel => !string.IsNullOrEmpty(CancelText);
        public Visibility CancelVisibility => ShowCancel ? Visibility.Visible : Visibility.Collapsed;
        public ImageSource IconSource { get; set; }
        public bool? ResultValue { get; private set; }

        public CustomMessageBox(string title, string message, string confirm = "OK", string cancel = "", string? iconPath = null)
        {
            InitializeComponent();

            TitleText = title;
            Message = message;
            ConfirmText = confirm;
            CancelText = cancel;

            if (!string.IsNullOrEmpty(iconPath))
            {
                IconSource = new BitmapImage(new System.Uri(iconPath, System.UriKind.RelativeOrAbsolute));
            }

            DataContext = this;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            ResultValue = null;
            Close();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            ResultValue = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            ResultValue = false;
            Close();
        }

        public static bool? Show(string title, string message, string confirm = "OK", string cancel = "", string? iconPath = null, Window? owner = null)
        {
            var box = new CustomMessageBox(title, message, confirm, cancel, iconPath)
            {
                Owner = owner ?? Application.Current.MainWindow
            };
            box.ShowDialog();
            return box.ResultValue;
        }
    }
}
