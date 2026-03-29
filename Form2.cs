using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Play_X_O
{
    public partial class Form2 : Form
    {
        Button[] btnArray;
        public string P1 = "";
        public string P2 = "";
        bool isFirstPlay = true;

        public Form2(string PlayerName1, string PlayerName2)
        {
            InitializeComponent();

            P1 = PlayerName1;
            P2 = PlayerName2;

            MessageBox.Show("Welcome " + P1 + " and " + P2, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label5.Text = P1;

            btnArray = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };


        }

        private void label5_Click(object sender, EventArgs e)
        {





        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {


            Color Black = Color.FromArgb(255, 0, 0, 0);

            Pen Pen = new Pen(Black);
            Pen.Width = 10;
            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(Pen, 475, 80, 475, 300);
            e.Graphics.DrawLine(Pen, 330, 80, 330, 300);
            // الخط الأفقي الأول (طولناه من 200 إلى 600)


            // الخط الأفقي الأول (تم تقصيره من الطرفين)
            e.Graphics.DrawLine(Pen, 250, 150, 550, 150);

            // الخط الأفقي الثاني (بنفس الطول الجديد)
            e.Graphics.DrawLine(Pen, 250, 250, 550, 250);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Player1_Click(object sender, EventArgs e)
        {






        }

        private void PlayerClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null && btn.Tag == null)
            {
                btn.BackgroundImageLayout = ImageLayout.Stretch;

                if (isFirstPlay)
                {
                    btn.BackgroundImage = Properties.Resources.X;
                    btn.Tag = "X";


                    label5.Text = P2;
                    isFirstPlay = false;
                }
                else
                {
                    btn.BackgroundImage = Properties.Resources.O;
                    btn.Tag = "O";


                    label5.Text = P1;
                    isFirstPlay = true;
                }

                btn.Enabled = false;


                CheckWinner();
            }
        }
        public void EnableButtons()
        {
            // نمر على كل الأدوات (Controls) الموجودة في الصفحة
            foreach (Control c in this.Controls)
            {       
                // نتأكد إن الأداة هي "زر" (Button) ومن أزرار اللعب التسعة
                if (c is Button btn && btn.Name.Contains("button"))
                {
                    btn.Enabled = true;           // نرجع الزر يشتغل
                    btn.BackgroundImage = null;    // نحذف صورة الـ X أو O
                    btn.Tag = null;                // نصفر التاغ عشان الحكم يبدأ من جديد


                    btn.BackColor = this.BackColor;
                    btn.BackgroundImage = Properties.Resources.question_mark_96;
                }
            }

            // تصغير المتغيرات للبداية
            isFirstPlay = true;
            label5.Text = P1; // نرجع نظهر اسم اللاعب الأول في الدور (Turn)
        }

        private bool IsMach(Button b1, Button b2, Button b3)
        {

            if (b1.Tag?.ToString() != null &&
         b1.Tag?.ToString() == b2.Tag?.ToString() &&
         b2.Tag?.ToString() == b3.Tag?.ToString())
            {

                b1.BackColor = Color.White;
                b2.BackColor = Color.White;
                b3.BackColor = Color.White;
                return true;



            }
            return false;




        }
        bool IsBoardFull()
        {


            foreach (Control c in this.Controls)
            {


                if (c is Button btn && btn.Name.Contains("button") && btn.Tag == null)
                    return false;



            }
            return true;




        }

      

      

private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {



            foreach (Control c in this.Controls)
            {

                if (c is Button btn)
                {


                    btn.Enabled = true;


                    btn.BackgroundImage = null;
                    btn.Tag = null;
                    btn.BackColor = Color.FromKnownColor(KnownColor.Control);

                }



            }




        }

        public void CheckWinner()
        {


           

            if (IsMach(button1, button2, button3) ||
                IsMach(button1, button4, button7) ||
                IsMach(button1, button5, button9) ||
                IsMach(button2, button5, button8) ||
                IsMach(button2, button5, button9) ||
                IsMach(button3, button6, button9) ||
                IsMach(button3, button5, button7) ||
                IsMach(button4, button5, button6) ||
                IsMach(button4, button5, button6))
            {

                string Winn = (isFirstPlay == false) ? P1 : P2;
                winner.Text = Winn;

                MessageBox.Show("The Winner Is: " + Winn, "Game Over 🏆", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnableButtons();




            }
            else if (IsBoardFull())
            {


                MessageBox.Show("Game is Draw! 🤝", "",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                winner.Text = "Draw";

                EnableButtons();

            }


        }
        private void winner_Click(object sender, EventArgs e)
        {





        }
    }
}
