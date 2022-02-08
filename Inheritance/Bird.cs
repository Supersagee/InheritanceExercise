using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animals
    {
        public Bird()
        {

        }
        
        public Bird(string name, string colors, bool canFly, int wingSpan, string country, string diet, int life, bool domesticated)
        {
            BirdName = name;
            FeatherColors = colors;
            CanFly = canFly;
            WingSpanInches = wingSpan;
            CountryofOrigin = country;  
            Diet = diet;
            LifeExpectancy = life;
            Domesticated = domesticated;
        }

        public string BirdName { get; set; }
        public string FeatherColors { get; set; }
        public bool CanFly { get; set; }
        public int WingSpanInches { get; set; }


    }
}
