﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tizen.Wearable.CircularUI.Forms;
using xamarinExample.Tizen.ViewModels;
using xamarinExample.Models;

namespace xamarinExample.Tizen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BunchPage : CirclePage
    {
        public BunchPage(Bunch bunch)
        {
            InitializeComponent();
            BindingContext = new BunchPageModel(Navigation, bunch);
        }
    }
}