using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace SendMailApp
{
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window
    {
        public ConfigWindow()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, RoutedEventArgs e)
        {
            Config cf = (Config.GetInstance()).getDefaultStatus();
            //Config defaultData = cf.getDefaultStatus();
            //tbSmtp.Text = defaultData.Smtp;

            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;

        }
        //適用（更新）
        private void btApply_Click(object sender, RoutedEventArgs e)
        {

            if (tbSmtp.Text == "" || tbUserName.Text == "" || tbPassWord.Password == "" || tbSender.Text == "")
            {

                Message();
            } else
            {
                (Config.GetInstance()).UpdateStatus(
                   tbSmtp.Text,
                   tbUserName.Text,
                   tbPassWord.Password,
                   int.Parse(tbPort.Text),
                   cbSsl.IsChecked ?? false); //更新処理を呼び出す。   
            }
        }

        //Okボタン
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            if (tbSmtp.Text == "" || tbUserName.Text == "" || tbPassWord.Password  == "" || tbSender.Text == "")
            {

                Message();
            } else
            {
                btApply_Click(sender, e);//更新要素を取り出す
                this.Close();
            }  
        }

        private void Message()
        {
            MessageBox.Show("正しい値を入力してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBoxs();
        }

        private void textBox1_TextChanged(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //キャンセルボタン
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox1_TextChanged(sender, e);
            }
            catch (Exception)
            {

                this.Close();
               
            }
        }

        private void MessageBoxs()
        {
            //メッセージボックスを表示する
            System.Windows.Forms.MessageBox.Show("変更が反映されていません",
                "質問",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
        }

        //ロード時に一度だけ呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Config cf = (Config.GetInstance());
            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;

        }
        private void Window_Closed(object sender, EventArgs e)
        {

         
        }

       
    }
}
