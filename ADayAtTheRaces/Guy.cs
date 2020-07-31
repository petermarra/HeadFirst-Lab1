using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Guy
    {
        public string Name; // the guys name
        public Bet MyBet; //an instance of the Bet that has his bet
        public int Cash; //how much cash he has

        //the last two files are the guys GUI controls on the form
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public  void Updatelabels()
        {
             MyLabel.Text = MyBet.GetDescription();
            // radio button to show my cash ("joe has 43 bucks")
            MyRadioButton.Text = $"{Name} has {Cash} bucks";
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;       }

        public bool PlaceBet(int betAmount,int dogToWin)
        {
            MyBet = new Bet() { Amount = betAmount, Dog = dogToWin, Bettor = this };
            Updatelabels(); 
            if (MyBet.Amount == 0)
            {
                return false;
            }
            return true;
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            Updatelabels();
            //ask my bet to pay out, clear my bet and update my lables
            // the key here is to yous the bet object...let it do the work
        }
    }
}
