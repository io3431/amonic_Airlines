﻿#pragma checksum "..\..\InfoPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "89DF9F291CB9A2D496755428190F7E8853405C56DA96F1975DB8FC5E05940BEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Amonic;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Amonic {
    
    
    /// <summary>
    /// InfoPage
    /// </summary>
    public partial class InfoPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectOffice;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridUser;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Amonic;component/infopage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InfoPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SelectOffice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\InfoPage.xaml"
            this.SelectOffice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectOffice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DGridUser = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.ChangeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\InfoPage.xaml"
            this.ChangeBtn.Click += new System.Windows.RoutedEventHandler(this.ChangeBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

