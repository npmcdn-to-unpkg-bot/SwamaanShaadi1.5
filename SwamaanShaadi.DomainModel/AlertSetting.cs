using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainModel
{
    public class AlertSetting
    {
        public int AccountSettingId { get; set; }
        public int NoOfMatchesToSendInEachRun { get; set; }
        public int SMSStatusCheckWaitTime { get; set; }
    }
}
