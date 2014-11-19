using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinderGartenList
{
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            searchRadioButtonsUserFORM();
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void searchRadioButtonsUserFORM()
        {
            try
            {
                if (radioButton1.Checked)
                {
                    comboBox1.Enabled = true;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    button1.Enabled = true;
                }
                if (radioButton2.Checked)
                {
                    comboBox1.Enabled = false;
                    textBox1.Enabled = true;
                    textBox2.Enabled = false;
                    button1.Enabled = true;
                }
                if (radioButton3.Checked)
                {
                    comboBox1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = true;
                    button1.Enabled = true;
                }

            }
            catch (Exception)
            {

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            searchRadioButtonsUserFORM();
            textBox1.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            searchRadioButtonsUserFORM();
            textBox2.Focus();
        }

    }
}
