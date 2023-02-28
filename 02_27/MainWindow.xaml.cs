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

namespace _02_27
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: {DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            First.IsChecked = Second.IsChecked = Third.IsChecked = Fourth.IsChecked = false;
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        { 
            DescriptionText.Text = (string)((CheckBox)sender).Content;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            DescriptionText.Text = (string)value.Content;
        }
    }
}
