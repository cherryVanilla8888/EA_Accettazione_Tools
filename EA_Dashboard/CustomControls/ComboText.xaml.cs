using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EA_Dashboard.CustomControls
{
    /// <summary>
    /// Logica di interazione per ComboText.xaml
    /// </summary>
    public partial class ComboText : UserControl
    {
        public object ItemList
        {
            get { return (object)GetValue(ItemListProperty); }
            set { SetValue(ItemListProperty, value); }
        }
        public object ComboVisible
        {
            get { return (object)GetValue(ComboVisibleProperty); }
            set { SetValue(ComboVisibleProperty, value); }
        }

        public object TextVisible
        {
            get { return (object)GetValue(TextVisibleProperty); }
            set { SetValue(TextVisibleProperty, value); }
        }

        public object SelectedElement
        {
            get { return (object)GetValue(SelectedElementProperty); }
            set { SetValue(SelectedElementProperty, value); }
        }
        public object Text
        {
            get { return (object)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BoxTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemListProperty =
            DependencyProperty.Register("ItemList", typeof(object), typeof(ComboText), new PropertyMetadata(""));

        public static readonly DependencyProperty SelectedElementProperty =
            DependencyProperty.Register("SelectedElement", typeof(object), typeof(ComboText), new PropertyMetadata(""));

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(object), typeof(ComboText), new PropertyMetadata(""));

        public static readonly DependencyProperty TextVisibleProperty =
           DependencyProperty.Register("TextVisible", typeof(object), typeof(ComboText), new PropertyMetadata(""));

        public static readonly DependencyProperty ComboVisibleProperty =
            DependencyProperty.Register("ComboVisible", typeof(object), typeof(ComboText), new PropertyMetadata(""));


        public ComboText()
        {
            InitializeComponent();
        }
    }
}
