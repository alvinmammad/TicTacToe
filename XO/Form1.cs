using System;
using System.Drawing;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        Button[,] buttons = new Button[3, 3];

        private bool XorNot;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons = new Button[3, 3]
            {
                { btn1, btn2, btn3 }, { btn4, btn5, btn6 }, { btn7, btn8, btn9
            }};



        }

        private void AllBtnsClick(object sender, EventArgs e)
        {
            yolchuScore.Visible = false;
            elvinScore.Visible = false;
            Button btn = sender as Button;
            btn.BackColor = Color.Aqua;
            if (XorNot == false)
            {

                btn.Text = "X";
                XorNot = true;
                btn.Enabled = false;
                yolchuTurn.Text = "Yolchu";
                elvinTurn.Hide();
                yolchuTurn.Show();
                
                if (!Check())
                {
                    SummaryCheck();
                    

                }
               



            }
            
            else
            {

                btn.Text = "O";
                XorNot = false;
                btn.Enabled = false;
                elvinTurn.Text = "Elvin";
                elvinTurn.Show();
                yolchuTurn.Hide();
                
                if (!Check())
                {
                    SummaryCheck();
                   

                }
              

            }
           
        }

        private bool Check()
        {
            yolchuScore.Visible = false;
            elvinScore.Visible = false;
            int rown = 0;
            bool x = false;
            for (int row = 0; row < buttons.GetLength(0); row++)
            {
                int col = 0;

                if (!String.IsNullOrEmpty(buttons[row, col].Text) && !String.IsNullOrEmpty(buttons[row, col + 1].Text) && !String.IsNullOrEmpty(buttons[row, col + 2].Text))
                {
                    if ((buttons[row, col].Text == buttons[row, col + 1].Text) && (buttons[row, col].Text == buttons[row, col + 2].Text))
                    {
                       
                        x = true;
                        ButtonEnable();
                        elvinScore.Visible = true;
                        yolchuScore.Visible = true;
                        elvinScore.Text = "1";
                        yolchuScore.Text = "0";
                        MessageBox.Show("You are winner");
                        return x;
                       

                    }


                }


            }


            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                if (!String.IsNullOrEmpty(buttons[rown, i].Text) && !String.IsNullOrEmpty(buttons[rown + 1, i].Text) && !String.IsNullOrEmpty(buttons[rown + 2, i].Text))
                {
                    if (buttons[rown, i].Text == buttons[rown + 1, i].Text && buttons[rown, i].Text == buttons[rown + 2, i].Text)
                    {
                        
                        x = true;
                        ButtonEnable();
                        elvinScore.Visible = true;
                        yolchuScore.Visible = true;
                        yolchuScore.Text = "0";
                        elvinScore.Text = "1";
                        MessageBox.Show("You are winner");
                        return x;


                    }

                }


            }


            if (!String.IsNullOrEmpty(buttons[rown, rown].Text) && !String.IsNullOrEmpty(buttons[rown + 1, rown + 1].Text) && !String.IsNullOrEmpty(buttons[rown + 2, rown + 2].Text))
            {

                if (buttons[rown, rown].Text == buttons[rown + 1, rown + 1].Text && buttons[rown, rown].Text == buttons[rown + 2, rown + 2].Text)
                {
                   
                    x = true;
                    ButtonEnable();
                    MessageBox.Show("You are winner");
                    return x;
                }

            }


            if (!String.IsNullOrEmpty(buttons[rown, rown + 2].Text) && !String.IsNullOrEmpty(buttons[rown + 1, rown + 1].Text) && !String.IsNullOrEmpty(buttons[rown + 2, rown].Text))
            {
                if (buttons[rown, rown + 2].Text == buttons[rown + 1, rown + 1].Text && buttons[rown, rown + 2].Text == buttons[rown + 2, rown].Text)
                {
                    
                    x = true;
                    ButtonEnable();
                    MessageBox.Show("You are winner");
                    return x;


                }


            }
            return x;


        }
        private void SummaryCheck()
        {
            bool x = true;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(0); j++)
                {
                    if (String.IsNullOrEmpty(buttons[i, j].Text))
                    {
                        x = false;
                        break;
                    }
                }
            }
            if (x)
            {
                DialogResult dialogResult = MessageBox.Show("Yenidən başlamaq istəyirsinizmi ?", " Qalib müəyyən olunmadı !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Form1 form = new Form1();
                    this.Hide();
                    form.ShowDialog();
                }
               
            }
        }


        private void ButtonEnable()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When clear button is clicked , "btn"-s backcolor will be dark orange
            btn1.BackColor = Color.DarkOrange;
            btn2.BackColor = Color.DarkOrange;
            btn3.BackColor = Color.DarkOrange;
            btn4.BackColor = Color.DarkOrange;
            btn5.BackColor = Color.DarkOrange;
            btn6.BackColor = Color.DarkOrange;
            btn7.BackColor = Color.DarkOrange;
            btn8.BackColor = Color.DarkOrange;
            btn9.BackColor = Color.DarkOrange;

            //When clear button is clicked, "btn"-s text will be empty

            btn1.Text = string.Empty;
            btn2.Text = string.Empty;
            btn3.Text = string.Empty;
            btn4.Text = string.Empty;
            btn5.Text = string.Empty;
            btn6.Text = string.Empty;
            btn7.Text = string.Empty;
            btn8.Text = string.Empty;
            btn9.Text = string.Empty;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }
    }
}

