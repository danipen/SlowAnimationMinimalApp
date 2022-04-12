using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Styling;

using System;

namespace SlowAnimationMinimalApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var openButton = this.FindControl<Button>("mOpenButton");
            openButton.Click += Button_Click;

            var closeButton = this.FindControl<Button>("mCloseButton");
            closeButton.Click += CloseButton_Click;
        }

        private void CloseButton_Click(object? sender, RoutedEventArgs e)
        {
            var dialogHost = this.FindControl<DialogHost.DialogHost>("mDialogHost");
            dialogHost.IsOpen = false;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Handled)
                return;

            if (e.Key == Avalonia.Input.Key.Escape)
            {
                var dialogHost = this.FindControl<DialogHost.DialogHost>("mDialogHost");
                dialogHost.IsOpen = false;
            }
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);
        }

        void Button_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var dialogHost = this.FindControl<DialogHost.DialogHost>("mDialogHost");
            dialogHost.IsOpen = true;
        }
    }
}
