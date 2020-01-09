﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OmniCore.Model.Interfaces.Common.Data;
using OmniCore.Model.Interfaces.Common;
using OmniCore.Model.Interfaces.Common.Data.Entities;

namespace OmniCore.Model.Interfaces.Common
{
    public interface IPodService : ICoreService
    {
        IRadioService[] RadioProviders { get; }
        string Description { get; }
        IAsyncEnumerable<IPod> ActivePods();
        IAsyncEnumerable<IPod> ArchivedPods();
        Task<IPod> New(IUserEntity user, IMedicationEntity medication, IList<IRadioEntity> radios);
        Task<IPod> Register(IPodEntity pod, IUserEntity user, IList<IRadioEntity> radios);
    }
}