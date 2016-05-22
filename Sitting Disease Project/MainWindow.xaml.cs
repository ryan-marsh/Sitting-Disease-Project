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
using System.Windows.Interop;

namespace Sitting_Disease_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            introText.Text = "Welcome to the sitting disease application!\n\nClick on the green tray icon to test week 1 functionality.\nLeft-clicking will show the timed popup. Right-clicking will show program options.\nNOTE: You must right-click the tray icon to exit. This window can be closed and re-opened.";
        }
    }
}
