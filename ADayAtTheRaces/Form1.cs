using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            minimumBetLabel.Text = $"Minimum bet: {placeBetAmount.Minimum} bucks";
            grayHoundArray[0] = new GrayHound()
            {
                MyPictureBox = grayHound1,
                StartingPosition = grayHound1.Left,
                RacetrackLength = racetrack.Width - grayHound1.Width,
                Randomizer = MyRandomizer
            };

            grayHoundArray[1] = new GrayHound()
            {
                MyPictureBox = grayHound2,
                StartingPosition = grayHound2.Left,
                RacetrackLength = racetrack.Width - grayHound2.Width,
                Randomizer = MyRandomizer
            };

            grayHoundArray[2] = new GrayHound()
            {
                MyPictureBox = grayHound3,
                StartingPosition = grayHound3.Left,
                RacetrackLength = racetrack.Width - grayHound3.Width,
                Randomizer = MyRandomizer
            };

            grayHoundArray[3] = new GrayHound()
            {
                MyPictureBox = grayHound4,
                StartingPosition = grayHound4.Left,
                RacetrackLength = racetrack.Width - grayHound4.Width,
                Randomizer = MyRandomizer
            };

            guyArray[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyBet = null,
                MyLabel = joeBetLabel,
                MyRadioButton = joeRadioButton
            };


            guyArray[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyBet = null,
                MyLabel = bobBetLabel,
                MyRadioButton = bobRadioButton
            };

            guyArray[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyBet = null,
                MyLabel = alBetLabel,
                MyRadioButton = alRadioButton
            };

            for (int i = 0; i < guyArray.Length;  i++)
            {
                guyArray[i].MyBet = new Bet() { Bettor = this.guyArray[i] };
                guyArray[i].ClearBet();
                guyArray[i].Updatelabels();
            }

            name.Text = guyArray[0].Name;
        }
        Random MyRandomizer = new Random();
        GrayHound[] grayHoundArray = new GrayHound[4];
        Guy[] guyArray = new Guy[3];
          
        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked==true)
            {
                name.Text = guyArray[0].Name; 
            }
        }


        private void race_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled=false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < grayHoundArray.Length; i++)
            {
                if (grayHoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show($"Dog #{i+1} Won the race");

                    for (int x = 0; x < guyArray.Length; x++)
                    {
                        guyArray[x].Collect(i+1);
                    }

                    for (int y = 0; y < grayHoundArray.Length; y++)
                    {
                        grayHoundArray[y].TakeStartingPosition();
                    }
                    groupBox1.Enabled = true;
                    return;
                }
            }
        }

   
        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guyArray[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guyArray[2].Name;
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < guyArray.Length; i++)
            {
                if (guyArray[i].MyRadioButton.Checked)
                {
                    guyArray[i].PlaceBet((int) placeBetAmount.Value, (int)selectDog.Value);
                }
            }
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
