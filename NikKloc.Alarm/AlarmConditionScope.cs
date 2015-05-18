using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikKloc.Alarm
{
    [Flags]
    public enum AlarmConditionScope
    {
        Unknown,
        Millisecond = 1,
        Second = 1 << 1,
        Minute = 1 << 2,
        Hour = 1 << 3,
        Day = 1 << 4,
        Month = 1 << 5,
        Year = 1 << 6,
    }
}
