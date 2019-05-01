using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Green;
            i = int.Parse(btn.Name.Substring(6));
            
        }
       
        private void button31_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int s1 = (int)numericUpDown2.Value;
            int s2 = (int)numericUpDown3.Value;
            for (int i = 1; i < 31; i++)
            {
                Button btn = (Button)this.Controls["button" + i];
                btn.Text = rn.Next(s1, s2).ToString();
            }
            


        }
       
        private void button32_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                Button btn = (Button)this.Controls["button" + i];
                btn.Text = "";
                btn.BackColor = SystemColors.Control;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
         
            int interval = (int)numericUpDown1.Value;
            
            timer1.Interval = interval;
            timer1.Start();
        }
        int i=-1;
        
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            
            Button btn = (Button)this.Controls["button" + i];
            btn.BackColor = Color.Green;

            Button btnup;
            Button btndown;
            Button btnleft;
            Button btnright;


            

            if (i - 6 >= 1)
            {
                 Button btnn= (Button)this.Controls["button" + (i - 6)];
                if (btnn.BackColor==Color.Red)
                {
                    btnup = null;
                }
                else
                {
                    btnup = (Button)this.Controls["button" + (i - 6)];
                }

            }
            else
            {
                btnup = null;
            }


            if (i + 6 <= 30)
            {

                Button btnn= (Button)this.Controls["button" + (i + 6)];
                if (btnn.BackColor == Color.Red)
                {
                    btndown = null;
                }
                else
                {
                    btndown = (Button)this.Controls["button" + (i + 6)];
                }

            }
            else
            {
                btndown = null;
            }

            if (i % 6 != 1)
            {

                Button btnn = (Button)this.Controls["button" + (i - 1)];
                if (btnn.BackColor == Color.Red)
                {
                    btnleft = null;
                }
                else
                {
                    btnleft = (Button)this.Controls["button" + (i - 1)];
                }


            }
            else
            {
                btnleft = null;
            }

            if (i % 6 != 0)
            {

                Button btnn = (Button)this.Controls["button" + (i + 1)];
                if (btnn.BackColor == Color.Red)
                {
                    btnright = null;
                }
                else
                {
                    btnright = (Button)this.Controls["button" + (i + 1)];
                }


            }
            else
            {
                btnright = null;
            }



            int max = -1;

            if (btnup != null && max < Convert.ToInt32(btnup.Text))
            {
                i = Convert.ToInt32(btnup.Tag);
                max = Convert.ToInt32(btnup.Text);
            }
            if (btndown != null && max < Convert.ToInt32(btndown.Text))
            {
                i = Convert.ToInt32(btndown.Tag);
                max = Convert.ToInt32(btndown.Text);
            }
            if (btnleft != null && max < Convert.ToInt32(btnleft.Text))
            {
                i = Convert.ToInt32(btnleft.Tag);
                max = Convert.ToInt32(btnleft.Text);
            }
            if (btnright != null && max < Convert.ToInt32(btnright.Text))
            {
                i = Convert.ToInt32(btnright.Tag);
                max = Convert.ToInt32(btnright.Text);
            }
            if(max!=-1)
            {
                btn.BackColor = Color.Red;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Gidilecek Başka Yer Kalmadı");
            }
           
            
        }
    }
}
