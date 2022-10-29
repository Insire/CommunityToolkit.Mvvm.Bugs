using System.Windows;

namespace WpfApp3
{
    public partial class MaterialWindowStyle : ResourceDictionary
    {
        public MaterialWindowStyle()
        {
            InitializeComponent();
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            if (sender is not FrameworkElement frameworkElement)
            {
                return;
            }

            if (frameworkElement.TemplatedParent is not Window window)
            {
                return;
            }

            window.Close();
        }

        private void MaximizeRestoreClick(object sender, RoutedEventArgs e)
        {
            if (sender is not FrameworkElement frameworkElement)
            {
                return;
            }

            if (frameworkElement.TemplatedParent is not Window window)
            {
                return;
            }

            if (window.WindowState == System.Windows.WindowState.Normal)
            {
                window.WindowState = System.Windows.WindowState.Maximized;
            }
            else
            {
                window.WindowState = System.Windows.WindowState.Normal;
            }
        }

        private void MinimizeClick(object sender, RoutedEventArgs e)
        {
            if (sender is not FrameworkElement frameworkElement)
            {
                return;
            }

            if (frameworkElement.TemplatedParent is not Window window)
            {
                return;
            }

            window.WindowState = System.Windows.WindowState.Minimized;
        }
    }
}
