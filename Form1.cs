using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekranTemizlenecek;
        decimal _ilksayi;       

        public Form1()
        {
            InitializeComponent();
        }

        public void sifirlayici()
        {
            if (_ekranTemizlenecek == true)
            {
                label1.Text = "";
                _ekranTemizlenecek = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }               
        }

        private void Rakam1Button_Click(object sender, EventArgs e)
        {
            sifirlayici();
            label1.Text += "1";
        }

        private void Rakam2Button_Click(object sender, EventArgs e)
        {
            sifirlayici();
            label1.Text += "2";
        }

        private void Rakam3Button_Click(object sender, EventArgs e)
        {
            sifirlayici();
            label1.Text += "3";
        }

        private void Rakam4Button_Click(object sender, EventArgs e)
        {
            sifirlayici();
            label1.Text += "4";
        }

        private void Rakam5Button_Click(object sender, EventArgs e)
        {
            sifirlayici();
            label1.Text += "5";
        }

        private void Rakam6Button_Click(object sender, EventArgs e)
        {
            sifirlayici();
            label1.Text += "6";
        }

        private void Rakam7Button_Click(object sender, EventArgs e)
        {
            sifirlayici();
            label1.Text += "7";
        }

        private void Rakam8Button_Click(object sender, EventArgs e)
        {
            sifirlayici();
            label1.Text += "8";
        }

        private void Rakam9Button_Click(object sender, EventArgs e)
        {
            sifirlayici();
            label1.Text += "9";
        }

        private void Rakam0Button_Click(object sender, EventArgs e)
        {
            sifirlayici();
            label1.Text += "0";
        }

        private void topla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecek = true;
            _ilksayi = Convert.ToDecimal(label1.Text);
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecek = true;
            _ilksayi = Convert.ToDecimal(label1.Text);
        }

        private void carp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecek = true;
            _ilksayi = Convert.ToDecimal(label1.Text);
        }

        private void bol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecek = true;
            _ilksayi = Convert.ToDecimal(label1.Text);
        }

        public void esittir_Click(object sender, EventArgs e)
        {
            decimal ikincisayi = Convert.ToInt32(label1.Text);
            decimal sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;


            }
            label1.Text = Convert.ToString(sonuc);
            _ilksayi = sonuc;
            _ekranTemizlenecek = true;
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
