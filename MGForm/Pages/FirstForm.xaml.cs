using MGForm.Models;
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

            btnForm11.Clicked += (s, e) =>
            {
                this.Navigation.PushAsync(new MG11Form());
            };

            btnForm2.Clicked += (s, e) =>
            {
                this.Navigation.PushAsync(new MG2Form());
            };

            btnForm4A.Clicked += (s, e) =>
            {
                this.Navigation.PushAsync(new MG19Form());
            };
        }

       
    }

    

}
