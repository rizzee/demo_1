﻿#pragma checksum "..\..\Window2(CS).xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7C453BFE6FD16A2E358E5A06EB14DBA3BBDCEF81AB79993EA101FEB5067BD5DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// Window2_CS_
    /// </summary>
    public partial class Window2_CS_ : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Window2(CS).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cs1_Button;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window2(CS).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button csz_Button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Window2(CS).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button css_Button;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Window2(CS).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button csgo_Button;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Window2(CS).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement player;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Window2(CS).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button return_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/window2(cs).xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window2(CS).xaml"
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
            
            #line 8 "..\..\Window2(CS).xaml"
            ((WpfApp2.Window2_CS_)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Window_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cs1_Button = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Window2(CS).xaml"
            this.cs1_Button.Click += new System.Windows.RoutedEventHandler(this.cs1_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.csz_Button = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Window2(CS).xaml"
            this.csz_Button.Click += new System.Windows.RoutedEventHandler(this.csz_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.css_Button = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Window2(CS).xaml"
            this.css_Button.Click += new System.Windows.RoutedEventHandler(this.css_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.csgo_Button = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Window2(CS).xaml"
            this.csgo_Button.Click += new System.Windows.RoutedEventHandler(this.csgo_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.player = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 7:
            this.return_Button = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\Window2(CS).xaml"
            this.return_Button.Click += new System.Windows.RoutedEventHandler(this.return_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

