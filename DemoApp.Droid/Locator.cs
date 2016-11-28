using DemoApp.Core;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using System;

namespace DemoApp.Droid
{
    internal class Locator
    {
        private static Lazy<Locator> _instance = new Lazy<Locator>(() => new Locator());

        private Locator()
        {
            RegisterViewModels();
            RegisterServices();
        }

        public TViewModel GetViewModel<TViewModel>() where TViewModel : ViewModelBase
        {
            return SimpleIoc.Default.GetInstance<TViewModel>();
        }
        public static Locator Instance => _instance.Value;

        private void RegisterViewModels()
        {
            SimpleIoc.Default.Register<HomeViewModel>();
        }

        private void RegisterServices()
        {
            SimpleIoc.Default.Register<IDefaultConfiguration, AndroidDefaultConfiguration>();
        }
    }
}