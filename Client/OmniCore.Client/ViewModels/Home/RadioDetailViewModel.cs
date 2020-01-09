﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using OmniCore.Client.Models;
using OmniCore.Client.ViewModels.Base;
using OmniCore.Model.Interfaces.Common;

namespace OmniCore.Client.ViewModels.Home
{
    public class RadioDetailViewModel : BaseViewModel<IRadio>
    {
        public RadioModel Radio { get; set; }

        public RadioDetailViewModel(ICoreClient client) : base(client)
        {
        }

        public override Task OnInitialize(IRadio parameter)
        {
            Radio = new RadioModel(parameter);
            return Task.CompletedTask;
        }
    }
}
