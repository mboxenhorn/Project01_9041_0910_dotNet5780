using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HoustingUnit
    {
        private long hostingUnitKey = 0;
        private Host owner;
        private Location area;
        private bool[,] diary = 
            new bool[Configuration.NumOfMonthsInYear, Configuration.NumOfDaysInMonth];

        public long HostingUnitKey
        {
            get => hostingUnitKey;
            set
            {
                if (hostingUnitKey <= Configuration.EightDigits)
                    hostingUnitKey = value;

                else
                    throw new IllegalAttemptException("HostingUnitKey value cannot be changed once initialized.");
            }
        }
        public Host Owner { get => owner; set => owner = value; }
        public bool[,] Diary { get => diary; set => diary = value; }
        public Location Area { get => area; set => area = value; }

        public override string ToString()
        {
            return "========================================"
                + "\nHostingUnitKey: " + HostingUnitKey + "\nOwner: \n" + Owner + "\nArea: " + Area
                + "\n========================================";
        }

    }
}
