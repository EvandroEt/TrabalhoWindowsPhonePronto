﻿#pragma checksum "C:\Users\evandro\Desktop\WebServiceExampleApp-master\WebServiceExampleApp-master\WebServiceExampleApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7DC1CD4681C3C394392F320A0BE51175"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WebServiceExampleApp {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtPincode;
        
        internal System.Windows.Controls.Button btnGetData;
        
        internal System.Windows.Controls.ProgressBar pbWeather;
        
        internal System.Windows.Controls.StackPanel spWeatherInfo;
        
        internal System.Windows.Controls.TextBlock txtCity;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebServiceExampleApp;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtPincode = ((System.Windows.Controls.TextBox)(this.FindName("txtPincode")));
            this.btnGetData = ((System.Windows.Controls.Button)(this.FindName("btnGetData")));
            this.pbWeather = ((System.Windows.Controls.ProgressBar)(this.FindName("pbWeather")));
            this.spWeatherInfo = ((System.Windows.Controls.StackPanel)(this.FindName("spWeatherInfo")));
            this.txtCity = ((System.Windows.Controls.TextBlock)(this.FindName("txtCity")));
        }
    }
}

