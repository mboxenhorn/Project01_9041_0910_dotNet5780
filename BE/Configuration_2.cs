using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Configuration
    {
        public const int NumOfDaysInMonth = 31;
        public const int NumOfMonthsInYear = 12;
        public const long EightDigits = 10000000;
        public const int CommissionNIS = 10;

        private static int serialBankNumber = 0;
        public static int SerialBankNumber
        {
            get => serialBankNumber;
            private set => serialBankNumber = value;
        }

        private static long serialGuestRequestKey = EightDigits;
        public static long SerialGuestRequestKey
        {
            get => serialGuestRequestKey;
            private set => serialGuestRequestKey = value;
        }

        private static long serialHostKey = EightDigits;
        public static long SerialHostKey
        {
            get => serialHostKey;
            private set => serialHostKey = value;
        }

        private static long serialHostingUnitKey = EightDigits;
        public static long SerialHostingUnitKey
        {
            get => serialHostingUnitKey;
            private set => serialHostingUnitKey = value;
        }

        private static long serialOrderKey = EightDigits;
        public static long SerialOrderKey
        {
            get => serialOrderKey;
            private set => serialOrderKey = value;
        }

        public static void IncrementSerialBankNumber() { serialBankNumber++; }
        public static void IncrementSerialGuestRequestKey() { serialGuestRequestKey++; }
        public static void IncrementSerialHostKey() { serialHostKey++; }
        public static void IncrementSerialHostingUnitKey() { serialHostingUnitKey++; }
        public static void IncrementSerialOrderKey() { serialOrderKey++; }

    }
}
