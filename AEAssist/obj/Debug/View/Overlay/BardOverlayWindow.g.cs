﻿#pragma checksum "..\..\..\..\View\Overlay\BardOverlayWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3939C3B333257851F33749BBE8E55B7214AC97CB9F6CEFD17405A6D8538FEFFF"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using AEAssist.DataBinding;
using AEAssist.View;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace AEAssist.View {
    
    
    /// <summary>
    /// BardOverlayWindow
    /// </summary>
    public partial class BardOverlayWindow : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 155 "..\..\..\..\View\Overlay\BardOverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ChooseNextSong;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\..\View\Overlay\BardOverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CurrTriggerLine;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\..\View\Overlay\BardOverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeTriggerLine;
        
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
            System.Uri resourceLocater = new System.Uri("/AEAssist;component/view/overlay/bardoverlaywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Overlay\BardOverlayWindow.xaml"
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
            this.ChooseNextSong = ((System.Windows.Controls.ComboBox)(target));
            
            #line 157 "..\..\..\..\View\Overlay\BardOverlayWindow.xaml"
            this.ChooseNextSong.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ChooseNextSong_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CurrTriggerLine = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ChangeTriggerLine = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\..\..\View\Overlay\BardOverlayWindow.xaml"
            this.ChangeTriggerLine.Click += new System.Windows.RoutedEventHandler(this.ChangeTriggerLine_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

