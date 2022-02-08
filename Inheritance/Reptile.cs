using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animals
    {
        public Reptile()
        {

        }
        
        public Reptile(string name, string colors, bool hasLegs, int length, string country, string diet, int life, bool domesticated)
        {
            ReptileName = name;
            ScaleColors = colors;
            HasLegs = hasLegs;
            LengthInches = length;
            CountryofOrigin = country;
            Diet = diet;
            LifeExpectancy = life;
            Domesticated = domesticated;
        }

        public string ReptileName { get; set; }
        public string ScaleColors { get; set; }
        public bool HasLegs { get; set; }
        public int LengthInches { get; set; }
    }
}
