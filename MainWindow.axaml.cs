using Avalonia.Controls;
using System;

namespace AvaloniaIssue16451
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, true, true);
        }
    }
}