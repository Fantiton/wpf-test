using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_test
{
    public partial class MainWindow : Window
    {
        byte red = 255;
        byte green = 255;
        byte blue = 255;
        public MainWindow()
        {
            InitializeComponent();

            RedSlider.ValueChanged += Slider_ValueChanged;
            GreenSlider.ValueChanged += Slider_ValueChanged_1;
            BlueSlider.ValueChanged += Slider_ValueChanged_2;
        }

        private void SetColor()
        {
            Color color = Color.FromRgb(red, green, blue);
            ColorLabel.Background = new SolidColorBrush(color);
        }

        private void SetRGBLabel()
        {
            RGBLabel.Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
            RGBLabel.Content = $"{red}, {green}, {blue}";   
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            red = (byte)RedSlider.Value;
            RedLabel.Content = red.ToString();
            SetColor();
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            green = (byte)GreenSlider.Value;
            GreenLabel.Content = green.ToString();
            SetColor();
        }

        private void Slider_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            blue = (byte)BlueSlider.Value;
            BlueLabel.Content = blue.ToString();
            SetColor();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetRGBLabel();
        }
    }
}