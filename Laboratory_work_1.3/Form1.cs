using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_1._3
{
    public partial class Form1 : Form
    {

        int counter = 0;
        public Form1()
        {
            InitializeComponent();

            bWhichOption.Enabled = false;
   
        }

        

        private void bYesNoCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Yes, No, Cancel?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("You have clicked Yes Button");
                textResult.Text = "Yes";
                
            }
            if (res == DialogResult.No)
            {
                MessageBox.Show("You have clicked No Button");
                textResult.Text = "No";
            }
            if(res==DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked Cancel Button");
                textResult.Text = "Cancel";
            }
        }

        private void bWhichOption_Click(object sender, EventArgs e)
        {
           
            textResult.Text=counter.ToString();
            counter = 0;
            bWhichOption.Enabled = false;


        }

        private void bAbortRetryIgnore_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Abort, Retry, Ignore?", "Confirmation", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            if (res == DialogResult.Retry)
            {
                MessageBox.Show("You have clicked Retry Button");
                textResult.Text = "Retry";

            }
            if (res == DialogResult.Abort)
            {
                MessageBox.Show("You have clicked Abort Button");
                textResult.Text = "Abort";
            }
            if(res== DialogResult.Ignore)
            {
                MessageBox.Show("You have clicked Ignore Button");
                textResult.Text = "Ignore";
            }
        }

    

        private void bFileOpen_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    filePath = openFileDialog.FileName;

                    
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

            textResult.Text = filePath;
        }

        private void bCustomDialog_Click(object sender, EventArgs e)
        {

            MessageOption newForm = new MessageOption(this.textResult, this.bWhichOption);

            newForm.Text = "Message and Option dialog";
            newForm.ShowDialog();
            if (this.counter != 0)
                this.counter = 0;
            
                this.counter = newForm.counter;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
