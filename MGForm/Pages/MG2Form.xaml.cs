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
    public partial class MG2Form : ContentPage
    {
        public MG2Form()
        {
            InitializeComponent();

            btnShowMsg.Clicked += (s, e) =>
            {
                this.hybridWebView.CallJsFunction("onSaveData");
            };

            this.hybridWebView.RegisterCallback("dataCallback", t =>
            {
                var witnessContacts = JsonConvert.DeserializeObject<WitnessMesureDetails>(t);

                DisplayAlert("MG11 form", "The Statement has been saved!", "Close");
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            this.hybridWebView.LoadFromContent("Html/MG2-Form.html");
        }
    }
}
