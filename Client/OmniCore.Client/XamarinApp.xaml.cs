﻿using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Nito.AsyncEx.Synchronous;
using OmniCore.Client.ViewModels.Base;
using OmniCore.Client.Views.Main;
using OmniCore.Model.Enumerations;
using OmniCore.Model.Interfaces.Common;
using Xamarin.Forms;

namespace OmniCore.Client
{
    public partial class XamarinApp : Application, IClientResolvable
    {
        private readonly ICoreClient Client;
        public XamarinApp(ICoreClient client)
        {
            Client = client;
            InitializeComponent();
            MainPage = Client.GetView<ShellView, ShellViewModel>();
        }
    }
}
