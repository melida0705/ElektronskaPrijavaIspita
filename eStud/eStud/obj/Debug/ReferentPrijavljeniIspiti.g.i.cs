﻿#pragma checksum "..\..\ReferentPrijavljeniIspiti.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF5586CA0A4B0A91E65A041A218AC82A38218A135D39E0C3053C886F3D914288"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using eStud;


namespace eStud {
    
    
    /// <summary>
    /// ReferentPrijavljeniIspiti
    /// </summary>
    public partial class ReferentPrijavljeniIspiti : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ReferentPrijavljeniIspiti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid btnKreirajPrijavnicu;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ReferentPrijavljeniIspiti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tabelaPrijavljeniIspiti;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ReferentPrijavljeniIspiti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrijavnica;
        
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
            System.Uri resourceLocater = new System.Uri("/eStud;component/referentprijavljeniispiti.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReferentPrijavljeniIspiti.xaml"
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
            this.btnKreirajPrijavnicu = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.tabelaPrijavljeniIspiti = ((System.Windows.Controls.DataGrid)(target));
            
            #line 26 "..\..\ReferentPrijavljeniIspiti.xaml"
            this.tabelaPrijavljeniIspiti.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tabelaPrijavljeniIspiti_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnPrijavnica = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ReferentPrijavljeniIspiti.xaml"
            this.btnPrijavnica.Click += new System.Windows.RoutedEventHandler(this.btnPrijavnica_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

