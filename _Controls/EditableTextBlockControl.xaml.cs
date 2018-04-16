using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace VocabularyProNamespace
{
    /// <summary>
    /// Interaction logic for EditableTextBlockControl.xaml
    /// </summary>
    public partial class EditableTextBlockControl : UserControl
    {
        string oldText;

        public EditableTextBlockControl()
        {
            InitializeComponent();
            base.Focusable = true;
            base.FocusVisualStyle = null;
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(EditableTextBlockControl), new UIPropertyMetadata());


        public void IsEditMode(object sender, bool isEditMode)
        {
            if (isEditMode)
            {
                var txtBox = (TextBox)((Grid)((TextBlock)sender).Parent).Children[1];
                txtBox.Visibility = Visibility.Visible;
                txtBox.SelectAll();
                FocusHelper.Focus(txtBox);
                ((TextBlock)sender).Visibility = Visibility.Collapsed;
            }
            else
            {
                var txtBlock = (TextBlock)((Grid)((TextBox)sender).Parent).Children[0];

                txtBlock.Visibility = Visibility.Visible;
                ((TextBox)sender).Visibility = Visibility.Collapsed;
            }
        }


        private void txtMeaning_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Text == "")
            {
                TextBox txt = sender as TextBox;
                DataObject<string> data = txt.DataContext as DataObject<string>;

                ListBox lb = FindAncestor<ListBox>(txt) as ListBox;

                ObservableCollection<DataObject<string>> Meanings = lb.ItemsSource as ObservableCollection<DataObject<string>>;

                Meanings.Remove(data);
                return;
            }
            IsEditMode(sender, false);
        }

        private void txtMeaning_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.F2) || (e.Key == Key.Enter))
            {
                IsEditMode(sender, false);
                oldText = Text;
            }
            else if (e.Key == Key.Escape)
            {
                Text = oldText;
                IsEditMode(sender, false);
            }
        }

        private void txtMeaning_Loaded(object sender, RoutedEventArgs e)
        {
            //TextBox txt = sender as TextBox;
            //txt.Text = Text;
            this.oldText = Text;
        }

        private void txtBlkMeaning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                IsEditMode(sender, true);
            }
        }

        private void txtBlkMeaning_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                IsEditMode(sender, true);
        }


        public static T FindAncestor<T>(DependencyObject from)
            where T : class
        {
            if (from == null)
            {
                return null;
            }

            T candidate = from as T;
            if (candidate != null)
            {
                return candidate;
            }

            return FindAncestor<T>(VisualTreeHelper.GetParent(from));
        }
    }
}
