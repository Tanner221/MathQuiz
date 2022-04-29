using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // create random number object
        Random randomizer = new Random();

        //addition
        int addend1 = 0;
        int addend2 = 0;
        
        //subtraction
        int minuend = 0;
        int subtrahend = 0;

        //multiplication
        int multiplicand = 0;
        int multiplier = 0;

        //division
        int dividend = 0;
        int divisor = 0;

        int timeLeft = 0;

        public DateTime today = DateTime.Today;

        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }
        private bool checkTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        public Form1()
        {
            InitializeComponent();
            dateLabel.Text = today.ToString("d MMMM yyy");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
                timeLabel.BackColor = SystemColors.Control;
                timeLabel.ForeColor = SystemColors.ControlText;
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                if (timeLeft == 10)
                {
                    timeLabel.BackColor = Color.Red;
                    timeLabel.ForeColor = Color.White;
                }
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
                timeLabel.BackColor = SystemColors.Control;
                timeLabel.ForeColor = SystemColors.ControlText;
                
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void playSound(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            switch (num.Name)
            {
                case "sum":
                    if (num.Value == (addend1 + addend2))
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                        simpleSound.Play();
                    }
                    break;
                case "difference":
                    if (num.Value == (minuend - subtrahend))
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                        simpleSound.Play();
                    }
                    break;
                case "product":
                    if (num.Value == (multiplicand * multiplier))
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                        simpleSound.Play();
                    }
                    break;
                case "quotient":
                    if (num.Value == (dividend / divisor))
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                        simpleSound.Play();
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
