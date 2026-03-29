using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Play_X_O
{
    public partial class Form1 : Form
    {

        string Player1 = "";
        string Player2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

      

    

        private void Name1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(PlayerName1.Text))
            {

                MessageBox.Show("Please enter Nmae : ");
                return;

            }
            Player1 = PlayerName1.Text;
            MessageBox.Show("Player name saved  " + Player1);

        }

        private void Name2_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(NamePlayer2.Text))
            {

                MessageBox.Show("Please enter Nmae : ");
                return;

            }
            Player2 = NamePlayer2.Text;
            MessageBox.Show("Player name saved " + Player2);






        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            string Name1 = PlayerName1.Text;
            string Name2 = NamePlayer2.Text;
            if(string.IsNullOrEmpty(Name1) && string.IsNullOrEmpty(Name2))
            {

                MessageBox.Show("Please Enter Both Nmae In Text");
                return;


            }

            Form farm1 = new Form2(Player1, Player2);

            farm1.Show();
        }
    }
}
