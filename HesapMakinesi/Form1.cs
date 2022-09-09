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

        private char _islem;
        private bool _ekrantemizle;
        private int _ilksayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void txt_rakam1_Click(object sender, EventArgs e)
        {
            if(_ekrantemizle)
            {
                txt_ekransonuc.Text="";
                _ekrantemizle = false;
            }

            if(txt_ekransonuc.Text =="0")
            {
                txt_ekransonuc.Text = "";
            }
            txt_ekransonuc.Text += "1";
        }

        private void txt_rakam2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                txt_ekransonuc.Text = "";
                _ekrantemizle = false;
            }

            if (txt_ekransonuc.Text == "0")
            {
                txt_ekransonuc.Text = "";
            }
            txt_ekransonuc.Text += "2";
        }

        private void txt_rakam3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                txt_ekransonuc.Text = "";
                _ekrantemizle = false;
            }

            if (txt_ekransonuc.Text == "0")
            {
                txt_ekransonuc.Text = "";
            }
            txt_ekransonuc.Text += "3";
        }

        private void txt_rakam4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                txt_ekransonuc.Text = "";
                _ekrantemizle = false;
            }

            if (txt_ekransonuc.Text == "0")
            {
                txt_ekransonuc.Text = "";
            }
            txt_ekransonuc.Text += "4";
        }

        private void txt_rakam5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                txt_ekransonuc.Text = "";
                _ekrantemizle = false;
            }

            if (txt_ekransonuc.Text == "0")
            {
                txt_ekransonuc.Text = "";
            }
            txt_ekransonuc.Text += "5";
        }

        private void txt_rakam6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                txt_ekransonuc.Text = "";
                _ekrantemizle = false;
            }

            if (txt_ekransonuc.Text == "0")
            {
                txt_ekransonuc.Text = "";
            }
            txt_ekransonuc.Text += "6";
        }

        private void txt_rakam7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                txt_ekransonuc.Text = "";
                _ekrantemizle = false;
            }

            if (txt_ekransonuc.Text == "0")
            {
                txt_ekransonuc.Text = "";
            }
            txt_ekransonuc.Text += "7";
        }

        private void txt_rakam8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                txt_ekransonuc.Text = "";
                _ekrantemizle = false;
            }

            if (txt_ekransonuc.Text == "0")
            {
                txt_ekransonuc.Text = "";
            }
            txt_ekransonuc.Text += "8";
        }

        private void txt_rakam9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                txt_ekransonuc.Text = "";
                _ekrantemizle = false;
            }

            if (txt_ekransonuc.Text == "0")
            {
                txt_ekransonuc.Text = "";
            }
            txt_ekransonuc.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                txt_ekransonuc.Text = "";
                _ekrantemizle = false;
            }

            if (txt_ekransonuc.Text == "0")
            {
                txt_ekransonuc.Text = "";
            }
            txt_ekransonuc.Text += "0";
        }

        private void txt_toplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(txt_ekransonuc.Text);
        }

        private void txt_esittir_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(txt_ekransonuc.Text);
            int sonuc;

            switch(_islem)
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
              txt_ekransonuc.Text = Convert.ToString(sonuc); 
                    
        }

        private void txt_cıkarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(txt_ekransonuc.Text);
        }

        private void txt_carpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(txt_ekransonuc.Text);
        }

        private void txt_bolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(txt_ekransonuc.Text);
        }

        private void txt_Ciptal_Click(object sender, EventArgs e)
        {
            txt_ekransonuc.Text = "0";
        }
    }
}
