﻿#pragma checksum "..\..\Option.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6E7E514B39B137EB9DD593386C205859"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Org.Zpf.XFeiCards.UI.Implement;
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


namespace Org.Zpf.XFeiCards.UI.Implement {
    
    
    /// <summary>
    /// Option
    /// </summary>
    public partial class Option : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\Option.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox playGame;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Option.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox numberOfPlayer;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Option.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DumbRadioButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Option.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton GoodRadioButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Option.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CheatsRadioButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Option.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Option.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Org.Zpf.XFeiCards.UI.Implement;component/option.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Option.xaml"
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
            this.playGame = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.numberOfPlayer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.DumbRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 42 "..\..\Option.xaml"
            this.DumbRadioButton.Checked += new System.Windows.RoutedEventHandler(this.DumbRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GoodRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 43 "..\..\Option.xaml"
            this.GoodRadioButton.Checked += new System.Windows.RoutedEventHandler(this.GoodRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CheatsRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 44 "..\..\Option.xaml"
            this.CheatsRadioButton.Checked += new System.Windows.RoutedEventHandler(this.CheatsRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\Option.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\Option.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.okButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
