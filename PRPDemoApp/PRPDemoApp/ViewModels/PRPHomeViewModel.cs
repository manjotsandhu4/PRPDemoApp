using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PRPDemoApp.Infrastructure;

namespace PRPDemoApp.ViewModels
{
    public class PRPHomeViewModel : AppMapViewModelBase
    {


        public PRPHomeViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
