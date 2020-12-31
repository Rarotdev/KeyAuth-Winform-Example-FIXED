using KeyAuth;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLoader
{
    public partial class Login : Form
    {
        string name = ""; // place your Application Name within the Quotes.
        string ownerid = ""; // place your OwnerID within the Quotes.
        string secret = ""; // place your Application Secret within the Quotes.

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            api.init(name, secret, ownerid);


            if (File.Exists("C:\\ProgramData\\keyauthkeysave.txt"))
            {
                string key = File.ReadAllText("C:\\ProgramData\\keyauthkeysave.txt");
                if (api.login(key, name, secret, ownerid))
                {
                    Main gotomain = new Main();
                    gotomain.Show();
                    this.Hide();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (api.login(Key.Text, name, secret, ownerid))
            {
                Main gotomain = new Main();
                gotomain.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            if (api.login(Key.Text, name, secret, ownerid))
            {
                Main gotomain = new Main();
                gotomain.Show();
                this.Hide();
            }
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
