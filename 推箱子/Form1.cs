using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 推箱子
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int LeftTime=120;

        private void Form1_Resize(object sender, EventArgs e)
        {
            gameArea.ClientSize = new Size(ClientSize.Height, ClientSize.Height);
            gameArea.Location=Point.Round(new PointF(ClientSize.Width/2f-gameArea.Width/2f, 0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playArea.Focus();
            playArea.闯关完成 += PlayArea_闯关完成;
        }

        private void PlayArea_闯关完成(int obj)
        {
            pictureBox1.ClientSize = new Size((int)(playArea.ClientSize.Width*0.5f), (int)(playArea.ClientSize.Height * 0.5f));
            pictureBox1.Location = new Point((int)(playArea.Width / 2f - pictureBox1.Width / 2f), (int)(playArea.Height / 2f - pictureBox1.Height / 2f));
            pictureBox1.Visible = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LeftTime>0)
            {
                LeftTime--;
                lblTime.Text = $"时间：{LeftTime}s";
            }
            else
            {
                playArea.Restart();
                LeftTime = 120;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            playArea.Restart();
            pictureBox1.Visible = false;
        }
    }
}
