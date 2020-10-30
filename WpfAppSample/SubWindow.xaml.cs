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

namespace WpfAppSample
{
    /// <summary>
    /// SubWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class SubWindow : Window
    {
        public SubWindow()
        {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxTextBlock.Text = "チェック済み";
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            checkBoxTextBlock.Text = "未チェック";
        }

        private void redRadioButten_Checked(object sender, RoutedEventArgs e)
        {
            colorTextBox.Text = "赤";
        }

        private void yellowRadioButten_Checked(object sender, RoutedEventArgs e)
        {
            colorTextBox.Text = "黄";
        }

        private void blueRadioButten_Checked(object sender, RoutedEventArgs e)
        {
            colorTextBox.Text = "青";
        }

        private void seasonConboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            seasonTextBlock.Text = (string)((ComboBoxItem)seasonConboBox.SelectedItem).Content;
            //seasonTextBlock.Text = (string)((ComboBoxItem)seasonConboBox.SelectedItem).Content;
        }
    }
}
