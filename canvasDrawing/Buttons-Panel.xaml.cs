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
    /// Interaction logic for Buttons_Panel.xaml
    /// </summary>
    public partial class ButtonsPanel : UserControl
    {
        public ButtonsPanel()
        {
            InitializeComponent();

        }

        Button btn;
        public void getListofButtons( List<string> buttonNames)
        {
            foreach (string btnName in buttonNames)
            {
                btn = new Button();
                btn.Content = btnName;
                btn.Name = btnName;
                btn.Click += (sender,args)=>buttonClick(sender,btnName);
                ShapesSelectPanel.Children.Add(btn);
            }
        }


        private void buttonClick(object sender,string name)
        {

        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
             

        }
    }
}
