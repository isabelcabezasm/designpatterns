using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FactoryMethodSample
{
    public class CaptainAmericaCostume : ICostume
    {
        public string Suit { get => "Blue Suit with a star"; }
        public string Boots { get => "Blue boots"; }
        public string Mask { get => "Blue mask"; }
        public List<string> Accessories { get => new List<string>() { "Shield" }; }

        public string AssembleCostume()
        {
            string result = $"> Captain America's costume:\n{Suit},\n{Boots}\n{Mask}.\nThis is the list of accessories: ";
            foreach(var item in Accessories)
                result += $"{item} ";

            return result;
        }
    }
}
