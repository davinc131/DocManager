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
using Control;

namespace DocManager
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        private Converter controlConverter;

        public MainWindow()
        {
            InitializeComponent();
            controlConverter = new Converter();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TextRange range = new TextRange(mainRTB.Document.ContentStart, mainRTB.Document.ContentEnd);
                string s = "";
                //range = controlConverter.ConverterRtfToHtml(range);
                MessageBox.Show("Content Conversion Complete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
