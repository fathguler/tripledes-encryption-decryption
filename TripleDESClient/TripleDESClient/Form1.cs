using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleDESClient
{
    public partial class Form1 : Form
    {
        Thread t;
        TcpClient baglantikur;
        NetworkStream ag;
        StreamReader oku;
        StreamWriter yaz;

        public int x = 0;
        public int y = 0;
        public int z = 0;        

        public delegate void ricdegis(string text);

        public void okumayabasla()
        {
            ag = baglantikur.GetStream();
            oku = new StreamReader(ag);
            while (true)
            {
                try
                {
                    string yazi = oku.ReadLine();
                    ekranabas(yazi);
                }
                catch
                {
                    return;
                }
            }
        }
        
        public void ekranabas(string s)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, s);
            }
            else
            {
                x++;
                s = "" + s;
                txtGelenSifreliMetin.Text = s + "\n";
                richTxtMesajEkrani.AppendText(s + "\n");
                richTxtMesajEkrani.AppendText("\n Gelen Mesaj :");
                richTxtMesajEkrani.AppendText(x + " >>  " + s + "\n");
            }
        }

        
        public void baglanti_kur(string hedefIp)
        {            
            baglantikur = new TcpClient(hedefIp, Convert.ToInt16(txtPortNo.Text));
            t = new Thread(new ThreadStart(okumayabasla));
            t.Start();
            richTxtMesajEkrani.AppendText(DateTime.Now.ToString() + " Baglanti Kuruldu...\n");
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglantiKur_Click(object sender, EventArgs e)
        {
            baglanti_kur(txtHedefIp.Text);
        }
        
        private void btnSifrele_Click(object sender, EventArgs e)
        {
            byte[] encrypted;
            richTxtSifreliMetin.Clear();
            x++;
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = md5.ComputeHash(utf8.GetBytes(txtAnahtar.Text));
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tdes.CreateEncryptor();
            encrypted = trans.TransformFinalBlock(utf8.GetBytes(txtMetin.Text), 0, utf8.GetBytes(txtMetin.Text).Length);            
            richTxtSifreliMetin.AppendText(BitConverter.ToString(encrypted));
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (richTxtSifreliMetin.Text == "") return;

            else
            {
                z++;
                yaz = new StreamWriter(ag);
                yaz.WriteLine(richTxtSifreliMetin.Text);
                yaz.Flush();
                richTxtMesajEkrani.AppendText("\nGönderilen Mesaj :");
                richTxtMesajEkrani.AppendText(z + " >>  " + richTxtSifreliMetin.Text + "\n");
            }
        }

        private void btnMetinCoz_Click(object sender, EventArgs e)
        {
            try
            {                
                y++;
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = md5.ComputeHash(utf8.GetBytes(txtAnahtar.Text));
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;


                string[] sifreliMesaj = txtGelenSifreliMetin.Text.Split('-');
                int[] decimalDeger = new int[sifreliMesaj.Length];
                string[] strDecimal = new string[sifreliMesaj.Length];
                byte[] sonuc = new byte[sifreliMesaj.Length];


                for (int i = 0; i < decimalDeger.Length; i++)
                {
                     if (sifreliMesaj[i] != null)
                    {
                        decimalDeger[i] = int.Parse(sifreliMesaj[i], System.Globalization.NumberStyles.HexNumber);
                        strDecimal[i] = Convert.ToString(decimalDeger[i]);
                        sonuc[i] = Convert.ToByte(strDecimal[i]);
                    }
                }
                
                ICryptoTransform trans = tdes.CreateDecryptor();
                richTxtGelenMetin.Text = y + " >> " + utf8.GetString(trans.TransformFinalBlock(sonuc, 0, sonuc.Length));
                
            }

            catch
            {
                MessageBox.Show("Hatalı İşlem!");
            }
        }

        private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            baglantikur.Client.Close();
        }
    }
}
