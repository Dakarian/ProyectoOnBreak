﻿#pragma checksum "..\..\..\Vistas\ListarCliente.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B33D85FBBD546E59179545AE9D271C98"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls;
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
using System.Windows.Interactivity;
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
using Vistas;


namespace Vistas {
    
    
    /// <summary>
    /// ListarCliente
    /// </summary>
    public partial class ListarCliente : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Vistas\ListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgridCliente;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Vistas\ListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Actualizar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Vistas\ListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRut;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Vistas\ListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolver;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Vistas\ListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Vistas\ListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Vistas\ListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmpresa;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Vistas\ListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTraspasar;
        
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
            System.Uri resourceLocater = new System.Uri("/Vistas;component/vistas/listarcliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vistas\ListarCliente.xaml"
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
            this.dgridCliente = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.btn_Actualizar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Vistas\ListarCliente.xaml"
            this.btn_Actualizar.Click += new System.Windows.RoutedEventHandler(this.btn_Actualizar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtRut = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Vistas\ListarCliente.xaml"
            this.txtRut.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtRut_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnVolver = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Vistas\ListarCliente.xaml"
            this.btnVolver.Click += new System.Windows.RoutedEventHandler(this.BtnVolver_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Vistas\ListarCliente.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Vistas\ListarCliente.xaml"
            this.txtNombre.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtEmpresa = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Vistas\ListarCliente.xaml"
            this.txtEmpresa.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnTraspasar = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Vistas\ListarCliente.xaml"
            this.btnTraspasar.Click += new System.Windows.RoutedEventHandler(this.btnTraspasar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

