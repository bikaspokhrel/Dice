using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            // Define a random generator with millisecond as the seed
            Random myrandom = new Random(DateTime.Now.Millisecond);
            //define the variables that will set values with the initial value as 0
            int Dice1, Dice2 = 0;
            lbxDiceRoll.Items.Clear();
            do //condition for rolling the dice
            {
                Dice1 = myrandom.Next(1, 7);
                Dice2 = myrandom.Next(1, 7);
            } while (Dice1 != Dice2);
            //add the values of dice to the list box as a new item
            lbxDiceRoll.Items.Add(Dice1 + " " + Dice2);
        }
    }
}
