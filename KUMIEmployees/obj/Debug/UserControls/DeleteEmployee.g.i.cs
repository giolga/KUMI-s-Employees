﻿#pragma checksum "..\..\..\UserControls\DeleteEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62CFDDF7BFD7DFD62253C0EB6281BE52F3E389131803960AEEBFD421FDE05EAC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KUMIEmployees.UserControls;
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


namespace KUMIEmployees.UserControls {
    
    
    /// <summary>
    /// DeleteEmployee
    /// </summary>
    public partial class DeleteEmployee : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\UserControls\DeleteEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal KUMIEmployees.UserControls.DeleteEmployee DeleteEmployeeUC;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\UserControls\DeleteEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProfilePicture;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UserControls\DeleteEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmployeeId;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UserControls\DeleteEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchBtn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\UserControls\DeleteEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid InfoGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/KUMIEmployees;component/usercontrols/deleteemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\DeleteEmployee.xaml"
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
            this.DeleteEmployeeUC = ((KUMIEmployees.UserControls.DeleteEmployee)(target));
            return;
            case 2:
            this.ProfilePicture = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.EmployeeId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SearchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\UserControls\DeleteEmployee.xaml"
            this.SearchBtn.Click += new System.Windows.RoutedEventHandler(this.SearchBtn_Click);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\UserControls\DeleteEmployee.xaml"
            this.SearchBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.SearchBtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\UserControls\DeleteEmployee.xaml"
            this.SearchBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.SearchBtn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.InfoGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

