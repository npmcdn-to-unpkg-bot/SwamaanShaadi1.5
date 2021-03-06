﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainClasses
{
    public class AlertSetting : IObjectWithState
    {
        public int AccountSettingId { get; set; }
        public int NoOfMatchesToSendInEachRun { get; set; }
        public int SMSStatusCheckWaitTime { get; set; }

        public State State { get; set; }
    }
}
