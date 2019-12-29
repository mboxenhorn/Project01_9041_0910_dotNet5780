using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum GuestRequestStatus
    {
        Active,
        Deal_closed_through_site,
        Deal_expired
    }

    public enum Location
    {
        All,
        North,
        South,
        Center
    }

    public enum RequestType
    {
        Tzimmer,
        Hotel,
        Camping
    }

    public enum Wish
    {
        Optional,
        Must_have,
        Must_not_have
    }

    public enum Agree
    {
        No,
        Yes
    }

    public enum OrderStatus
    {
        Not_yet_been_treated,
        Mail_sent,
        Closes_due_to_customer_unresponsiveness,
        Closes_due_to_customer_response
    }
}
