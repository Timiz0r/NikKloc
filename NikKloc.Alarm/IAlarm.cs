using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikKloc.Alarm
{
    public interface IAlarm
    {
        IEnumerable<IAlarmCondition> Conditions { get; }
    }
}
