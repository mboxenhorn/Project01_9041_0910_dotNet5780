using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        private long hostKey = 0;
        private string privateName;
        private string familyName;
        private string fhoneNumber;
        private string mailAddress;
        private long bankAccountNumber;
        private BankBranch bankAccount;
        private Agree collectionClearance;

        public long HostKey
        {
            get => hostKey;
            set
            {
                if (hostKey <= Configuration.EightDigits)
                    hostKey = value;

                else
                    throw new IllegalAttemptException("HostKey value cannot be changed once initialized.");
            }
        }
        public string PrivateName { get => privateName; set => privateName = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public string FhoneNumber { get => fhoneNumber; set => fhoneNumber = value; }
        public string MailAddress { get => mailAddress; set => mailAddress = value; }
        public long BankAccountNumber { get => bankAccountNumber; set => bankAccountNumber = value; }
        public BankBranch BankAccount { get => bankAccount; set => bankAccount = value; }
        public Agree CollectionClearance { get => collectionClearance; set => collectionClearance = value; }

        public override string ToString()
        {
            return "****************************************"
                + "\nHostKey: " + HostKey + "\nPrivateName: " + PrivateName + "\nFamilyName: " + FamilyName
                + "\nFhoneNumber: " + FhoneNumber + "\nMailAddress: " + MailAddress + "\nBankAccountNumber:" 
                + BankAccountNumber + "\nbankAccount: \n" + bankAccount + "\nCollectionClearance: " + CollectionClearance
                + "\n****************************************";
        }
    }
}
