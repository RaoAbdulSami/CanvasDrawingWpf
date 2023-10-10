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
using System.Windows.Shapes;

namespace canvasDrawing.Gui
{
    /// <summary>
    /// Interaction logic for ActualWindow.xaml
    /// </summary>
    public partial class ActualWindow : UserControl
    {
        public Dictionary<string, UpdatableShape> shapesList = new Dictionary<string, UpdatableShape>();
        ParamWind paramWind;

        public ActualWindow()
        { 
            InitializeComponent();

            ButtonsPanel btnPanel = new ButtonsPanel();
            paramWind = new ParamWind(canvas);
            shapesList.Add("Rectangle", new Rectangle { name = "Rectangle" });
            shapesList.Add("Circle", new Circle { name = "Circle" });


            btnPanel = new ButtonsPanel();
            btnPanel.addButton("Circle");
            btnPanel.addButton("Rectangle");
            leftPanel.Children.Add(btnPanel);
            rightPanel.Children.Add(paramWind);

            btnPanel.buttonClickEvent += BtnPanel_buttonClickEvent;
        }

        private void BtnPanel_buttonClickEvent(object sender, string buttonName)
        {
            paramWind.drawWindowFor(shapesList[buttonName]);
        }

    } 
}


