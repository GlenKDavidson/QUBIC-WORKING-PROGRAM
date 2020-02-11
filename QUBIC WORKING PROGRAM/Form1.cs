﻿using System;
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
        int gametype = 0;
        Boolean callformove = true;
        public Form1(int a)
        {
            gametype = a;
            qubic = new Game(a);

            InitializeComponent();

            foreach (Control c in this.Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.MouseClick += new MouseEventHandler(buttonClicked);
                }
                catch
                {
                }
            }
        }

        private void buttonClicked(object sender, MouseEventArgs args)
        {
            Move location = new Move();
            Button b = (Button)sender;
            string buttonname = Convert.ToString(b.Name[0]);

            if (callformove && buttonname != "A")
            {


                location.x = (Convert.ToInt32(b.Text[0]) - 48);
                location.y = (Convert.ToInt32(b.Text[2]) - 48);
                location.z = (Convert.ToInt32(b.Text[4]) - 48);

                Boolean validmove = qubic.validmove(location);
                currentplayer = qubic.checkplayer(location);

                if (gametype == 0)
                {
                    b.BackColor = Color.Red;
                }
                else if ((b.BackColor == Color.Black) && validmove)
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
                if (gametype == 0)
                {
                    callformove = false;
                }


            }
            else if (!callformove && buttonname == "A")
            {
                MessageBox.Show("AIBUTTON");
                callformove = true;
                location = qubic.getaimove();
                switch (switch_on)
                {
                    default:
                }
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
