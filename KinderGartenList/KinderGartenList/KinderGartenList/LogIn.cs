using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KinderGartenList
{
    public partial class LogIn : Form
    {
        private SqlConnection con;
                private SqlDataAdapter cmd;
        private DataTable dt;
       
        private string userLogin;
                private string query;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Новая папка (2)\KinderGardenList\KinderGartenList\KinderGartenList\KinderGartenList\inform.mdf;Integrated Security=True");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           _logCheck();
        }

        private void TEST()
        {
            if(comboBox1.Text=="Admin" & textBox2.Text=="1")
            {
                Hide();
                AdminMainForm _adminMainForm = new AdminMainForm();
                _adminMainForm.ShowDialog();
            }
            if (comboBox1.Text == "User" & textBox2.Text == "2")
            {
                Hide();
                UserMainForm _userMainForm = new UserMainForm();
                _userMainForm.ShowDialog();
            }
        }

        private void _logCheck()
        {

            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("\n\tPlease Choose Users!\t\t   \n", "AmiN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(comboBox1, "Please Choose Users!");
                comboBox1.BackColor = Color.Red;return;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("\n\tPlease Fill Password!\t\t   \n", "AmiN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.BackColor = Color.Red; return;
            }

            else
            {
                
                _logConnectionData();
            }
        }
        private void _logConnectionData()
        {

            try
            {




                if (con.State != ConnectionState.Open)
                {
                    con.Open();

                    query = "select count(*) from Admin where USERNAME = '" + comboBox1.Text + "' and PASSWORD = '" +
                            textBox2.Text + "' ";
                   // MessageBox.Show(query);
                    cmd = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    cmd.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        userLogin = comboBox1.Text;
                        con.Close();
                        if (userLogin == "Admin")
                        {
                            this.Hide();
                            AdminMainForm frAdmin = new AdminMainForm();
                            frAdmin.Show();
                        }
                        else if (userLogin == "User")
                        {
                            this.Hide();

                            UserMainForm frUser = new UserMainForm();
                            frUser.Show();

                        }

                    }
                }

                else
                {
                    MessageBox.Show("LOGIN OR PASSWORD INCORRECT!");
                }


            }
            catch (Exception kataException)
            {
                MessageBox.Show(kataException.Message);

            }

        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.Focus();
        }

      
    }
}
