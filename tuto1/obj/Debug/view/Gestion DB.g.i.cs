// Updated by XamlIntelliSenseFileGenerator 14/01/2022 14:18:00
#pragma checksum "..\..\..\view\Gestion DB.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74AB661077C66DFFB5532F20C46AF1CA7137DFEEEC5EFF8E76323E6742FF7A08"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using tuto1.view;


namespace tuto1.view
{


    /// <summary>
    /// Gestion_DB
    /// </summary>
    public partial class Gestion_DB : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/tuto1;component/view/gestion%20db.xaml", System.UriKind.Relative);

#line 1 "..\..\..\view\Gestion DB.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.ListBox listBox;
        internal System.Windows.Controls.Grid detail;
        internal System.Windows.Controls.Label label1;
        internal System.Windows.Controls.TextBox tb_id;
        internal System.Windows.Controls.Label label2;
        internal System.Windows.Controls.TextBox tb_nom;
        internal System.Windows.Controls.Label label3;
        internal System.Windows.Controls.TextBox tb_prix;
        internal System.Windows.Controls.Label label4;
        internal System.Windows.Controls.TextBox tb_image;
        internal System.Windows.Controls.Button btn_supprimer;
        internal System.Windows.Controls.Button btn_modifier;
        internal System.Windows.Controls.Button btn_ajouter;
        internal System.Windows.Controls.Button btn_rafraichir;
    }
}

