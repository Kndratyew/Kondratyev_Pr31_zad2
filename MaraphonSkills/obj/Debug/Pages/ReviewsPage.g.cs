#pragma checksum "..\..\..\Pages\ReviewsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D64BDAA46D4DBA01462C3C90470FE3F47BD21AC4084367455E1B7E7FD689B242"
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
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
    /// ReviewsPage
    /// </summary>
    public partial class ReviewsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\ReviewsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl ReviewItemsControl;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\ReviewsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ManFilterButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\ReviewsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ManCountTextBlock;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\ReviewsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border WomenFilterButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\ReviewsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WomanCountTextBlock;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Pages\ReviewsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border RussiaFilterButton;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\ReviewsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RussiaCountTextBlock;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Pages\ReviewsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border AnotherCountriesButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\ReviewsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AnotherCountriesCountTextBlock;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Pages\ReviewsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.DataVisualization.Charting.Chart ReviewChart;
        
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
            System.Uri resourceLocater = new System.Uri("/MaraphonSkills;component/pages/reviewspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ReviewsPage.xaml"
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
            this.ReviewItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 2:
            this.ManFilterButton = ((System.Windows.Controls.Border)(target));
            
            #line 40 "..\..\..\Pages\ReviewsPage.xaml"
            this.ManFilterButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ManFilterButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ManCountTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.WomenFilterButton = ((System.Windows.Controls.Border)(target));
            
            #line 47 "..\..\..\Pages\ReviewsPage.xaml"
            this.WomenFilterButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WomenFilterButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.WomanCountTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.RussiaFilterButton = ((System.Windows.Controls.Border)(target));
            
            #line 54 "..\..\..\Pages\ReviewsPage.xaml"
            this.RussiaFilterButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.RussiaFilterButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RussiaCountTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.AnotherCountriesButton = ((System.Windows.Controls.Border)(target));
            
            #line 61 "..\..\..\Pages\ReviewsPage.xaml"
            this.AnotherCountriesButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AnotherCountriesButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AnotherCountriesCountTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.ReviewChart = ((System.Windows.Forms.DataVisualization.Charting.Chart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

