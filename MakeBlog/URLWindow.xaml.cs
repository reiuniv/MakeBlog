using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;

namespace MakeBlog
{
    /// <summary>
    /// URLWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class URLWindow : Window
    {
        public URLWindow()
        {
            InitializeComponent();
        }

        private void URL_Check_Checked(object sender, RoutedEventArgs e)
        {
            string str = URL_URL.Text;
            URL_Title.Text = str;
            //URL_Title.IsReadOnly = true;
        }
        private void URL_Check_Unchecked(object sender, RoutedEventArgs e)
        {
            //URL_Title.IsReadOnly = false;
        }

        private void URL_Out_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mainwin = (MainWindow)Application.Current.MainWindow;
            string str = "<a class=\"url-link\" href=\"" + URL_URL.Text + "\">" + URL_Title.Text + "</a>";
            Mainwin.Txt_Main.AppendText(str);
            Debug.Print(str);
            Debug.Print(Mainwin.Txt_Main.Text);

            Close();
        }
    }
}
