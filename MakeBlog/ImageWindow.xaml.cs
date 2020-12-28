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
using System.Collections.ObjectModel;
using Microsoft.Win32;

public class ImageData
{
    public string Name { get; set; }
    public string Path { get; set; }

    public bool Send { get; set; }
}


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
            var datalist = new ObservableCollection<ImageData>();
            this.Image_List_Window.ItemsSource = datalist;


        }

        private void File_Click(object sender, RoutedEventArgs e)
        {//CSV経由でうまく出来ない？
            OpenFileDialog openFileDialog = new OpenFileDialog();
            ImageWindow imgwin = new ImageWindow();
            imgwin.DataContext = this;


            // ★★★複数のファイルを選択できるようにするかどうかの設定★★★
            openFileDialog.Multiselect = true;

            // フィルターの設定
            openFileDialog.Filter = "画像ファイル|*.bmp;*.gif;*.png;*.jpg;*.jpeg";

            // ダイアログボックスの表示
            openFileDialog.ShowDialog();


            // 選択されたファイルをテキストボックスに表示する
            foreach (string strFilePath in openFileDialog.FileNames)
            {
                // ファイルパスからファイル名を取得
                string strFileName = System.IO.Path.GetFileName(strFilePath);
                var datalist = Image_List_Window.ItemsSource as ObservableCollection<ImageData>;
                var data = new ImageData { Send = false, Name = strFileName, Path = strFilePath};
                datalist.Add(data);

            }
        }


        private void Image_List_Window_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void List_Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Image_Send_Click(object sender, RoutedEventArgs e)
        {
            var datalist = Image_List_Window.ItemsSource as ObservableCollection<ImageData>;

        }

        private void Image_List_Window_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {


        }
    }
}
