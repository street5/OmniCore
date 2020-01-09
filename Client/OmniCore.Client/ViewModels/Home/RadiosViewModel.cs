﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using OmniCore.Client.Models;
using OmniCore.Client.ViewModels.Base;
using OmniCore.Client.Views.Base;
using OmniCore.Client.Views.Home;
using OmniCore.Client.Views.Main;
using OmniCore.Model.Constants;
using OmniCore.Model.Interfaces.Common.Data;
using OmniCore.Model.Interfaces.Common;
using Xamarin.Forms;

namespace OmniCore.Client.ViewModels.Home
{
    public class RadiosViewModel : BaseViewModel
    {
        public ObservableCollection<RadioModel> Radios { get; set; }

        public ICommand SelectCommand { get; set; }



        private IDisposable ListRadiosSubscription;
        public RadiosViewModel(ICoreClient client) : base(client)
        {
            SelectCommand = new Command<RadioModel>(async rm => await SelectRadio(rm.Radio));
        }

        protected override Task OnInitialize()
        {
            Radios = new ObservableCollection<RadioModel>();
            ListRadiosSubscription = ServiceApi.RadioService.ListRadios()
                .ObserveOn(Client.SynchronizationContext)
                .Subscribe(radio =>
                    {
                        Radios.Add(new RadioModel(radio));
                    });
            return Task.CompletedTask;
        }

        protected override void OnDispose()
        {
            ListRadiosSubscription?.Dispose();
            ListRadiosSubscription = null;
        }

        private async Task SelectRadio(IRadio radio)
        {
            var view = Client.GetView<RadioDetailView,RadioDetailViewModel, IRadio>(radio);
            await Shell.Current.Navigation.PushAsync(view);
        }
    }
}
