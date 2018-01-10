using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using CrossMvvmFristApp.Core.ViewModels;
using Xamarin.Forms;

namespace CrossMvvmFristApp.Core.Pages
{
    public partial class MainPage : MvxContentPage<MainViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
