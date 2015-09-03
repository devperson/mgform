using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XLabs.Forms;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Mvvm;
using XLabs.Serialization;
using XLabs.Serialization.ServiceStack;


namespace MGForm.Droid
{
	[Activity (Label = "MGForm.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : XFormsApplicationDroid
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}


        /// <summary>
        /// Sets the IoC.
        /// </summary>
        private void SetIoc()
        {
            var resolverContainer = new SimpleContainer();

            var app = new XFormsAppDroid();
            app.Init(this);

            resolverContainer.Register<IDevice>(t => AndroidDevice.CurrentDevice).Register<IDisplay>(t => t.Resolve<IDevice>().Display).Register<IJsonSerializer, JsonSerializer>().Register<IDependencyContainer>(resolverContainer).Register<IXFormsApp>(app);

            Resolver.SetResolver(resolverContainer.GetResolver());

        }
	}
}

