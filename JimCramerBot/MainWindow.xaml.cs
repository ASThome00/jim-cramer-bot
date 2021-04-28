using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JimCramerBot
{
    /// <summary>
    /// Interaction logic for JimCramerBot.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void xJimCramerBot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch (InvalidOperationException) { }
        }

        private void xCloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void xMinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void xResizeButton_Click(object sender, RoutedEventArgs e)
        {
            if(xResizeButton.Content.ToString() == "1")
            {
                this.WindowState = WindowState.Maximized;
                xResizeButton.Content = "2";
            }
            else
            {
                this.WindowState = WindowState.Normal;
                xResizeButton.Content = "1";
            }

        }
    }
}
