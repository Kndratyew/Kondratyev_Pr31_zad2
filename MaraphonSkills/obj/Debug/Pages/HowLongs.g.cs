#pragma checksum "..\..\..\Pages\HowLongs.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3465A8E49C36C69A0952175E7E4ED10564B82BB6024658C7751E030A840B209"
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
    /// HowLongs
    /// </summary>
    public partial class HowLongs : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\Pages\HowLongs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\HowLongs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtName2;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\HowLongs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridSpeed;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\HowLongs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridDistance;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Pages\HowLongs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtInfo;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Pages\HowLongs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtInfo2;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Pages\HowLongs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/MaraphonSkills;component/pages/howlongs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\HowLongs.xaml"
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
            this.txtName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtName2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.gridSpeed = ((System.Windows.Controls.DataGrid)(target));
            
            #line 48 "..\..\..\Pages\HowLongs.xaml"
            this.gridSpeed.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.gridSpeed_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gridDistance = ((System.Windows.Controls.DataGrid)(target));
            
            #line 65 "..\..\..\Pages\HowLongs.xaml"
            this.gridDistance.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.gridDistance_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtInfo2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.imgInfo = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

