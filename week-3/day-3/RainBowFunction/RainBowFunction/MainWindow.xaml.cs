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

namespace RainBowFunction
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

            Random r = new Random();

            for (int size = 150; size > 0; size -= 10)
            {
                RainBowFunction(size, (Color.FromArgb((byte)r.Next(256), (byte)r.Next(256), (byte)r.Next(256), (byte)r.Next(256))), foxDraw);               
            }
        }       

        public void RainBowFunction(int size, Color randomColor, FoxDraw foxDraw)
        {
            foxDraw.FillColor(randomColor);
            foxDraw.DrawRectangle((canvas.Width - size)/2, (canvas.Height - size)/2, size, size);
        }
    }
}
