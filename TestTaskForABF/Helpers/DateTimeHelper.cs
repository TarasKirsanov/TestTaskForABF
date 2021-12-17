using System;

namespace TestTaskForABF.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime ConvertUnixTimeToDateTime(long unixTime) => (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(unixTime);
    }
}