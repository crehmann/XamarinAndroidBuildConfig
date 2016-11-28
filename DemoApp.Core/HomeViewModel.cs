using GalaSoft.MvvmLight;
using System;

namespace DemoApp.Core
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly IDefaultConfiguration _defaultConfiguration;

        public HomeViewModel(IDefaultConfiguration defaultConfiguration)
        {
            if (defaultConfiguration == null) throw new ArgumentNullException(nameof(defaultConfiguration));
            _defaultConfiguration = defaultConfiguration;
        }

        public string EndpointText => $"This app uses {_defaultConfiguration.ApiBaseUrl} as API url";
    }
}
