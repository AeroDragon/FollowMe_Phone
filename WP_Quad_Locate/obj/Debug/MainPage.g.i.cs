﻿#pragma checksum "C:\Arduino\WP_Quad_Locate\WP_Quad_Locate\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F31381085EC2761BFD0D23C19CE333F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
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


namespace WP_Quad_Locate {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button TrackLocationButton;
        
        internal System.Windows.Controls.TextBlock LatitudeTextBlock;
        
        internal System.Windows.Controls.TextBlock LongitudeTextBlock;
        
        internal System.Windows.Controls.TextBlock StatusTextBlock;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WP_Quad_Locate;component/MainPage.xaml", System.UriKind.Relative));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.TrackLocationButton = ((System.Windows.Controls.Button)(this.FindName("TrackLocationButton")));
            this.LatitudeTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("LatitudeTextBlock")));
            this.LongitudeTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("LongitudeTextBlock")));
            this.StatusTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("StatusTextBlock")));
        }
    }
}

