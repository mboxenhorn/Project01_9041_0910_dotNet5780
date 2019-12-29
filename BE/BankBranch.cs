using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BankBranch
    {
        private int bankNumber = 0;
        private string bankName;
        private int branchNumber;
        private string branchAddress;
        private string branchCity;

        public int BankNumber
        {
            get => bankNumber;
            set
            {
                if (bankNumber <= 0)
                    bankNumber = value;

                else
                    throw new IllegalAttemptException("BankNumber value cannot be changed once initialized.");
            }
        }
        public string BankName { get => bankName; set => bankName = value; }
        public int BranchNumber { get => branchNumber; set => branchNumber = value; }
        public string BranchAddress { get => branchAddress; set => branchAddress = value; }
        public string BranchCity { get => branchCity; set => branchCity = value; }

        public override string ToString()
        {
            return "----------------------------------------"
                + "\nBankNumber: " + BankNumber + "\nBankName: " + BankName
                + "\nBranchNumber: " + BranchNumber + "\nBranchAddress: " + BranchAddress
                + "\nBranchCity: " + BranchCity
                + "\n----------------------------------------";
        }
    }
}
