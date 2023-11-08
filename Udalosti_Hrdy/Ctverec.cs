using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;

namespace Udalosti_Hrdy
{
    public class Ctverec
    {
        private List<Brush> barvy = new List<Brush>()
        {
            Brushes.Red,
            Brushes.Green,
            Brushes.Blue,
            Brushes.Magenta,
            Brushes.Yellow,
            Brushes.Orange,
            Brushes.Orchid,
        };


        private int vybranaBarva = 0;
        private DispatcherTimer timer;
        private Random random = new Random();
        
        public double Velikost { get; private set; }
        public Brush Barva { get => barvy[vybranaBarva]; }
        
        
        public Ctverec(double velikost)
        {
            Velikost = velikost;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, random.Next(1, 6));
        }

    }
}
