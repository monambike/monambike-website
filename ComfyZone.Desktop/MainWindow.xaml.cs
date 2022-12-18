using System.Windows;

namespace ComfyZone.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Youtube.CopyToClipboard();
        }
    }
}
