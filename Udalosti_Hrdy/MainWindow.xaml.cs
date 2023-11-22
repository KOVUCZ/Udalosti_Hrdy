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

namespace Udalosti_Hrdy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        List<Ctverec> ctverce = new List<Ctverec>();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void GenerujCtverce(int pocet)
        {
            ctverce.Clear();
            for (int i = 0; i < pocet; i++)
            {
                Ctverec ctverec = new Ctverec(random.Next(30,70));
                var x = random.NextDouble() * (Platno.ActualWidth - ctverec.Velikost);
                var y = random.NextDouble() * (Platno.ActualHeight - ctverec.Velikost);
                ctverec.Umisteni = new Point(x, y);
                ctverce.Add(ctverec);
                ctverec.BarvaZmenena += Ctverec_BarvaZmenena;

            }
        }

        private void Ctverec_BarvaZmenena()
        {
            NaklesliCtverce();
        }

        public void NaklesliCtverce() 
        {
            Platno.Children.Clear();
            foreach(Ctverec ctverec in ctverce)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Width = ctverec.Velikost;
                rectangle.Height = ctverec.Velikost;
                rectangle.Fill = ctverec.Barva;
                rectangle.Stroke = Brushes.Black;
                rectangle.StrokeThickness = 3;
                Canvas.SetLeft(rectangle, ctverec.Umisteni.X);
                Canvas.SetTop(rectangle, ctverec.Umisteni.Y);
                Platno.Children.Add(rectangle);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GenerujCtverce(20);
            NaklesliCtverce();
        }


    }
}
