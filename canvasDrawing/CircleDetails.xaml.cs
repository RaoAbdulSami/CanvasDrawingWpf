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

namespace canvasDrawing
{
    /// <summary>
    /// Interaction logic for CircleDetails.xaml
    /// </summary>
    public partial class CircleDetails : UserControl
    {
        Canvas canv;
        public CircleDetails(Canvas canvas)
        {
            InitializeComponent();
            canv = canvas;
        }
        

        private void showCircle(object sender, RoutedEventArgs e)
        {
            double circleRadius = double.Parse(radius.Text);

            

            Ellipse ellipse = new Ellipse
            {
                Height = circleRadius,
                Width = circleRadius,
                Fill = Brushes.Indigo
            };

            canv.Children.Add(ellipse);
        }
    }
}
