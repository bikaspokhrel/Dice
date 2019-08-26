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
            int Dice1, Dice2, Dice3 = 0;
            //We need a boolean,(True, False) to tell us when the values match
            bool RollDiceAgain = true;
            lbxDiceRoll.Items.Clear();
            do //condition for rolling the dice
            {
                Dice1 = myrandom.Next(1, 7);//
                Dice2 = myrandom.Next(1, 7);//
                Dice3 = myrandom.Next(1, 7);//
                //add the values of dice to the list box as a new item
                lbxDiceRoll.Items.Add("Dice1 = "+ Dice1 + " " + "Dice2 = " +Dice2 + "Dice3 = " + Dice3);//
                if((Dice1 == Dice2) || (Dice2 == Dice3))
                {
                    RollDiceAgain = false;
                }
            } while (RollDiceAgain == true);
         }
    }
}
