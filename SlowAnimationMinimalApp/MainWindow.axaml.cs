using Avalonia.Controls;

namespace SlowAnimationMinimalApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var button = this.FindControl<Button>("mOpenButton");
            button.Click += Button_Click;
        }

        void Button_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var dialogHost = this.FindControl<DialogHost.DialogHost>("mDialogHost");
            dialogHost.IsOpen = true;
        }
    }
}
