﻿#pragma checksum "..\..\..\Pages\ViewerMenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "326E8DBBA975265A3D877EEDC1B499B423E344158E5765B8DA97607DC9DD0A34"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaraphonSkills.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MaraphonSkills.Pages {
    
    
    /// <summary>
    /// ViewerMenuPage
    /// </summary>
    public partial class ViewerMenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Pages\ViewerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border AddCommentButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\ViewerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CommentStatButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\ViewerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PageCountTextBlock;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\ViewerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PageDownButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\ViewerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PictureListView;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\ViewerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PageUpButton;
        
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
            System.Uri resourceLocater = new System.Uri("/MaraphonSkills;component/pages/viewermenupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ViewerMenuPage.xaml"
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
            this.AddCommentButton = ((System.Windows.Controls.Border)(target));
            
            #line 15 "..\..\..\Pages\ViewerMenuPage.xaml"
            this.AddCommentButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AddCommentButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CommentStatButton = ((System.Windows.Controls.Border)(target));
            
            #line 18 "..\..\..\Pages\ViewerMenuPage.xaml"
            this.CommentStatButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CommentStatButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PageCountTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.PageDownButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\ViewerMenuPage.xaml"
            this.PageDownButton.Click += new System.Windows.RoutedEventHandler(this.PageDownButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PictureListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.PageUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Pages\ViewerMenuPage.xaml"
            this.PageUpButton.Click += new System.Windows.RoutedEventHandler(this.PageUpButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

