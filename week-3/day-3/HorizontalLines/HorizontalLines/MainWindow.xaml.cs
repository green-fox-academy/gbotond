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

namespace HorizontalLines
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

            DrawLine(50, 75);
            DrawLine(50, 150);
            DrawLine(50, 225);

            void DrawLine(int x, int y)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(new Point(x, y), new Point(x + 50, y));
            }
        }
    }
}
