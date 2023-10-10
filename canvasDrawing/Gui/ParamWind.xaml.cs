using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace canvasDrawing
{
    /// <summary>
    /// Interaction logic for shape.xaml
    /// </summary>
    public partial class ParamWind : UserControl
    {
        Grid grid = new Grid();
        StackPanel stackPanel = new StackPanel();
        StackPanel stackPanel2 = new StackPanel();
        Button draw = new Button();

        public List<UpdatableShape> shapes = new List<UpdatableShape>();
        List<Control> controls = new List<Control>();
        Canvas canvas;
        public ParamWind(Canvas canvas)
        {
            InitializeComponent();

            this.canvas = canvas;

            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            Grid.SetColumn(stackPanel, 0);
            Grid.SetColumn(stackPanel2, 1);

            grid.Children.Add(stackPanel);
            grid.Children.Add(stackPanel2);

            stackPanel2.Background = Brushes.Red;
            stackPanel2.Orientation = Orientation.Vertical;
            stackPanel2.VerticalAlignment = VerticalAlignment.Bottom;
            stackPanel2.Margin = new Thickness(30, 0, 30, 10);

            stackPanel.Background = Brushes.Black;
            stackPanel.Orientation = Orientation.Vertical;


            //shapes.Add(new Rectangle { name = "Rectangle"});

            //shapes.Add(new Circle { name = "Circle" });

            draw.Content = "Draw";
            draw.Background = Brushes.LightGray;

            stackPanel2.Children.Add(draw);

            draw.Click += Draw_Click;


        }


        List<string> parameters;
        UpdatableShape theShape;
        public void drawWindowFor(UpdatableShape shape)
        {
            theShape = shape;
            foreach (Control cntrol in controls)
            {
                stackPanel.Children.Remove(cntrol);
            }


            //for (int i = 0; i< shapesList.Count; i++)
            //{
            //    if (shapename == shapes[i].name)
            //    {
            //        theShape = shapes[i];
            //    }
            //}
            parameters = shape.getParamNames();

            foreach (string paramName in parameters)
            {
                drawLabelandTextBox(paramName);
            }
            //drawButton();


            this.Content = grid;
        }



        Label label;
        TextBox textBox;
        void drawLabelandTextBox(string paramName)
        {
            label = new Label();

            label.Content = paramName;
            label.MinHeight = 20;

            label.Background = Brushes.White;
            stackPanel.Children.Add(label);

            controls.Add(label);

            textBox = new TextBox();
            Thickness newMargin = new Thickness(10, 20, 30, 40);

            textBox.Name = paramName;
            textBox.Margin = newMargin;
            textBox.Background = Brushes.LightGray;

            stackPanel.Children.Add(textBox);

            controls.Add(textBox);
        }




        private void Draw_Click(object sender, RoutedEventArgs e)
        {

            //  TextBox textBox;

            foreach (Control tbox in controls)
            {
                if (tbox is TextBox)
                {
                    textBox = (TextBox)tbox;
                    int textboxValue = int.Parse(textBox.Text);
                    theShape.setParamValue(tbox.Name, textboxValue);

                }
            }

            theShape.draw(canvas);
        }




    }
}
