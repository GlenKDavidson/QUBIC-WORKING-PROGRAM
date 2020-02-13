using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUBIC_WORKING_PROGRAM
{
    public partial class Form1 : Form
    {
        Game qubic;
        int currentplayer;
        Boolean gametype;
        Boolean callformove = true;

        Button[,,] btnarray = new Button[4, 4, 4];


        public Form1(int a)
        {

            qubic = new Game(a);
            gametype = qubic.getGametype();
            InitializeComponent();

            btnarray[0, 0, 0] = this.O11;
            btnarray[0, 1, 0] = this.O12;
            btnarray[0, 2, 0] = this.O13;
            btnarray[0, 3, 0] = this.O14;
            btnarray[1, 0, 0] = this.O21;
            btnarray[1, 1, 0] = this.O22;
            btnarray[1, 2, 0] = this.O23;
            btnarray[1, 3, 0] = this.O24;
            btnarray[2, 0, 0] = this.O31;
            btnarray[2, 1, 0] = this.O32;
            btnarray[2, 2, 0] = this.O33;
            btnarray[2, 3, 0] = this.O34;
            btnarray[3, 0, 0] = this.O41;
            btnarray[3, 1, 0] = this.O42;
            btnarray[3, 2, 0] = this.O43;
            btnarray[3, 3, 0] = this.O44;

            btnarray[0, 0, 1] = this.P11;
            btnarray[0, 1, 1] = this.P12;
            btnarray[0, 2, 1] = this.P13;
            btnarray[0, 3, 1] = this.P14;
            btnarray[1, 0, 1] = this.P21;
            btnarray[1, 1, 1] = this.P22;
            btnarray[1, 2, 1] = this.P23;
            btnarray[1, 3, 1] = this.P24;
            btnarray[2, 0, 1] = this.P31;
            btnarray[2, 1, 1] = this.P32;
            btnarray[2, 2, 1] = this.P33;
            btnarray[2, 3, 1] = this.P34;
            btnarray[3, 0, 1] = this.P41;
            btnarray[3, 1, 1] = this.P42;
            btnarray[3, 2, 1] = this.P43;
            btnarray[3, 3, 1] = this.P44;

            btnarray[0, 0, 2] = this.Q11;
            btnarray[0, 1, 2] = this.Q12;
            btnarray[0, 2, 2] = this.Q13;
            btnarray[0, 3, 2] = this.Q14;
            btnarray[1, 0, 2] = this.Q21;
            btnarray[1, 1, 2] = this.Q22;
            btnarray[1, 2, 2] = this.Q23;
            btnarray[1, 3, 2] = this.Q24;
            btnarray[2, 0, 2] = this.Q31;
            btnarray[2, 1, 2] = this.Q32;
            btnarray[2, 2, 2] = this.Q33;
            btnarray[2, 3, 2] = this.Q34;
            btnarray[3, 0, 2] = this.Q41;
            btnarray[3, 1, 2] = this.Q42;
            btnarray[3, 2, 2] = this.Q43;
            btnarray[3, 3, 2] = this.Q44;

            btnarray[0, 0, 3] = this.R11;
            btnarray[0, 1, 3] = this.R12;
            btnarray[0, 2, 3] = this.R13;
            btnarray[0, 3, 3] = this.R14;
            btnarray[1, 0, 3] = this.R21;
            btnarray[1, 1, 3] = this.R22;
            btnarray[1, 2, 3] = this.R23;
            btnarray[1, 3, 3] = this.R24;
            btnarray[2, 0, 3] = this.R31;
            btnarray[2, 1, 3] = this.R32;
            btnarray[2, 2, 3] = this.R33;
            btnarray[2, 3, 3] = this.R34;
            btnarray[3, 0, 3] = this.R41;
            btnarray[3, 1, 3] = this.R42;
            btnarray[3, 2, 3] = this.R43;
            btnarray[3, 3, 3] = this.R44;


            foreach (Control c in this.Controls)
            {
                try
                {
                    Button b = (Button)c;


                    b.MouseClick += new MouseEventHandler(moveMake);



                }
                catch
                {
                }
            }
        }
        private void aiMOVE()
        {
            callformove = true;
            qubic.makemove();

            Move move = new Move();
            move = qubic.getaimove();
            


        }

        private void moveMake(object sender, MouseEventArgs args)
        {
            Move location = new Move();
            Button b = (Button)sender;
            string buttonname = Convert.ToString(b.Name[0]);

            if ((buttonname == "O" || buttonname == "Q" || buttonname == "R" || buttonname == "P"))
            {
                if (callformove)
                {
                    location.x = (Convert.ToInt32(b.Text[0]) - 48);
                    location.y = (Convert.ToInt32(b.Text[2]) - 48);
                    location.z = (Convert.ToInt32(b.Text[4]) - 48);

                    Boolean validmove = qubic.validmove(location);
                    currentplayer = qubic.actingplayer();
                    

                    if (validmove)
                    {
                        qubic.makemove();
                        if (gametype == true && b.BackColor == Color.Black)
                        {
                            b.BackColor = Color.Red;
                        }
                        else if ((b.BackColor == Color.Black))
                        {
                            if (currentplayer == 1) //blue is player 2
                            {
                                b.BackColor = Color.Blue;
                            }
                            else
                            {
                                b.BackColor = Color.Red; //red is player 1
                            }
                           
                        }
                        if (qubic.checkwin(location))
                        {
                            MessageBox.Show("Player " + (currentplayer + 1) + " Wins!");
                            this.Hide();
                            Form menu = new Form2();
                            menu.Show();
                        }


                        if (gametype == true)
                        {
                            callformove = false;
                        }

                    }

                }
            }
            else if (buttonname == "A")
            {
                MessageBox.Show("aibuttonpressed");
                aiMOVE();
                
            }

        }

       

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void Button21_Click(object sender, EventArgs e)
        {

        }

        private void Button24_Click(object sender, EventArgs e)
        {

        }

        private void Button43_Click(object sender, EventArgs e)
        {

        }

        private void Button34_Click(object sender, EventArgs e)
        {

        }

        private void Button33_Click(object sender, EventArgs e)
        {

        }

        private void Button39_Click(object sender, EventArgs e)
        {

        }

        private void Button64_Click(object sender, EventArgs e)
        {

        }

        private void Button63_Click(object sender, EventArgs e)
        {

        }

        private void Button58_Click(object sender, EventArgs e)
        {

        }

        private void Button50_Click(object sender, EventArgs e)
        {

        }

        public void Button68_Click(object sender, EventArgs e)
        {


        }

        private void Button16_Click(object sender, EventArgs e)
        {

        }

        private void Button65_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {

        }

        private void Button65_Click_1(object sender, EventArgs e)
        {

        }

        private void Button65_Click_2(object sender, EventArgs e)
        {

        }
    }
}
