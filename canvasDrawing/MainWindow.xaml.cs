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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ParamWind shape;
        Button btn;
        Buttons_Panel
        public MainWindow()
        {
            InitializeComponent();

            shape = new ParamWind(canvas);

            foreach(UpdatableShape upshae in shape.shapes)
            {
                btn = new Button();
                btn.Content = upshae.name;
                btn.Name = upshae.name;
                btn.Click += Btn_Click;
                drawShapesPanel.Children.Add(btn);
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            shape.drawWindowFor(((Control)sender).Name);
            CntCtrl.Content = shape;

        }

        private void ShowRectangle(object sender, RoutedEventArgs e)
        {

            shape.drawWindowFor("Rectangle");
            CntCtrl.Content = shape;


        }

       


        


        private void ShowCircle(object sender, RoutedEventArgs e)
        {
         
            shape.drawWindowFor("Circle");

            CntCtrl.Content = shape;
        }

       
       
    }
}
