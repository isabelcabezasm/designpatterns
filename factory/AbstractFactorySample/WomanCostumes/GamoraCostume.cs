using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AbstractFactorySample
{
    public class GamoraCostume : IWomanCostume
    {
        public string Suit { get => "Read leather suit with boots"; }
        public string Hairstyle { get => "Black and pink wig"; }
        public List<string> Accessories { get => new List<string>() { "Sward" }; }

        public string AssembleCostume()
        {
            string result = $"> Gamora's costume:\n{Suit},\n{Hairstyle}.\nThis is the list of accessories: ";
            foreach(var item in Accessories)
                result += $"{item} ";

            return result;
        }
    }
}
