using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public   class GrayHound
    {
        public int StartingPosition; // where my pictureBox starts
        public int RacetrackLength; // how long the race track is
        public PictureBox MyPictureBox = null; // My picturebox object
        public int Location=0; //My location on the race track
        public Random Randomizer; // an instance of random

        public bool Run()
        {
            // move forwwaed either 1, 2, 3, or 4 spaces at random
            Location += Randomizer.Next(1, 4);
            MyPictureBox.Left = StartingPosition + Location;
            //update the position of m picturebox on the form lik this:
            //    Mypicturebox.left = Statringlocation + location;
            // return true if I won the race
            if (MyPictureBox.Left >= RacetrackLength)
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            // reset my location to 0 and my picture box object to starting position
            Location = 0;
            MyPictureBox.Left = StartingPosition;

        }
    }
}
