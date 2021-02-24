using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SimpleFactorySample
{
    public class BlackWidowCostume : ICostume
    {
        public string Suit { get => "Black leather suit"; }
        public string Boots { get => "Black boots"; }
        public string Mask { get => "No mask"; }
        public List<string> Accessories { get => new List<string>() { "Guns" }; }

        public string AssembleCostume()
        {
            string result = $"> BlackWidow's costume:\n{Suit},\n{Boots},\n{Mask}.\nThis is the list of accessories: ";
            foreach(var item in Accessories)
                result += $"{item} ";

            return result;
        }
    }
}
