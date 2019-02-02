using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public bool jailbreak = false;
        bool chat = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("jailbreak Done");
            this.Text = this.Text + "jailbreak ver";
            jailbreak = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //Form2を表示する
            //ここではモードレスフォームとして表示する
            f.Show();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(jailbreak == true)
            {
                MessageBox.Show("あなたの端末はjailbreakされてます。");
            }
            else
            {
                MessageBox.Show("チャットを開始しました。");
                chat = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(chat == true)
            {

                if(jailbreak == true)
                {
                    MessageBox.Show("jailbreakを確認したため、OSを終了します。");
                    this.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jailbreak = false;
        }
    }
}
