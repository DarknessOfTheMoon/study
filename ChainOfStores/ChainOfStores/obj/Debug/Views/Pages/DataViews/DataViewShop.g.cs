﻿#pragma checksum "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3F05D53A27FB80DA1997F3AF6B8EC29DDF6AFEB80D23E1AD74DA23B271A75FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ChainOfStores.Views.Pages.DataViews;
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


namespace ChainOfStores.Views.Pages.DataViews {
    
    
    /// <summary>
    /// DataViewShop
    /// </summary>
    public partial class DataViewShop : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTBX;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBTN;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBTN;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataViewAddShop;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button returnDataViewPageinChoicePage;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextPageFour;
        
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
            System.Uri resourceLocater = new System.Uri("/ChainOfStores;component/views/pages/dataviews/dataviewshop.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
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
            
            #line 7 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
            ((ChainOfStores.Views.Pages.DataViews.DataViewShop)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchTBX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DeleteBTN = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
            this.DeleteBTN.Click += new System.Windows.RoutedEventHandler(this.DeleteBTN_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EditBTN = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
            this.EditBTN.Click += new System.Windows.RoutedEventHandler(this.EditBTN_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DataViewAddShop = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.returnDataViewPageinChoicePage = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
            this.returnDataViewPageinChoicePage.Click += new System.Windows.RoutedEventHandler(this.returnDataViewPageinChoicePage_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NextPageFour = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\..\Views\Pages\DataViews\DataViewShop.xaml"
            this.NextPageFour.Click += new System.Windows.RoutedEventHandler(this.NextPageFour_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
