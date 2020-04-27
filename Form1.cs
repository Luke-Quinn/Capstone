using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoomBox
{
    public partial class Form1 : Form
    {
        private MusicPlayer musicPlayer = new MusicPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    musicPlayer.Open(ofd.FileName);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musicPlayer.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            musicPlayer.Stop(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
