﻿#pragma checksum "..\..\..\winSettings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0FD5AE9CE024E5524B1B8CD7DA25E9909B68B131"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ColorPickerLib.Controls;
using LinePutScript.Localization.WPF;
using Panuon.WPF.UI;
using Panuon.WPF.UI.Configurations;
using Panuon.WPF.UI.Resources;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using VPet.Plugin.ThemeCreator;


namespace VPet.Plugin.ThemeCreator {
    
    
    /// <summary>
    /// winSettings
    /// </summary>
    public partial class winSettings : Panuon.WPF.UI.WindowX, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 48 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ColorPickerLib.Controls.ColorPicker colorPicker;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl mainTabControl;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThemeName;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThemeDescription;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl themesList;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ToolBarGrid;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MessageBarGrid;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BetterBuyGrid;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SettingsGrid;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid OtherGrid;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\..\winSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelColorPicker;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VPet.Plugin.ThemeCreator;component/winsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\winSettings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\winSettings.xaml"
            ((VPet.Plugin.ThemeCreator.winSettings)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.WClosing);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\winSettings.xaml"
            ((VPet.Plugin.ThemeCreator.winSettings)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.WindowX_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.colorPicker = ((ColorPickerLib.Controls.ColorPicker)(target));
            
            #line 48 "..\..\..\winSettings.xaml"
            this.colorPicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.ColorValueUpdate);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mainTabControl = ((System.Windows.Controls.TabControl)(target));
            
            #line 49 "..\..\..\winSettings.xaml"
            this.mainTabControl.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.HideCancel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ThemeName = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\winSettings.xaml"
            this.ThemeName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextInputForFile);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ThemeDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 75 "..\..\..\winSettings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveTheme);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 76 "..\..\..\winSettings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ImportFromPastebin);
            
            #line default
            #line hidden
            return;
            case 8:
            this.themesList = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 13:
            this.ToolBarGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 14:
            this.MessageBarGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 15:
            this.BetterBuyGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 16:
            this.SettingsGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 17:
            this.OtherGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 18:
            this.cancelColorPicker = ((System.Windows.Controls.Button)(target));
            
            #line 236 "..\..\..\winSettings.xaml"
            this.cancelColorPicker.Click += new System.Windows.RoutedEventHandler(this.CancelColorPicker);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 84 "..\..\..\winSettings.xaml"
            ((System.Windows.Controls.Border)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.HoverThemeEnter);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\winSettings.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.HoverThemeLeave);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\winSettings.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ChangeTheme);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 102 "..\..\..\winSettings.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.CheckThemeEnter);
            
            #line default
            #line hidden
            
            #line 102 "..\..\..\winSettings.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.CheckThemeLeave);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 105 "..\..\..\winSettings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CopyTheme);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 108 "..\..\..\winSettings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteTheme);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
