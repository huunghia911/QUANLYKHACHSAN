using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Qlks
{
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        private string dapan = null;
        
        private int kq = 0, x = 0, mang = 3, cau = 0, tg = 3;
        private void load()
        {
            dt.Clear();
            lb_ch.Text = "Câu Hỏi";
            lb_cd.Text = "0";
            bt_dung.Enabled = false;
            bt_sai.Enabled = false;
        }

        private void HuongDan_Load(object sender, EventArgs e)
        {
            load();
        }
        private void random()
        {
            cau++;
            timer1.Start();
            timer2.Start();
            int so;
            Random rd = new Random();
            so = rd.Next(1, 30);
            dt.Clear();
            dt = cl.choigame(so);
            lb_ch.Text = "Câu " + cau +": "+ dt.Rows[0]["Cauhoi"].ToString();
            dapan = dt.Rows[0]["Dapan"].ToString();
            tg = 3;
        }
        private void bt_choi_Click(object sender, EventArgs e)
        {
            bt_dung.Enabled = true;
            bt_sai.Enabled = true;
            lb_m.Text = "Mạng: 3";
            random();
        }

        private void bt_dung_Click(object sender, EventArgs e)
        {
            
            if(bt_dung.Text == dapan)
            {
                timer1.Stop();
                timer2.Stop();
                kq++;
                lb_cd.Text = kq.ToString();
                random();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Số câu đúng: " + lb_cd.Text, "Thông báo", MessageBoxButtons.OKCancel);
                cau = 0;
                mang = 3;
                x = 0;
                kq = 0;
                load();

            }
        }

        private void bt_sai_Click(object sender, EventArgs e)
        {
           
            if (bt_sai.Text == dapan)
            {
                timer1.Stop();
                timer2.Stop();
                kq++;
                lb_cd.Text = kq.ToString();

                random();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Số câu đúng: " + lb_cd.Text, "Thông báo", MessageBoxButtons.OKCancel);
                cau = 0;
                mang = 3;
                x = 0;
                kq = 0;
                load();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            mang--;
            lb_m.Text = "Mạng: " + mang;
            if (x == 3 || mang < 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Số câu đúng: " + lb_cd.Text, "Thông báo", MessageBoxButtons.OKCancel);
                cau = 0;
                mang = 3;
                x = 0;
                kq = 0;
                load();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tg--;
            lb_tg.Text = "Thời gian: " + tg;
            if (tg == 0)
                tg = 3;
        }
    }
}
