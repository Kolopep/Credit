﻿#pragma checksum "..\..\..\LoanGrid.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FE71A1C96AE31626583FA3AFB512137598FB4F1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LoanCalculator;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace LoanCalculator {
    
    
    /// <summary>
    /// LoanGrid
    /// </summary>
    public partial class LoanGrid : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\LoanGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid LoanDataGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\LoanGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBSumLoan;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\LoanGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBSumDay;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\LoanGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBAllSumLoan;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\LoanGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBProcentSum;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\LoanGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBEffectiveBid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LoanCalculator;component/loangrid.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoanGrid.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LoanDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.TBSumLoan = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TBSumDay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TBAllSumLoan = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TBProcentSum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TBEffectiveBid = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
