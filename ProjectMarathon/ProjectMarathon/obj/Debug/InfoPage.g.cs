﻿#pragma checksum "..\..\InfoPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "59CBDEF81294E99990C49E77485DDE04756877147C4FE424E815BCE9FAF7B7A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjectMarathon;
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


namespace ProjectMarathon {
    
    
    /// <summary>
    /// InfoPage
    /// </summary>
    public partial class InfoPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Marathon;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Result;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BMI;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button time;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Organizac;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BMR;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Navigation;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectMarathon;component/infopage.xaml", System.UriKind.Relative);
            
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
            this.Marathon = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\InfoPage.xaml"
            this.Marathon.Click += new System.Windows.RoutedEventHandler(this.Marathon_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Result = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\InfoPage.xaml"
            this.Result.Click += new System.Windows.RoutedEventHandler(this.Result_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BMI = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\InfoPage.xaml"
            this.BMI.Click += new System.Windows.RoutedEventHandler(this.BMI_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.time = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\InfoPage.xaml"
            this.time.Click += new System.Windows.RoutedEventHandler(this.time_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Organizac = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\InfoPage.xaml"
            this.Organizac.Click += new System.Windows.RoutedEventHandler(this.Organizac_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BMR = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\InfoPage.xaml"
            this.BMR.Click += new System.Windows.RoutedEventHandler(this.BMR_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\InfoPage.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Navigation = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

