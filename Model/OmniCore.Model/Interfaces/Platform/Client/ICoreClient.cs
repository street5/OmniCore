﻿using System;
using System.Threading;
using System.Threading.Tasks;
using OmniCore.Model.Interfaces.Platform.Common;
using OmniCore.Model.Interfaces.Platform.Client;

namespace OmniCore.Model.Interfaces.Platform.Common
{
    public interface ICoreClient : ICoreClientFunctions
    {
        ICoreContainer<IClientResolvable> ClientContainer { get; }
        IViewPresenter ViewPresenter { get; }
        ICoreClientConnection ClientConnection { get; }
        SynchronizationContext SynchronizationContext { get; }
        IDisposable DisplayKeepAwake();
    }
}