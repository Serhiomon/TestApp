﻿#pragma checksum "..\..\AdminPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C49DEE3266F6EBE5B85AAE4D189C779758B9E882582EA266E39D475BAEEC8DD3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TestingApp;


namespace TestingApp {
    
    
    /// <summary>
    /// AdminPage
    /// </summary>
    public partial class AdminPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StatBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateQ21;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditQ;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy2;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateQ;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy4;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy5;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Setting;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close;
        
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
            System.Uri resourceLocater = new System.Uri("/TestingApp;component/adminpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminPage.xaml"
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
            this.StatBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.CreateQ21 = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.EditQ = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.button_Copy2 = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.CreateQ = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\AdminPage.xaml"
            this.CreateQ.Click += new System.Windows.RoutedEventHandler(this.CreateQ_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_Copy4 = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.button_Copy5 = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Setting = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\AdminPage.xaml"
            this.Setting.Click += new System.Windows.RoutedEventHandler(this.Setting_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Close = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\AdminPage.xaml"
            this.Close.Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
