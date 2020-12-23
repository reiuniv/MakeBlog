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

    // 性別

    // DataGridに表示するデータ
    public class Person
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var datalist = new ObservableCollection<Person>();
            this.File_List.ItemsSource = datalist;
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
            //Debug.Print(File_List.Name);
            //imgwin.Image_List_Window.Items.Add(File_List.Items);
            //Debug.Print(File_List.Name);
            //Debug.Print((string)File_List.SelectedItem);
        }

        private void Main_Out_Click(object sender, RoutedEventArgs e)
        {
            string maintext = Txt_Main.Text;
            maintext = maintext.Replace("\r\n", "<br>\n");

            string v = Main_Title.Text + "\n";
            Main_OutText.Text = v + maintext;
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
                Debug.Print(strFileName);
                var datalist = File_List.ItemsSource as ObservableCollection<Person>;
               // var datalist2 = imgwin.Image_List_Window.ItemsSource as ObservableCollection<Person>;
                var data = new Person { Name = strFileName, Path = strFilePath };
                datalist.Add(data);
            }

            //this.File_List.ItemsSource = datalist;
            //imgwin.Image_List_Window.ItemsSource = datalist;
        }

        private void List_Delete(object sender, RoutedEventArgs e)
        {
            /// 項目を削除します
            // 選択項目がない場合は処理をしない
            if (File_List.SelectedItems.Count == 0)
                return;

            // 選択された項目を削除
            File_List.Items.RemoveAt(File_List.SelectedIndex);
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

public partial class ImageWindow : Window
{
    public ImageWindow()
    {
        var window1 = this.DataContext;
    }
}
