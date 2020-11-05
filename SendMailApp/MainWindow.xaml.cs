﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                MailMessage msg = new MailMessage("ojsinfosys01@gmail.com", tbTo.Text);
                var cc = tbCc.Text.Split(',');
                foreach (var item in cc)
                {
                    msg.CC.Add(new MailAddress(item));
                }
                
                msg.Subject = tbTitle.Text; //件名
                msg.Body = tbBody.Text; //本文

                sc.Host = "smtp.gmail.com"; //SMTPサーバーの設定
                sc.Port = 587;
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("ojsinfosys01@gmail.com", "ojsInfosys2020");

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
    }
}
