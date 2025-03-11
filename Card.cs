using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trials
{
    public class Card
    {
        //since there is immutable list so all the instances will have same data
        //would be also better to make the following lists as static , only one instance to exists
        private ImmutableList<string> Suits;
        private ImmutableList<string> Ranks;

         //public static ImmutableList<string> Suits { get; } = 
         //   ImmutableList.Create("Clubs", "Spades", "Diamonds", "Hearts");

        public Card()
        {
            Suits = ImmutableList<string>.Empty;
            //Suits = ImmutableList<string>.Empty.AddRange(new[] { "Clubs", "Spades", "Diamonds", "Hearts" });
            //or more concise
            Suits = ImmutableList.Create("Clubs", "Spades", "Diamonds", "Hearts");
            Ranks = ImmutableList<string>.Empty.AddRange(new[] 
            { "narf","Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King" });

        }


    }
}
