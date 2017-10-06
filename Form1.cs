using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* This code is based on the documentation for the System.Windows.Forms.Timer posted here: https://msdn.microsoft.com/en-us/library/system.windows.forms.timer.tick(v=vs.110).aspx */

namespace ChangingHPWithTimer
{

    public partial class Form1 : Form
    {
        // Declare a Timer object called myTimer using the new Timer() constructor


        public Form1()
        {
            InitializeComponent();

            // Run the timer1_Tick function each time the Interval is up
            myTimer.Tick += new EventHandler(timer1_Tick);

            // Set your timer's Interval property to a random 1-6 seconds using the Dice class's Roll method

            // Set your timer's Enable property to true

            // Start your timer using the Timer class's Start method

            // This code processes all the events in the queue.
            Application.DoEvents();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            // use int.Parse(label2.Text) to get the current health and store it in a new int called playerHealth

            // ROLL TWO DICE: use the Dice class's Roll method + another Dice Roll method and store it in a new int called enemyDamage

            // Set playerHealth to playerHealth minus enemyDamage
            playerHealth -= enemyDamage;

            // convert playerHealth with the ToString() method and set it as the label2.Text

            // create a MessageBox with a Show method that tells you "Enemy attacks you! -enemyDamage HP"

            // if the playerHealth is less than 1

            {
                // Stop your timer using the Timer class's Stop method

                // create a MessageBox with a Show method that says "YOU DIED"

            }

        }
    }
    // Create a Dice class
    public static class Dice
    {
        private static Random rnd = new Random();
        public static int Roll()
        {
            // Returns an integer between 1 and 6. The upper boundary is exclusive and it will never return 7.
            return rnd.Next(1, 7);
        }
    }
}
