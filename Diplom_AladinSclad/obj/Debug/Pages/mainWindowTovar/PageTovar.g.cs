#pragma checksum "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7B4A2F72CCE3DA24EEFC074C86282BD8E88E175FFEE63CE6DD42826C412DC224"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Diplom_AladinSclad.Pages.mainWindowTovar;
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


namespace Diplom_AladinSclad.Pages.mainWindowTovar {
    
    
    /// <summary>
    /// PageTovar
    /// </summary>
    public partial class PageTovar : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 9 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Diplom_AladinSclad.Pages.mainWindowTovar.PageTovar window;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid userTabel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTovar;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RedacTovar;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteTovar;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Diplom_AladinSclad;component/pages/mainwindowtovar/pagetovar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
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
            this.window = ((Diplom_AladinSclad.Pages.mainWindowTovar.PageTovar)(target));
            return;
            case 2:
            this.userTabel = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.AddTovar = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
            this.AddTovar.Click += new System.Windows.RoutedEventHandler(this.AddTovar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RedacTovar = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
            this.RedacTovar.Click += new System.Windows.RoutedEventHandler(this.RedacTovar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteTovar = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
            this.DeleteTovar.Click += new System.Windows.RoutedEventHandler(this.DeleteTovar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 42 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\..\Pages\mainWindowTovar\PageTovar.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

