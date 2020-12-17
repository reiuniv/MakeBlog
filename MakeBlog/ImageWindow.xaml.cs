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
    /// ImageWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ImageWindow : Window
    {
        public ImageWindow()
        {
            InitializeComponent();
            MainWindow Mainwin = (MainWindow)Application.Current.MainWindow;
            Image_List_Window.Items.Add(Mainwin.File_List.Items);
            Debug.Print((string)Mainwin.File_List.SelectedItem);

        }

        private void Image_List_Window_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
