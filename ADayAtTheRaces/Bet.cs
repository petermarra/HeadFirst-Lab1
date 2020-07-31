using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayAtTheRaces
{
    public class Bet
    {
        public int Amount; // the amount of cash that was bet
        public int Dog; //the number of the dog the bet is on
        public Guy Bettor; //the guy who placed the bet

        public string GetDescription()
        {
            if (Amount ==0 || Bettor.Cash < Amount )
            {
                Amount = 0;
                return $"{ Bettor.Name} hasn't placed a bet";
            }
            else
            {
                return $"{Bettor.Name} bets {Amount} on dog #{Dog}"; 
            }
          }
        
        public int PayOut(int winner)
        {
            if (Dog == winner)
            {
                return Amount;
            }
            else
            {
                return Amount*-1;
            }
        }
    }
}
