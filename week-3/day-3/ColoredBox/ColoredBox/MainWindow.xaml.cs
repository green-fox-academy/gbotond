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
using GreenFox;

namespace ColoredBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.BackgroundColor(Colors.White);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(75, 75, 225, 75);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(225, 75, 225, 225);
            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(225, 225, 75, 225);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(75, 225, 75, 75);
        }
    }
}
