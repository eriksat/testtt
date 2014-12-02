using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinderGartenList.AddValue;

namespace KinderGartenList
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            searchRadioButtonsMainFORM();
        }

        private void searchRadioButtonsMainFORM()
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

        private void searchRadioButton2()
        {
            try
            {
                if (radioButton6.Checked)
                {
                    comboBox2.Enabled = true;
                    textBox4.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                }
                if (radioButton5.Checked)
                {
                    comboBox2.Enabled = false;
                    textBox4.Enabled = true;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                }
                if (radioButton4.Checked)
                {
                    comboBox2.Enabled = false;
                    textBox4.Enabled = false;
                    textBox3.Enabled = true;
                    button2.Enabled = true;
                }

            }
            catch (Exception)
            {

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            searchRadioButtonsMainFORM();
            textBox1.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            searchRadioButtonsMainFORM();
            textBox2.Focus();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            
            comboBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
            /////////////
            comboBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            button2.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            searchRadioButton2();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            searchRadioButton2();
            textBox4.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            searchRadioButton2();
            textBox3.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddValueN _addValueN = new AddValueN();
            _addValueN.ShowDialog();
        }

        private void поменятьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void поменятьПарольToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            changePasswordForm _changePasswordForm = new changePasswordForm();
            _changePasswordForm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserMainForm _userMainForm = new UserMainForm();
            _userMainForm.ShowDialog();
        }
    }
}
