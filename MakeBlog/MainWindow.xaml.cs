using Microsoft.Win32;
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
using System.Diagnostics;
using static System.Console;
using System.Collections.ObjectModel;

namespace MakeBlog
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

        private void Button_Click_Color(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Url(object sender, RoutedEventArgs e)
        {
            var urlwin = new URLWindow();
            urlwin.Show();
            //Txt_Main.AppendText("TEST");
        }

        private void Button_Click_Image(object sender, RoutedEventArgs e)
        {
            var imgwin = new ImageWindow();
            imgwin.Show();
        }

        private void Main_Out_Click(object sender, RoutedEventArgs e)
        {
            string maintext = Txt_Main.Text;
            maintext = maintext.Replace("\r\n", "<br>\n");

            string v = Main_Title.Text + "\n";
            Main_OutText.Text = v + maintext;
        }

        

        private void List_Delete(object sender, RoutedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void File_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}


