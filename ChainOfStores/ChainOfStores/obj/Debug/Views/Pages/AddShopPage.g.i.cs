﻿#pragma checksum "..\..\..\..\Views\Pages\AddShopPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BB68DDB1F97773C7AD6BBAE43D0436DD7D659CD2E57A6B920A4C093BFDA95928"
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
    /// AddShopPage
    /// </summary>
    public partial class AddShopPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Views\Pages\AddShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddShopNameTBX;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\Pages\AddShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddShopAddressTBX;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\Pages\AddShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddShopNumberShopTBX;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\Pages\AddShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddAuthorizedCapitalShopTXB;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Views\Pages\AddShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AddShopOwner;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\Pages\AddShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AddShopPprofile;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Views\Pages\AddShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button returnAddShopPage;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Views\Pages\AddShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addOwner;
        
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
            System.Uri resourceLocater = new System.Uri("/ChainOfStores;component/views/pages/addshoppage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\AddShopPage.xaml"
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
            this.AddShopNameTBX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AddShopAddressTBX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AddShopNumberShopTBX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AddAuthorizedCapitalShopTXB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddShopOwner = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.AddShopPprofile = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.returnAddShopPage = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\Views\Pages\AddShopPage.xaml"
            this.returnAddShopPage.Click += new System.Windows.RoutedEventHandler(this.returnAddShopPage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.addOwner = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Views\Pages\AddShopPage.xaml"
            this.addOwner.Click += new System.Windows.RoutedEventHandler(this.addOwner_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

