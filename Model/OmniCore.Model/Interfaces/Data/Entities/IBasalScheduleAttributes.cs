﻿using System;
using System.Collections.Generic;

namespace OmniCore.Model.Interfaces.Common.Data.Entities
{
    public interface IBasalScheduleAttributes
    {
        IList<(TimeSpan start, decimal hourlyRate)> Schedule { get; set; }
    }
}
