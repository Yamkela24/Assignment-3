using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class House
    {
        private int NoOfDoors;
        private bool HasFurniture;
        private int HasWindows;
        private string WhatColourIsIt;

        public House(int noOfDoors, bool hasFurniture, int hasWindows, string whatColourIsIt) 
        { 
            NoOfDoors = noOfDoors;
            HasFurniture = hasFurniture;
            HasWindows = hasWindows;
            WhatColourIsIt = whatColourIsIt;

        
        
        }
        public int GetDoors()
        { 
             return NoOfDoors; 
        }
        public bool GetFurniture()
        {
            return HasFurniture;
        }
        public int GetWindows()
        {
            return HasWindows;
        }
        public string GetColour()
        {
            return WhatColourIsIt;
        }
    }
    
}
