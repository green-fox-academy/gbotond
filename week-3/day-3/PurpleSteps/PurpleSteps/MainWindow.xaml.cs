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

namespace PurpleSteps
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

            int x = 0;
            int y = 0;

            for (int i = 0; i < 20; i++)
            {
                Drawing(x, y, foxDraw);
                x += 10;
                y += 10;
            }
        }

        public void Drawing(int x, int y, FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Color.FromRgb(102, 92, 111));
            foxDraw.FillColor(Color.FromRgb(177, 70, 244));
            foxDraw.DrawRectangle(x, y, 10, 10);
        }
    }
}
