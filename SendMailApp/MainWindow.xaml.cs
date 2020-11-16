using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace SendMailApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            sc.SendCompleted += Sc_SendCompleted;

        }

        private void Sc_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("送信はキャンセルされました。");
            } else
            {
                MessageBox.Show(e.Error?.Message ?? "送信完了！");
            }
        }

        //送信完了イベント
        SmtpClient sc = new SmtpClient();
        //メール送信処理
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Config cf = Config.GetInstance();
                //MailMessage msg = new MailMessage("ojsinfosys01@gmail.com", tbTo.Text);
                MailMessage msg = new MailMessage(cf.MailAddress, tbTo.Text);

                if (tbCc.Text != "")
                    msg.CC.Add(tbCc.Text);
                //msg.CC.Add(tbCc.Text);
                /*var cc = tbCc.Text.Split(',');
                foreach (var item in cc)
                {
                    msg.CC.Add(item);
                }*/

                //msg.Bcc.Add(tbBcc.Text);
                if (tbCc.Text != "")
                    msg.Bcc.Add(tbBcc.Text);

                if (lbBox.Items != null)
                {
                    foreach (var item in lbBox.Items)
                    {
                        msg.Attachments.Add(new Attachment(item.ToString()));
                    }
                }

                msg.Subject = tbTitle.Text; //件名
                msg.Body = tbBody.Text; //本文

                //sc.Host = "smtp.gmail.com"; //SMTPサーバーの設定
                sc.Host = cf.Smtp;
                //sc.Port = 587;
                sc.Port = cf.Port;
                //sc.EnableSsl = true;
                sc.EnableSsl = cf.Ssl;
                //sc.Credentials = new NetworkCredential("ojsinfosys01@gmail.com", "ojsInfosys2020");
                sc.Credentials = new NetworkCredential(cf.MailAddress, cf.PassWord);

                sc.SendMailAsync(msg);
                //sc.Send(msg); //送信
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //送信キャンセル処理
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            sc.SendAsyncCancel();
        }

        //設定画面のイベントハンドラ
        private void btConfig_Click(object sender, RoutedEventArgs e)
        {
            ConfigWindowShow();//設定画面表示
        }

        //設定画面表示
        private void ConfigWindowShow()
        {
            ConfigWindow configWindow = new ConfigWindow();//設定画面のインスタンスを生成
            configWindow.ShowDialog();//表示
        }

    

        //メインウインドウがロードされるタイミングで呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Config.GetInstance().DeSerialise();
            }
            catch (FileNotFoundException)
            {
                //btConfig_Click(sender,e);
                ConfigWindowShow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           
            try
            {
                Config.GetInstance().Serialise();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAdd(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                lbBox.Items.Add(ofd.FileName);
            }
        }
    }
}
