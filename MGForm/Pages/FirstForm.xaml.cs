﻿using MGForm.Models;
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
                var data = JsonConvert.DeserializeObject<WitnessContacts>(t);
                DisplayAlert("MG11 form", "The Statement has been saved!", "Close");
            });
            this.hybridWebView.LoadFromContent("Html/Form.html");
        }
    }

    

}
