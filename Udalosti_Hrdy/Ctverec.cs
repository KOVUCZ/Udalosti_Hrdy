using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

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
        public double Velikost { get; private set; }

    }
}
