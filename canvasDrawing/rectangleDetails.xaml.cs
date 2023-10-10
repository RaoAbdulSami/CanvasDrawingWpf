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
    /// Interaction logic for rectangleDetails.xaml
    /// </summary>
    public partial class rectangleDetails : UserControl 
    {

        //public event EventHandler<ShapeEventArgs> RectangleDrawn;

        //protected void OnRectangleDrawn(double length, double width)
        //{
        //    RectangleDrawn?.Invoke(this, new ShapeEventArgs(length, width));
        //}

        Canvas canv;
        public rectangleDetails(Canvas canvas )
        {
            InitializeComponent();
            canv = canvas;
        }
       
        private void showRectangle(object sender, RoutedEventArgs e)
        {
            double rectwidth = double.Parse(width.Text);
            double height = double.Parse(length.Text);
/*            Rectangle rect = new Rectangle()
            {
                Width = rectwidth,
                Height = height, 
                Fill = Brushes.Red
            };


            canv.Children.Add(rect);*/
        }



    }
}
