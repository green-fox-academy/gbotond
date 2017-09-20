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

namespace PositionSquare
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

            DrawSquare(50, 50, foxDraw);
            DrawSquare(100, 100, foxDraw);
            DrawSquare(150, 150, foxDraw);
        }

        void DrawSquare(int x, int y, FoxDraw foxDraw)
        {
            foxDraw.DrawRectangle(x, y, 50, 50);
        }
    }
}
