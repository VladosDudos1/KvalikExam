﻿#pragma checksum "..\..\..\Pages\CatalogPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8CF77FD8081770B637DBF27406D70510834C8D6A3180796D75E9C074F094FCA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CallShop.Pages;
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


namespace CallShop.Pages {
    
    
    /// <summary>
    /// CatalogPage
    /// </summary>
    public partial class CatalogPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Pages\CatalogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refreshCatalogBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\CatalogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backPhoneBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\CatalogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addClientBtn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\CatalogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvPhones;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Pages\CatalogPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button purchaseBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/CallShop;component/pages/catalogpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\CatalogPage.xaml"
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
            this.refreshCatalogBtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\CatalogPage.xaml"
            this.refreshCatalogBtn.Click += new System.Windows.RoutedEventHandler(this.refreshCatalogBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.backPhoneBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Pages\CatalogPage.xaml"
            this.backPhoneBtn.Click += new System.Windows.RoutedEventHandler(this.backPhoneBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\CatalogPage.xaml"
            this.addClientBtn.Click += new System.Windows.RoutedEventHandler(this.addClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lvPhones = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.purchaseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Pages\CatalogPage.xaml"
            this.purchaseBtn.Click += new System.Windows.RoutedEventHandler(this.purchaseBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

