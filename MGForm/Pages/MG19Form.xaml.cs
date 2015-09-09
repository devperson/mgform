using MGForm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MGForm.Pages
{
    public partial class MG19Form : ContentPage
    {
        public MG19Form()
        {
            InitializeComponent();

            btnShowMsg.Clicked += (s, e) =>
            {
                this.hybridWebView.CallJsFunction("onSaveData");
            };

            this.hybridWebView.RegisterCallback("dataCallback", t =>
            {
                var witnessContacts = JsonConvert.DeserializeObject<Compensation>(t);

                DisplayAlert("MG19 form", "The Statement has been saved!", "Close");
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            this.hybridWebView.LoadFromContent("Html/MG19-Form.html");
        }
    }
}
