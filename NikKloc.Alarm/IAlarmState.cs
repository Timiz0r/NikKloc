using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikKloc.Alarm
{
    public interface IAlarmState
    {
        IAlarm Alarm { get; }

        DateTime NextTriggerTime { get; }

        bool Enabled { get; set; }
    }
}
