﻿#pragma checksum "..\..\View.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "092C0B6C55C470444A3A69556BCB9EB8E1D8FE5FA12AA080CB93AAB8AEFA683F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FINAL_POE_ST10082757;
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


namespace FINAL_POE_ST10082757 {
    
    
    /// <summary>
    /// View
    /// </summary>
    public partial class View : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Deletebtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem exitbtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Addbtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Steven;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Rbutton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox george;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Viwings;
        
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
            System.Uri resourceLocater = new System.Uri("/FINAL POE ST10082757;component/view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\View.xaml"
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
            this.Deletebtn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\View.xaml"
            this.Deletebtn.Click += new System.Windows.RoutedEventHandler(this.Deletebtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exitbtn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\View.xaml"
            this.exitbtn.Click += new System.Windows.RoutedEventHandler(this.exitbtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Addbtn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\View.xaml"
            this.Addbtn.Click += new System.Windows.RoutedEventHandler(this.Addbtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Steven = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Rbutton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\View.xaml"
            this.Rbutton.Click += new System.Windows.RoutedEventHandler(this.Rbutton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.george = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Viwings = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\View.xaml"
            this.Viwings.Click += new System.Windows.RoutedEventHandler(this.Viwings_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

