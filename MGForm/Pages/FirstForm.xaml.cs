using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Data;
using XLabs.Forms.Mvvm;


namespace MGForm.Pages
{
    public partial class FirstForm : ContentPage
    {
        public FirstForm()
        {
            InitializeComponent();

            btnShowMsg.Clicked += (s, e) =>
            {
                this.hybridWebView.CallJsFunction("onSaveData");
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.hybridWebView.RegisterCallback("dataCallback", t =>
            {
                var data = JsonConvert.DeserializeObject<SomeData>(t);
                DisplayAlert("Data from browser", string.Format("{0}, {1}, {2}, {3}", data.FirstTxt, data.SecondTxt, data.ThirdTxt, data.Fourth), "Close");
            });
            this.hybridWebView.LoadFromContent("test.html");
        }
    }

    public class SomeData
    {
        public string FirstTxt { get; set; }
        public string SecondTxt { get; set; }
        public string ThirdTxt { get; set; }
        public string Fourth { get; set; }
    }

}
