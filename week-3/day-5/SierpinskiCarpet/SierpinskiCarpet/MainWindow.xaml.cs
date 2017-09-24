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

namespace SierpinskiCarpet
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

            DrawSquare(foxDraw, canvas, 0, 0, 100, 6);
        }
        public void DrawSquare(FoxDraw foxDraw, Canvas canvas, double x, double y, double size, double depth)
        {
            foxDraw.FillColor(Colors.Black);
            foxDraw.DrawRectangle(x + size, y + size, size, size);

            if (depth > 1)
            {
                DrawSquare(foxDraw, canvas, x, y, size / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x + size, y, size / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x + size * 2, y, size / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x, y + size, size / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x + size, y + size * 2, size / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x, y + size * 2, size / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x + size * 2, y + size * 2, size / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x + size * 2, y + size, size / 3, depth - 1);
            }
        }       
    }
}
