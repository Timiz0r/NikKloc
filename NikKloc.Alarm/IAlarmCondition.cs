using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikKloc.Alarm
{
    public interface IAlarmCondition
    {
        DateTime GetNextValidTime(DateTime fromTime);

        bool IsMatch(DateTime time);

        AlarmConditionScope Scope { get; }

        string Description { get; }
    }
}
