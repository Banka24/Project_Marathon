﻿#pragma checksum "..\..\AuthorizationRunnerPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "054B2CB2CB9DE7FA0AAE6FBAE0116E1213F0F702426E57A6F0C35B797241CD03"
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
    /// AuthorizationRunnerPage
    /// </summary>
    public partial class AuthorizationRunnerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\AuthorizationRunnerPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ProjectMarathon;component/authorizationrunnerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AuthorizationRunnerPage.xaml"
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
            
            #line 47 "..\..\AuthorizationRunnerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Confirm);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 52 "..\..\AuthorizationRunnerPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Navigation = ((System.Windows.Controls.Frame)(target));
            
            #line 54 "..\..\AuthorizationRunnerPage.xaml"
            this.Navigation.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.Navigation_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

