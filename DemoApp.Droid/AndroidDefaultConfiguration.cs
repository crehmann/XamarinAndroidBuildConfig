using Android.App;
using DemoApp.Core;

namespace DemoApp.Droid
{
    internal class AndroidDefaultConfiguration : IDefaultConfiguration
    {
        public string ApiBaseUrl => Application.Context.GetString(Resource.String.ApiBaseUrl);
    }
}