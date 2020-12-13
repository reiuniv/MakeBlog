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

        private void File_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // ★★★複数のファイルを選択できるようにするかどうかの設定★★★
            openFileDialog.Multiselect = true;

            // フィルターの設定
            openFileDialog.Filter = "画像ファイル|*.bmp;*.gif;*.png;*.jpg;*.jpeg";

            // ダイアログボックスの表示
            openFileDialog.ShowDialog();

                // リストボックスの初期化
                //File_List.Items.Clear();

                // 選択されたファイルをテキストボックスに表示する
                foreach (string strFilePath in openFileDialog.FileNames)
                {
                    // ファイルパスからファイル名を取得
                    string strFileName = System.IO.Path.GetFileName(strFilePath);

                    // リストボックスにファイル名を表示
                    File_List.Items.Add(strFileName);
                }
            

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
    }
}
