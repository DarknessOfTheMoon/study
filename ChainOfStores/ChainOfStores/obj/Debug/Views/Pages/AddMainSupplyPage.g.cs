﻿#pragma checksum "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E89B37D784EF61E57FC9EAC1B55FC1E3A53FE379D80019237597DE61D06CB856"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ChainOfStores.Views.Pages;
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


namespace ChainOfStores.Views.Pages {
    
    
    /// <summary>
    /// AddMainSupplyPage
    /// </summary>
    public partial class AddMainSupplyPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addMainSupplyBTN;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddInProviderBTN;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddInOwnerBTN;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddShopBTN;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button returnInChoisePage;
        
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
            System.Uri resourceLocater = new System.Uri("/ChainOfStores;component/views/pages/addmainsupplypage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
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
            this.addMainSupplyBTN = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
            this.addMainSupplyBTN.Click += new System.Windows.RoutedEventHandler(this.addMainSupplyBTN_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddInProviderBTN = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
            this.AddInProviderBTN.Click += new System.Windows.RoutedEventHandler(this.AddInProviderBTN_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddInOwnerBTN = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
            this.AddInOwnerBTN.Click += new System.Windows.RoutedEventHandler(this.AddInOwnerBTN_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddShopBTN = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
            this.AddShopBTN.Click += new System.Windows.RoutedEventHandler(this.AddShopBTN_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.returnInChoisePage = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Views\Pages\AddMainSupplyPage.xaml"
            this.returnInChoisePage.Click += new System.Windows.RoutedEventHandler(this.returnInChoisePage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

