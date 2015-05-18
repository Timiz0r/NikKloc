using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikKloc.Alarm
{
    public class AlarmTriggeredEventArgs
    {
        public IAlarm Alarm { get; }

        public DateTime TriggerTime { get; }
    }
}