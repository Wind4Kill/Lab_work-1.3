using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_1._3
{
    public partial class MessageOption : Form
    {
        private TextBox textbox;
        private Button button;
        public int counter { get; set; }


        public MessageOption(TextBox text, Button but)
        {
            InitializeComponent();

            
            textbox = text;
            button = but;
            this.Move += delegate { this.Capture = false; };
            counter = 0;

        }



        private void MessageOption_Load(object sender, EventArgs e)
        {

        }

        private void bOK_Click(object sender, EventArgs e)
        {
            textbox.Text = textBox1.Text;
            button.Enabled = true;
           if(checkBox1.Checked==true)
            {
                counter++;
            }
            if (checkBox2.Checked == true)
            {
                counter++;
            }
            if (checkBox3.Checked == true)
            {
                counter++;
            }
            if (checkBox4.Checked == true)
            {
                counter++;
            }

            Close();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bClickOn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("", "Retry, Cancel?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Retry)
            {
                MessageBox.Show("You have clicked the Retry Button");
                textbox.Text = "Retry";

            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked the Cancel Button");
                textbox.Text = "Cancel";
                
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
