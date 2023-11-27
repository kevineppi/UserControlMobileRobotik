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

namespace UserControlRW
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {

            sldValue.Value = 100;
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            sldValue.Value = 0;
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            sldValue.Value = -100;
        }

        private void sldValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateProgressBarFill();
            lblActValue.Content = $"{e.NewValue}";
        }
        private void UpdateProgressBarFill()
        {
            double sliderValue = sldValue.Value;

            // Setze die Werte für die ProgressBar je nach Slider-Wert
            if (sliderValue >= 0)
            {
                // ProgressBar von unten nach oben füllen (Werte von 0 bis 100)
                progressBarPositive.Minimum = 0;
                progressBarPositive.Maximum = 100;
                progressBarPositive.Value = sliderValue;

                // Setze die Werte für die ProgressBar von oben nach unten (Werte von 0 bis -100)
                progressBarNegative.Minimum = 0;
                progressBarNegative.Maximum = 100;
                progressBarNegative.Value = 0;
            }
            else
            {
                // ProgressBar von oben nach unten füllen (Werte von 0 bis -100)
                progressBarNegative.Minimum = 0;
                progressBarNegative.Maximum = 100;
                progressBarNegative.Value = -sliderValue;

                // Setze die Werte für die ProgressBar von unten nach oben (Werte von 0 bis 100)
                progressBarPositive.Minimum = 0;
                progressBarPositive.Maximum = 100;
                progressBarPositive.Value = 0;
            }
        }

        // Weitere Event-Handler und Code können hier hinzugefügt werden
    }
}
    
