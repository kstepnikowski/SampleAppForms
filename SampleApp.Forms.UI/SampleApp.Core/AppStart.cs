﻿using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using SampleApp.Core.ViewModels;

namespace SampleApp.Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return Task.Run(() => { NavigationService.Navigate<LoginViewModel>(); });
        }
    }
}
