using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        private long guestRequestKey = 0;
        private string privateName;
        private string familyName;
        private string mailAddress;
        private GuestRequestStatus status;
        private DateTime registrationDate;
        private DateTime entryDate;
        private DateTime releaseDate;
        private Location area;
        private RequestType type;
        private int adults;
        private int children;
        private Wish pool;
        private Wish jacuzzi;
        private Wish garden;
        private Wish childrensAttractions;

        public long GuestRequestKey
        {
            get => guestRequestKey;
            set
            {
                if (guestRequestKey <= Configuration.EightDigits)
                    guestRequestKey = value;

                else
                    throw new IllegalAttemptException("GuestRequestKey value cannot be changed once initialized.");
            }
        }
        public string PrivateName { get => privateName; set => privateName = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public string MailAddress { get => mailAddress; set => mailAddress = value; }
        public GuestRequestStatus Status { get => status; set => status = value; }
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }
        public DateTime EntryDate { get => entryDate; set => entryDate = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public Location Area { get => area; set => area = value; }
        public RequestType Type { get => type; set => type = value; }
        public int Adults { get => adults; set => adults = value; }
        public int Children { get => children; set => children = value; }
        public Wish Pool { get => pool; set => pool = value; }
        public Wish Jacuzzi { get => jacuzzi; set => jacuzzi = value; }
        public Wish Garden { get => garden; set => garden = value; }
        public Wish ChildrensAttractions { get => childrensAttractions; set => childrensAttractions = value; }

        public override string ToString()
        {
            return "________________________________________"
                + "\nGuestRequestKey: " + GuestRequestKey + "\nPrivateName: " + PrivateName
                + "\nFamilyName: " + FamilyName + "\nMailAddress: " + MailAddress + "\nStatus: " + Status
                + "\nRegistrationDate: " + RegistrationDate + "\nEntryDate: " + EntryDate + "\nArea: " + Area
                + "\nType: " + Type + "\nAdults: " + Adults + "\nChildren: " + Children + "\nPool: " + Pool
                + "\nJacuzzi: " + Jacuzzi + "\nGarden: " + Garden + "\nChildrensAttractions: " + ChildrensAttractions
                + "\n________________________________________";
        }

        //public GuestRequest() { }
        //public GuestRequest(long _GuestRequestKey, string _PrivateName, string _FamilyName,
        //    string _MailAddress, GuestRequestStatus _Status, DateTime _RegistrationDate,
        //    DateTime _EntryDate, DateTime _ReleaseDate, Location _Area, RequestType _Type,
        //    int _Adults, int _Children, Wish _Pool, Wish _Jacuzzi, Wish _Garden, Wish _ChildrensAttractions)
        //{
        //    GuestRequestKey = _GuestRequestKey;
        //    PrivateName = _PrivateName;
        //    FamilyName = _FamilyName;
        //    MailAddress = _MailAddress;
        //    Status = _Status;
        //    RegistrationDate = _RegistrationDate;
        //    EntryDate = _EntryDate;
        //    ReleaseDate = _ReleaseDate;
        //    Area = _Area;
        //    Type = _Type;
        //    Adults = _Adults;
        //    Children = _Children;
        //    Pool = _Pool;
        //    Jacuzzi = _Jacuzzi;
        //    Garden = _Garden;
        //    ChildrensAttractions = _ChildrensAttractions;
        //}
    }
}
