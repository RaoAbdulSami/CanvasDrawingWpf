using System;
using System.Windows;
using System.Windows.Controls;

namespace canvasDrawing
{
    /// <summary>
    /// Interaction logic for Buttons_Panel.xaml
    /// </summary>
    public partial class ButtonsPanel : UserControl
    {
        public event EventHandler<string> buttonClickEvent;
        public ButtonsPanel()
        {
            InitializeComponent();

        }

        Button btn;
        public void addButton(string buttonName)
        {
            btn = new Button();
            btn.Content = buttonName;
            btn.Name = buttonName;
            btn.Click += (sender, args) => buttonClick(sender, buttonName);
            ShapesSelectPanel.Children.Add(btn);
        }


        private void buttonClick(object sender, string name)
        {
            buttonClickEvent?.Invoke(this, name);
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
