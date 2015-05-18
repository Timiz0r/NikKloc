using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikKloc.Alarm
{
    public interface IAlarmCoordinator
    {
        IEnumerable<IAlarmState> Alarms { get; }

        void EnableAlarm(IAlarm alarm);

        void DisableAlarm(IAlarm alarm);

        event EventHandler<AlarmTriggeredEventArgs> AlarmTriggered;
    }
}
