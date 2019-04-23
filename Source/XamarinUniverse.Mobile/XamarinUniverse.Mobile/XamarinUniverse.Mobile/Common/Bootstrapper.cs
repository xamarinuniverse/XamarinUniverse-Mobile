using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinUniverse.Mobile.Services;
using XamarinUniverse.Mobile.ViewModels;
//using Unity;
//using Unity.Lifetime;
//using Unity.ServiceLocation;

namespace XamarinUniverse.Mobile.Common
{
    public static class Bootstrapper
    {
        public static void RegisterDependencies()
        {
            //var container = new UnityContainer();

            //// service
            //container.RegisterType<WordpressService>(new ContainerControlledLifetimeManager());

            //// viewmodel
            //container.RegisterType<NewsViewModel>(new ContainerControlledLifetimeManager());
            //container.RegisterType<SettingsViewModel>(new ContainerControlledLifetimeManager());

            //var locator = new UnityServiceLocator(container);
           // ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}
