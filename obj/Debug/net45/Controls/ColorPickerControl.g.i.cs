﻿#pragma checksum "..\..\..\..\Controls\ColorPickerControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5144CF78AF8EF75148AF9C1D7B116E3702AA8D82"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace FlatStyle.Controls {
    
    
    /// <summary>
    /// ColorPickerControl
    /// </summary>
    public partial class ColorPickerControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ColorImage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasImage;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ellipsePixel;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAlpha;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRed;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGreen;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBlue;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ColorDisplay;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAll;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border AlphaBorder;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Controls\ColorPickerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider AlphaSlider;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FlatStyle;V1.6.2.0;component/controls/colorpickercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\ColorPickerControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 5 "..\..\..\..\Controls\ColorPickerControl.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.AlphaSlider_MouseWheel);
            
            #line default
            #line hidden
            
            #line 5 "..\..\..\..\Controls\ColorPickerControl.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CanvasImage_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 12 "..\..\..\..\Controls\ColorPickerControl.xaml"
            this.MainGrid.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CanvasImage_MouseDown);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\Controls\ColorPickerControl.xaml"
            this.MainGrid.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CanvasImage_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ColorImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.canvasImage = ((System.Windows.Controls.Canvas)(target));
            
            #line 35 "..\..\..\..\Controls\ColorPickerControl.xaml"
            this.canvasImage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CanvasImage_MouseDown);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\..\Controls\ColorPickerControl.xaml"
            this.canvasImage.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CanvasImage_MouseUp);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\..\Controls\ColorPickerControl.xaml"
            this.canvasImage.MouseMove += new System.Windows.Input.MouseEventHandler(this.CanvasImage_MouseMove);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ellipsePixel = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 6:
            this.txtAlpha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtRed = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtGreen = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtBlue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ColorDisplay = ((System.Windows.Controls.Border)(target));
            return;
            case 11:
            this.txtAll = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.AlphaBorder = ((System.Windows.Controls.Border)(target));
            
            #line 85 "..\..\..\..\Controls\ColorPickerControl.xaml"
            this.AlphaBorder.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.AlphaSlider_MouseWheel);
            
            #line default
            #line hidden
            return;
            case 13:
            this.AlphaSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 96 "..\..\..\..\Controls\ColorPickerControl.xaml"
            this.AlphaSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.AlphaSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
