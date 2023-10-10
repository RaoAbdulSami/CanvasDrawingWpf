using canvasDrawing.Gui;
using System.Collections.Generic;
using System.Windows;

namespace canvasDrawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ParamWind paramWind;

        //ButtonsPanel btnPanel;

        //public Dictionary<string, UpdatableShape> shapesList = new Dictionary<string, UpdatableShape>();
        public MainWindow()
        {
            InitializeComponent();
            ActualWindow actualWindow = new ActualWindow();
            mainGrid.Children.Add(actualWindow);
            //paramWind = new ParamWind(canvas);

            //shapesList.Add("Rectangle", new Rectangle { name = "Rectangle" });
            //shapesList.Add("Circle", new Circle { name = "Circle" });


            //btnPanel = new ButtonsPanel();
            //btnPanel.addButton("Circle");
            //btnPanel.addButton("Rectangle");
            //drawShapesPanel.Children.Add(btnPanel);


            //btnPanel.buttonClickEvent += BtnPanel_buttonClickEvent;
            //foreach(UpdatableShape upshae in shape.shapes)
            //{
            //    btn = new Button();
            //    btn.Content = upshae.name;
            //    btn.Name = upshae.name;
            //    btn.Click += Btn_Click;
            //    drawShapesPanel.Children.Add(btn);
            //}
        }

        //private void BtnPanel_buttonClickEvent(object sender, string buttonName)
        //{
        //    paramWind.drawWindowFor(shapesList[buttonName]);
        //    CntCtrl.Content = paramWind;
        //}

        //private void Btn_Click(object sender, RoutedEventArgs e)
        //{
        //    shape.drawWindowFor(((Control)sender).Name);

        //}

        //private void ShowRectangle(object sender, RoutedEventArgs e)
        //{

        //    shape.drawWindowFor("Rectangle");
        //    CntCtrl.Content = shape;


        //}







        //private void ShowCircle(object sender, RoutedEventArgs e)
        //{

        //    shape.drawWindowFor("Circle");

        //    CntCtrl.Content = shape;
        //}



    }
}
