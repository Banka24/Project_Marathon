﻿#pragma checksum "..\..\NewMainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1E6E47FE138718C0B260988AF38A93037D5DD7316853E317E226E73EB92FB03E"
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
    /// NewMainWindow
    /// </summary>
    public partial class NewMainWindow : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\NewMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RunnerButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\NewMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SponsorRunnerButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\NewMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InfoButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\NewMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginPage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\NewMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblTimeUntilEvent;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\NewMainWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ProjectMarathon;component/newmainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewMainWindow.xaml"
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
            this.RunnerButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\NewMainWindow.xaml"
            this.RunnerButton.Click += new System.Windows.RoutedEventHandler(this.RunnerButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SponsorRunnerButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\NewMainWindow.xaml"
            this.SponsorRunnerButton.Click += new System.Windows.RoutedEventHandler(this.SponsorRunnerButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.InfoButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\NewMainWindow.xaml"
            this.InfoButton.Click += new System.Windows.RoutedEventHandler(this.InfoButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LoginPage = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\NewMainWindow.xaml"
            this.LoginPage.Click += new System.Windows.RoutedEventHandler(this.LoginPage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblTimeUntilEvent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Navigation = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

