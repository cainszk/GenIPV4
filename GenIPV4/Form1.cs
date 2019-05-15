using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenIPV4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string iplist;
        int startip4;
        int endip4;

        void test4ip123()
        {
            if(txt4ip1.Text!= txt4ip5.Text)
            {
                MessageBox.Show("起讫IP地址前3段必须为相同！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt4ip2.Text != txt4ip6.Text)
                {
                    MessageBox.Show("起讫IP地址前3段必须为相同！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txt4ip3.Text != txt4ip7.Text)
                    {
                        MessageBox.Show("起讫IP地址前3段必须为相同！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        test4ip4();
                    }
                }
            }
        }

        void test4ip4()
        {
            startip4 = int.Parse(txt4ip4.Text);
            endip4 = int.Parse(txt4ip8.Text);
            if (startip4 > endip4)
            {
                int iptrans = endip4;
                endip4 = startip4;
                startip4 = iptrans;
                string iptxttrans = txt4ip8.Text;
                txt4ip8.Text = txt4ip4.Text;
                txt4ip4.Text = iptxttrans;
                if (endip4 > 255)
                {
                    endip4 = 255;
                    txt4ip8.Text = "255";
                }
                genip();
            }
            else
            {
                if (startip4 == endip4)
                {
                    iplist = txt4ip1.Text + "." + txt4ip2.Text + "." + txt4ip3.Text + "." + txt4ip4.Text;
                    FileStream fscr = File.Create(@"ipList.txt");
                    StreamWriter sw = new StreamWriter(fscr, Encoding.Default);
                    sw.Write(iplist);
                    sw.Close();
                    fscr.Close();
                    Process.Start(@"ipList.txt");
                }
                else
                {
                    if (endip4 > 255)
                    {
                        endip4 = 255;
                        txt4ip8.Text = "255";
                    }
                    genip();
                }
            }
        }

        void genip()
        {
            string ip123 = txt4ip1.Text + "." + txt4ip2.Text + "." + txt4ip3.Text;
            for (int i = startip4; i < endip4+1; i++)
            {
                if(i == startip4)
                {
                    iplist = ip123 + "." + i.ToString();
                }
                else
                {
                    iplist += "\r\n" + ip123 + "." + i.ToString();
                }
            }
            FileStream fscr = File.Create(@"ipList.txt");
            StreamWriter sw = new StreamWriter(fscr, Encoding.Default);
            sw.Write(iplist);
            sw.Close();
            fscr.Close();
            Process.Start(@"ipList.txt");
        }

        private void btn4genip_Click(object sender, EventArgs e)
        {
            test4ip123();
        }

        private void txt4ip1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
            }
        }

        private void txt4ip2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
            }
        }

        private void txt4ip3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
            }
        }

        private void txt4ip4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
            }
        }

        private void txt4ip5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
            }
        }

        private void txt4ip6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
            }
        }

        private void txt4ip7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
            }
        }

        private void txt4ip8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
            }
        }

        private void txt4ip7_TextChanged(object sender, EventArgs e)
        {
            txt4ip3.Text = txt4ip7.Text;
        }

        private void txt4ip6_TextChanged(object sender, EventArgs e)
        {
            txt4ip2.Text = txt4ip6.Text;
        }

        private void txt4ip5_TextChanged(object sender, EventArgs e)
        {
            txt4ip1.Text = txt4ip5.Text;
        }

        private void txt4ip3_TextChanged(object sender, EventArgs e)
        {
            txt4ip7.Text = txt4ip3.Text;
        }

        private void txt4ip2_TextChanged(object sender, EventArgs e)
        {
            txt4ip6.Text = txt4ip2.Text;
        }

        private void txt4ip1_TextChanged(object sender, EventArgs e)
        {
            txt4ip5.Text = txt4ip1.Text;
        }
    }
}
