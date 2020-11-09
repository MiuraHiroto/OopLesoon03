﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMailApp
{
    public class Config
    {
        //単一のインスタンス
        private static Config instance;

        public string Smtp { get; set; }    //smtpサーバ
        public string MailAddress { get; set; } //自メールアドレス(送信先)
        public string PassWord { get; set; }    // パスワード
        public int port { get; set; }    //ポート番号
        public bool Ssl { get; set; }     //SSL設定

        //インスタンスの取得
        public static Config GetInstance()
        {
            if (instance == null)
            {
                instance = new Config();
            }
            return instance;
        }

        //コンストラクタ(外部からnewできないようにする)
        private Config()
        {

        }

        //初期設定用
        public void DefaultSet()
        {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            port = 587;
            Ssl = true;

        }

        //初期値取得用
        public Config getDefaultStatus()
        {
            Config obj = new Config
            {
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                port = 587,
                Ssl = true,
            };
            return obj;
        }
        
        //設定データ更新
        //public bool UpdateStatus(Config cf) //cfのことを仮引数という。
        public bool UpdateStatus(string smtp,string mailAddress,string passWord,int port,bool ssl)  
        {
            this.Smtp = smtp;
            this.MailAddress = mailAddress;
            this.PassWord = passWord;
            this.port = port;
            this.Ssl = ssl;

            return true;
        }

        public void Serialise()//シリアル化
        {

        }

        public void DeSerialise()//逆シリアル化
        {

        }
    }
}
