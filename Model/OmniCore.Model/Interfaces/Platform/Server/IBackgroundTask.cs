﻿using System;
using System.Threading.Tasks;
using OmniCore.Model.Interfaces;

namespace OmniCore.Model.Interfaces
{
    public interface IBackgroundTask : IDisposable, IServerResolvable
    {
        Task<bool> Run(bool tryRunUninterrupted = false);
        Task<bool> RunScheduled(DateTimeOffset time, bool tryRunUninterrupted = false);
        bool IsScheduled { get; }
        DateTimeOffset ScheduledTime { get; }
        Task<bool> CancelScheduledWait();
    }
}
