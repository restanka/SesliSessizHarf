using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] harf = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü', };

        string kelime;

        int x = 0;
        private void bBul_Click(object sender, EventArgs e)
        {
            SesliSessizBul();
        }

        private void SesliSessizBul()
        {
            lbSesliHarf.Items.Clear();
            lbSessizHarf.Items.Clear();
            kelime = tbKelimeGir.Text;
            
           if (Convert.ToString(tbKelimeGir.Text.Trim()) == "")
            {
                MessageBox.Show("Lütfen Bir Kelime Giriniz");

            }
            else
            {
                foreach (char harf1 in kelime)
                {
                    x = 0;

                    for (int i = 0; i < harf.Length; i++)
                    {
                        if (harf1 == harf[i])
                        {
                            lbSesliHarf.Items.Add(harf1);
                            x++;
                            break;
                        }
                    }

                    if (x == 0)
                    {
                        lbSessizHarf.Items.Add(harf1);
                    }
                }
            }
               
                 
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbKelimeGir.Clear();
            lbSesliHarf.Items.Clear();
            lbSessizHarf.Items.Clear();
        }
    }
}



