using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMailApp
{
    class Config
    {
        public string Smtp { get; set; }    //smtpサーバ
        public string MailAddress { get; set; } //自メールアドレス(送信先)
        public string PassWord { get; set; }    // パスワード
        public int port { get; set; }    //ポート番号
        public bool Ssl { get; set; }     //SSL設定

        //初期設定用
        public void DefaultSet()
        {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            port = 587;
            Ssl = true;

        }
        
    }
}
