using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ras4etka
{
    public class Alt //public class for alts
    {
        private int AltID;
        private string AltName;

        public Alt(int ID, string Name)
        {
            AltID = ID;
            AltName = Name;
        }
        public string GetName()
        {
            return this.AltName;
        }
        public int GetID()
        {
            return this.AltID;
        }
            
    }
}
