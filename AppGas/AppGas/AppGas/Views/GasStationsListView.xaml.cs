﻿using AppGas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppGas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GasStationsListView : ContentPage
    {
        public GasStationsListView()
        {
            InitializeComponent();

            BindingContext = new GasStationsListViewModel();
        }
    }
}